using System;
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
    public partial class SessionInfo : Form
    {
        public SessionInfo()
        {
            InitializeComponent();
            LoadFilms();
            LoadHalls();
        }
        private const string ConnectionString =
            @"Data Source=ALEXCLANKPC;Initial Catalog=CinemaChainSystem;Integrated Security=True;";

        public string operation = "";
        public Session editingSession = new Session();
        public void LoadFilms()
        {
            filmComboBox.Items.Clear();
            int index = -1;
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"Select * from Film";

                var cmd = new SqlCommand(cmdTxt, cnn);
                
                int i = 0;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = Int32.Parse(dr["ID"].ToString());
                        string name = dr["Name"].ToString();
                        int length = Int32.Parse(dr["Length"].ToString());
                        string poster = dr["Poster"].ToString();
                        string description = dr["Description"].ToString();
                        DateTime release = DateTime.Parse(dr["ReleaseDate"].ToString());
                        int ratingID = Int32.Parse(dr["RatingID"].ToString());

                        Film film = new Film(id, name, length, poster, description, release, ratingID);
                        if (operation == "Edit" && film.ID == editingSession.FilmID)
                            index = i;
                        filmComboBox.Items.Add(film);
                        i++;
                    }
                }
            }
            if (operation == "Edit")
            {
                filmComboBox.SelectedItem = filmComboBox.Items[index];
            }
        }
        public void LoadHalls()
        {
            hallComboBox.Items.Clear();
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"Select * from Hall";

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = Int32.Parse(dr["ID"].ToString());
                        int number = Int32.Parse(dr["Number"].ToString());
                        string description = dr["Description"].ToString();
                        int rowsCount = Int32.Parse(dr["RowsCount"].ToString());
                        int placesInARow = Int32.Parse(dr["PlacesInARow"].ToString());
                        int cinemaID = Int32.Parse(dr["CinemaID"].ToString());
                        Hall hall = new Hall(id, number, description, rowsCount, placesInARow, cinemaID);
                        hallComboBox.Items.Add(hall);
                    }
                }
            }
        }
        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!CheckFill(dateTxtBox.Text, "дату сеанса"))
                return;
            if (!CheckFill(priceTxtBox.Text, "стоимость билета на сеанс"))
                return;
            if (!CheckFill(typeTxtBox.Text, "тип кинематографической системы сеанса (прим. 2D, 3D, IMAX и т.п.)"))
                return;
            if (!CheckFill(filmComboBox.Text, "фильм"))
                return;
            

            if (operation == "Add")
            {
                if (!CheckFill(hallComboBox.Text, "зал"))
                    return;
                Film film = (Film)filmComboBox.SelectedItem;
                if (DateTime.Parse(dateTxtBox.Text) > film.ReleaseDate)
                {
                    AddInDB();
                    MessageBox.Show($"Сеанс:\n Дата: {dateTxtBox.Text}\n Фильм: \"{filmComboBox.Text}\"\n" +
                        $" Зал: {hallComboBox.Text} (ID: {((Hall)hallComboBox.SelectedItem).ID} " +
                        $"CinemaID: {((Hall)hallComboBox.SelectedItem).CinemaID})\n ДОБАВЛЕН",
                        "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show($"Дата сеанса раньше, чем дата премьеры фильма!",
                        "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dateTxtBox.Text = "";
                    return;
                }
            }
            else
            {
                EditInDB();
                MessageBox.Show($"Фильм отредактрован.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            dateTxtBox.Text = "";
            priceTxtBox.Text = "";
            typeTxtBox.Text = "";
            filmComboBox.Text = "";
            hallComboBox.Text = "";

        }

        private void AddInDB()
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"INSERT INTO Session (Date, Price, Type, FilmID, HallID) " +
                    $"VALUES ('{dateTxtBox.Text}', '{priceTxtBox.Text}', '{typeTxtBox.Text}', " +
                    $"'{((Film)filmComboBox.SelectedItem).ID}', " +
                    $"'{((Hall)hallComboBox.SelectedItem).ID}')";

                var cmd = new SqlCommand(cmdTxt, cnn);

                cmd.ExecuteNonQuery();
            }
        }
        private void EditInDB()
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"UPDATE Session set Date = '{dateTxtBox.Text}', Price = '{priceTxtBox.Text}', " +
                    $"Type = '{typeTxtBox.Text}', " +
                    $"FilmID = '{((Film)filmComboBox.SelectedItem).ID}', " +
                    $"HallID = '{editingSession.HallID}' " +
                    $"where ID = {editingSession.ID}";

                var cmd = new SqlCommand(cmdTxt, cnn);

                cmd.ExecuteNonQuery();
            }
        }
        private bool CheckFill(string txt, string warning)
        {
            if (txt == "")
            {
                MessageBox.Show($"Заполните {warning}!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }


        private void InputDigsSpace(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
            }
        }
        private void InputDigsComa(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }
        private void dateTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (dateTxtBox.Text.Length == 2 || dateTxtBox.Text.Length == 5)
            {
                dateTxtBox.Text += ".";
                dateTxtBox.SelectionStart = dateTxtBox.Text.Length;
                return;
            }

            if (dateTxtBox.Text.Length == 13)
            {
                dateTxtBox.Text += ":";
                dateTxtBox.SelectionStart = dateTxtBox.Text.Length;
                return;
            }

            if (dateTxtBox.Text.Length > 16)
                dateTxtBox.Text = dateTxtBox.Text.Remove(16);
            dateTxtBox.SelectionStart = dateTxtBox.Text.Length;
        }

        private void dateTxtBox_Leave(object sender, EventArgs e)
        {
            if (dateTxtBox.Text == "")
                return;
            int count = 0;
            DateTime date = new DateTime();
            bool isCorrectDate = DateTime.TryParse(dateTxtBox.Text, out date);
            if (!isCorrectDate)
            {
                MessageBox.Show("Введите корректную дату!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateTxtBox.Text = "";
                return;
            }

            
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                string hallID = "";
                if (operation == "Edit")
                {
                    hallID = $"{editingSession.HallID}";
                }
                else
                {
                    Hall hall = (Hall)hallComboBox.SelectedItem;
                    hallID = hall.ID.ToString();
                }

                Film film = (Film)filmComboBox.SelectedItem;
                string cmdTxt = $"SELECT COUNT(*) as Count FROM Hall " +
                    $"inner join Session on Hall.ID = Session.HallID " +
                    $"inner join Film on Film.ID = Session.FilmID " +
                    $"WHERE Hall.ID = {hallID} AND " +
                        $"(" +
                            $"(Session.Date >= '{date}' AND Session.Date <= '{date.AddMinutes(film.Length + 5)}') " +
                            $"OR" +
                            $"(Session.Date < '{date}' AND DATEADD (minute, Film.Length, Session.Date) > '{date}')" +
                        $")";

                var cmd = new SqlCommand(cmdTxt, cnn);                
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        count = Int32.Parse(dr["Count"].ToString());
                    }
                }
            }
            if (count != 0)
            {
                MessageBox.Show("Введите корректную дату!\n" +
                    "Дата сеанса в данном зале не должна совпадать с другими сеансами!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateTxtBox.Text = "";
            }


        }

        private void priceTxtBox_Leave(object sender, EventArgs e)
        {
            if (priceTxtBox.Text == "")
                return;
            Decimal price = 0;
            bool isCorrectPrice = Decimal.TryParse(priceTxtBox.Text, out price);
            if (!isCorrectPrice || price > 2000)
            {
                MessageBox.Show("Введите корректную цену.\n Цена за билет на сеанс не может быть больше 2000 рублей!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                priceTxtBox.Text = "";
            }
        }

        private void filmComboBox_TextChanged(object sender, EventArgs e)
        {
            if (filmComboBox.SelectedItem == null)
            {
                filmComboBox.Text = "";
                dateTxtBox.Enabled = false;
                dateTxtBox.Text = "";
            }
        }
        private void filmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filmComboBox.SelectedItem != null)
            {
                if (operation == "Add" && hallComboBox.SelectedItem != null)
                {
                    dateTxtBox.Enabled = true;
                    dateTxtBox.Text = "";
                }
            }
        }
        private void typeTxtBox_Leave(object sender, EventArgs e)
        {
            if (typeTxtBox.Text != "")
                MessageBox.Show("Убедитесь, что тип сеанса совпадает с имеющейся кинематографической системой зала!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void hallComboBox_TextChanged(object sender, EventArgs e)
        {
            if (hallComboBox.SelectedItem == null && operation != "Edit")
            {
                hallComboBox.Text = "";
                dateTxtBox.Enabled = false;
                dateTxtBox.Text = "";
            }
        }
        private void hallComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hallComboBox.SelectedItem != null && filmComboBox.SelectedItem != null)
            {
                dateTxtBox.Enabled = true;
                dateTxtBox.Text = "";
            }
        }

        private void dateTxtBox_Enter(object sender, EventArgs e)
        {
            dateTxtBox.Text = "";
        }
    }
}
