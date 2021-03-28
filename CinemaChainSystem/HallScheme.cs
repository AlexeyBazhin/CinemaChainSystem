using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaChainSystem
{
    public partial class HallScheme : Form
    {
        public HallScheme()
        {
            InitializeComponent();
        }
        private const string ConnectionString =
            @"Data Source=ALEXCLANKPC;Initial Catalog=CinemaChainSystem;Integrated Security=True;";
        public Session session = new Session();
        private int rowsCount;
        private int placesInARow;
        private int locationX;
        private Size buttonSize;
        private int chooseCount = 0;
        private Color freeBColor = Color.DarkSlateBlue;
        private Color freeFColor = Color.White;
        private Color boughtBColor = Color.Black;
        private Color boughtFColor = Color.White;
        private Color bookedBColor = Color.Gray;
        private Color bookedFColor = Color.Black;
        private Color choseBColor = Color.White;
        private Color choseFColor = Color.Black;
        private Color rowBColor = Color.Red;
        private Color rowFColor = Color.Black;

        public void BtnColor(Button btn, Color bColor, Color fColor)
        {
            btn.BackColor = bColor;
            btn.ForeColor = fColor;
        }
        public void LoadScheme()
        {            
            LoadDimension();
            int edgeSize = placeListView.Size.Height / rowsCount;
            buttonSize = new Size(edgeSize, edgeSize);
            ChangeLocationX();
            GenerateBtns();
            ColorBtns();
            EnableElements();
        }
        private void ChangeLocationX()
        {
            locationX = (placeListView.Width - (buttonSize.Width * (placesInARow + 2))) / 2;
            screenLabel.Size = new Size(buttonSize.Width * (placesInARow + 2), screenLabel.Size.Height);
            screenLabel.Location = new Point(locationX, screenLabel.Location.Y);                        
        }
        private void GenerateBtns()
        {
            placeListView.Controls.Clear();
            for (int i = 0; i < rowsCount; i++)
            {
                AddBtn(i, -1, false);
                for (int j = 0; j < placesInARow; j++)
                {
                    AddBtn(i, j, true);
                }
                AddBtn(i, placesInARow, false);
            }
        }
        private void AddBtn(int i, int j, bool enabled)
        {
            Button btn = new Button();
            btn.Size = buttonSize;
            btn.Enabled = enabled;
            if (enabled)
            {
                btn.Text = (j + 1).ToString();
                BtnColor(btn, freeBColor, freeFColor);
            }
            else
            {
                btn.Text = (i + 1).ToString();
                BtnColor(btn, rowBColor, rowFColor);
            }
            
            float fontSize = btn.Width / 2 / btn.Text.Length;
            Font f = new Font("Arial", fontSize, FontStyle.Regular);
            btn.Font = f;           
            btn.Location = new Point(btn.Width * (j + 1) + locationX, btn.Height * i);
            placeListView.Controls.Add(btn);
            
            if (enabled)
            {
                btn.Tag = i + 1;
                int count = placeListView.Controls.Count;
                placeListView.Controls[count - 1].Click += new System.EventHandler(this.place_Click);

            }
        }
        private void LoadDimension()
        {
            using (var cnn = new SqlConnection())
            {

                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"select Hall.RowsCount, Hall.PlacesInARow from Session " +
                    $"inner join Hall on Session.HallID = Hall.ID where Session.ID = @sessionID";
                var cmd = new SqlCommand(cmdTxt, cnn);
                cmd.Parameters.AddWithValue("@sessionID", session.ID);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        rowsCount = Int32.Parse(dr["RowsCount"].ToString());
                        placesInARow = Int32.Parse(dr["PlacesInARow"].ToString());
                    }
                }                
            }
        }
        private void ColorBtns()
        {
            List<int[]> placeInfos = new List<int[]>();
            List<string> placeStatuses = new List<string>();
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"Select PlaceNumber, RowNumber, Status from Place " +
                    $"inner join Ticket on Place.ID = Ticket.PlaceID " +
                    $"where Place.SessionID = {session.ID}";
                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {                        
                        int[] placeInfo = new int[] { Int32.Parse(dr["RowNumber"].ToString()), Int32.Parse(dr["PlaceNumber"].ToString())};
                        placeInfos.Add(placeInfo);

                        placeStatuses.Add(dr["Status"].ToString());
                    }
                }
            }

            for (int i = 0; i < placeInfos.Count; i++)
            {
                int rowNumber = placeInfos[i][0];
                int placeNumber = placeInfos[i][1];
                int index = (rowNumber - 1) * (placesInARow + 2) + placeNumber;
                Button btn = (Button)placeListView.Controls[index];
                if (placeStatuses[i] == "Куплено")
                {
                    BtnColor(btn, boughtBColor, boughtFColor);
                }
                else
                {
                    BtnColor(btn, bookedBColor, bookedFColor);
                }
            }            
        }
        private void placeListView_Resize(object sender, EventArgs e)
        {
            int edgeSize = placeListView.Size.Height / rowsCount;
            buttonSize = new Size(edgeSize, edgeSize);
            ChangeLocationX();
            GenerateBtns();
            ColorBtns();
        }
        private void EnableElements()
        {
            if (chooseCount == 0)
            {
                cancelRadioButton.Enabled = true;
                buyBtn.Enabled = false;
                bookBtn.Enabled = false;
            }
            else
            {
                cancelRadioButton.Enabled = false;
                buyBtn.Enabled = true;
                bookBtn.Enabled = true;
            }
        }
        private void place_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (chooseRadioButton.Checked && btn.BackColor != boughtBColor && btn.BackColor != bookedBColor)
            {                
                if (btn.BackColor != choseBColor)
                {
                    BtnColor(btn, choseBColor, choseFColor);
                    ++chooseCount;

                }
                else
                {
                    BtnColor(btn, freeBColor, freeFColor);
                    --chooseCount;
                }
                EnableElements();
                priceLabel.Text = $"Стоимость: {session.Price * chooseCount}";
            }

            if (cancelRadioButton.Checked && btn.BackColor != freeBColor)
            {
                BtnColor(btn, freeBColor, freeFColor);
                DeleteFromDB((int)btn.Tag, Int32.Parse(btn.Text));
            }            
        }
        
        
        private void buyBtn_Click(object sender, EventArgs e)
        {
            FinishAction("Куплено", boughtBColor, boughtFColor);
        }
        private void bookBtn_Click(object sender, EventArgs e)
        {
            FinishAction("Забронировано", bookedBColor, bookedFColor);
        }
        private void FinishAction(string action, Color backColor, Color foreColor)
        {
            AddInDB(action);
            foreach (Button btn in placeListView.Controls)
            {
                if (btn.BackColor == choseBColor)
                {
                    BtnColor(btn, backColor, foreColor);
                }
            }
            chooseCount = 0;
            EnableElements();
            priceLabel.Text = $"Стоимость: {session.Price * chooseCount}";
        }
        private List<int[]> ClickedPlacesSearch()
        {
            List<int[]> places = new List<int[]>();
            foreach (Button btn in placeListView.Controls)
            {
                if (btn.BackColor == choseBColor)
                    places.Add(new int[]{ (int)btn.Tag, Int32.Parse(btn.Text)});
            }
            return places;
        }
        private void AddInDB(string status)
        {
            List<int[]> places = ClickedPlacesSearch();
            using (var cnn = new SqlConnection())
            {

                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = "";
                var cmd = new SqlCommand();
                List<int> placesID = new List<int>();

                foreach (int[] place in places)
                {
                    cmdTxt = $"INSERT INTO Place (PlaceNumber, RowNumber, SessionID) " +
                        $"VALUES ({place[1]}, {place[0]}, {session.ID})";
                    cmd = new SqlCommand(cmdTxt, cnn);
                    cmd.ExecuteNonQuery();

                    cmdTxt = $"Select ID from Place where Place.SessionID = {session.ID} " +
                    $"AND Place.RowNumber = {place[0]} AND Place.PlaceNumber = {place[1]}";
                    cmd = new SqlCommand(cmdTxt, cnn);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            placesID.Add(Int32.Parse(dr["ID"].ToString()));
                        }
                    }
                }
                
                foreach (int i in placesID)
                {
                    cmdTxt = $"INSERT INTO Ticket (SaleDate, Status, PlaceID) " +
                        $"VALUES ('{DateTime.Now}', '{status}', {i})";
                    cmd = new SqlCommand(cmdTxt, cnn);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void DeleteFromDB(int rowNumber, int placeNumber)
        {

            using (var cnn = new SqlConnection())
            {

                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"DELETE from Place where SessionID = {session.ID} " +
                    $"AND RowNumber = {rowNumber} AND PlaceNumber = {placeNumber}";
                var cmd = new SqlCommand(cmdTxt, cnn);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show($"Билет освобожден: место {placeNumber} / ряд {rowNumber}", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
