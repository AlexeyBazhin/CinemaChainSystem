using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaChainSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadCities();      
        }
        
        private const string ConnectionString =
            @"Data Source=ALEXCLANKPC;Initial Catalog=CinemaChainSystem;Integrated Security=True;";
        private const string login = "admin";
        private const string password = "123qwe";
        private ArrayList colNames = new ArrayList();
        private string curQuery = "";
        
        public void LoadCities()
        {
            cityComboBox.Items.Clear();
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                var cmd = new SqlCommand("Select * from City", cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        City city = new City(Int32.Parse(dr["ID"].ToString()), dr["Name"].ToString(), dr["Region"].ToString());
                        cityComboBox.Items.Add(city);
                    }
                }
            }
        }
        public void LoadCinemas(int cityID)
        {
            cinemaComboBox.Items.Clear();
            cinemaComboBox.Text = "";

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                var cmd = new SqlCommand("Select * from Cinema WHERE Cinema.CityID = @cityID", cnn);
                cmd.Parameters.AddWithValue("cityId", cityID);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = Int32.Parse(dr["ID"].ToString());
                        string name = dr["Name"].ToString();
                        string address = dr["Address"].ToString();
                        string phone = dr["PhoneNumber"].ToString();
                        DateTime open = DateTime.Parse(dr["OpeningDate"].ToString());
                        DateTime close = new DateTime(1, 1, 1);
                        //int cityID = Int32.Parse(dr["CityID"].ToString());
                        Cinema cinema = new Cinema();
                        try
                        {
                            close = DateTime.Parse(dr["ClosingDate"].ToString());
                            cinema = new Cinema(id, name, address, phone, open, close, cityID);
                        }
                        catch (Exception ex)
                        {
                            cinema = new Cinema(id, name, address, phone, open, cityID);
                        }

                        cinemaComboBox.Items.Add(cinema);
                    }
                }
            }
        }
        public void LoadFilms(int cinemaID, string dateCond)
        {
            filmComboBox.Items.Clear();
            filmComboBox.Text = "";

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                DateTime nowPlusHalfHour = DateTime.Now.AddMinutes(30);

                string cmdTxt = "select * from Film where Film.ID IN" +
                    $"(select Session.FilmID from Session where Session.Date > '{nowPlusHalfHour}' {dateCond}" +
                    $"AND HallID IN" +
                        "(select Hall.ID from Hall where Hall.CinemaID = @cinemaID) )";

                var cmd = new SqlCommand(cmdTxt, cnn);

                cmd.Parameters.AddWithValue("cinemaID", cinemaID);

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

                        filmComboBox.Items.Add(film);
                    }
                }
            }
        }
        public void LoadSessions(int filmID, int cinemaID)
        {
            sessFromComboBox.Items.Clear();
            sessToComboBox.Items.Clear();
            sessFromComboBox.Text = "";
            sessToComboBox.Text = "";

            string definiteFilm = "";
            if (filmID != -1)
                definiteFilm = $"AND Session.FilmID = {filmID}";

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                DateTime nowPlusHalfHour = DateTime.Now.AddMinutes(30);
                string cmdTxt = $"select Session.Date from Session where " +
                    $"Session.Date > '{nowPlusHalfHour}' {definiteFilm} AND " +
                     "Session.HallID IN " +
                        "(select Hall.ID from Hall where Hall.CinemaID = @cinemaID) " +
                     "group by Session.Date";
                var cmd = new SqlCommand(cmdTxt, cnn);

                cmd.Parameters.AddWithValue("cinemaID", cinemaID);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        DateTime date = DateTime.Parse(dr["Date"].ToString());

                        Session session = new Session(date);

                        sessFromComboBox.Items.Add(session);
                        sessToComboBox.Items.Add(session);
                    }
                }
            }
        }

        private void ComboBoxesTxtChanged(ComboBox sender, ComboBox[] children)
        {
            if (sender.SelectedItem == null)
            {
                for (int i = 0; i < children.Length; i++)
                    children[i].Enabled = false;

                if (sender.Text != "")
                    sender.ForeColor = Color.Red;
                else
                    sender.ForeColor = Color.Black;
            }
        }
        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cinemaComboBox.Enabled = true;
            cityComboBox.ForeColor = Color.Black;

            City city = (City)cityComboBox.SelectedItem;
            LoadCinemas(city.ID);
        }
        private void cityComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBox[] children = new ComboBox[4];
            children[0] = cinemaComboBox;
            children[1] = filmComboBox;
            children[2] = sessFromComboBox;
            children[3] = sessToComboBox;
            ComboBoxesTxtChanged(cityComboBox, children);
        }
        private void cinemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmComboBox.Enabled = true;
            sessFromComboBox.Enabled = true;
            sessToComboBox.Enabled = true;
            cinemaComboBox.ForeColor = Color.Black;

            Cinema cinema = (Cinema)cinemaComboBox.SelectedItem;
            LoadFilms(cinema.ID, "");
            LoadSessions(-1, cinema.ID);
            LoadCashierDataGridView();

        }
        private void cinemaComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBox[] children = new ComboBox[3];
            children[0] = filmComboBox;
            children[1] = sessFromComboBox;
            children[2] = sessToComboBox;
            ComboBoxesTxtChanged(cinemaComboBox, children);

            filmComboBox.Enabled = false;
            sessFromComboBox.Enabled = false;
            sessToComboBox.Enabled = false;
        }
        private void filmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmComboBox.ForeColor = Color.Black;
            Cinema cinema = (Cinema)cinemaComboBox.SelectedItem;
            Film film = (Film)filmComboBox.SelectedItem;

            LoadSessions(film.ID, cinema.ID);
            LoadCashierDataGridView();
        }

        private void filmComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBoxesTxtChanged(filmComboBox, new ComboBox[0]);

            if (filmComboBox.SelectedItem == null)
            {
                Cinema cinema = (Cinema)cinemaComboBox.SelectedItem;
                LoadSessions(-1, cinema.ID);
            }
            LoadCashierDataGridView();
        }
        private void sessComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isFromNull = false;
            if (sessFromComboBox.SelectedItem != null)
            {
                sessFromComboBox.ForeColor = Color.Black;
                isFromNull = true;
            }

            bool isToNull = false;
            if (sessToComboBox.SelectedItem != null)
            {
                sessToComboBox.ForeColor = Color.Black;
                isToNull = true;
            }

            if (isFromNull && isToNull)
            {
                Session sessionFrom = (Session)sessFromComboBox.SelectedItem;
                Session sessionTo = (Session)sessToComboBox.SelectedItem;
                if (sessionFrom.Date > sessionTo.Date)
                {
                    MessageBox.Show("Дата в поле 'Сеансы с:' не должна превышать дату в поле 'Сеансы по:' !", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //sessFromComboBox.Items.Clear();
                    sessFromComboBox.Text = "";
                    sessFromComboBox.SelectedItem = null;

                    //int filmID = -1;
                    //if (filmComboBox.SelectedItem != null)
                    //{
                    //    Film film = (Film)filmComboBox.SelectedItem;
                    //    filmID = film.ID;
                    //}

                    //LoadSessions(filmID, ((Cinema)cinemaComboBox.SelectedItem).ID);
                    return;
                }
            }
            LoadCashierDataGridView();

            //Cinema cinema = (Cinema)cinemaComboBox.SelectedItem;
            //Session session = (Session)sessFromComboBox.SelectedItem;
            //int filmID = -1;
            //if (filmComboBox.SelectedItem != null)
            //{
            //    filmID = ((Film)filmComboBox.SelectedItem).ID;
            //}

            //if (session.Date < DateTime.Now.AddMinutes(30))
            //{
            //    MessageBox.Show("Сеанс начался более 30 минут назад! Выебрите другой сеанс.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    LoadSessions(filmID, cinema.ID);
            //}
        }
        private void sessComboBoxes_TextChanged(object sender, EventArgs e)
        {
            ComboBoxesTxtChanged(sessFromComboBox, new ComboBox[0]);
            ComboBoxesTxtChanged(sessToComboBox, new ComboBox[0]);
        }

        private void LoadCashierDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("sessIDColumn", "ID");
            dataGridView1.Columns.Add("nameColumn", "Название");
            dataGridView1.Columns.Add("lengthColumn", "Длительность");
            dataGridView1.Columns.Add("ratingColumn", "Возрастное ограничение");
            dataGridView1.Columns.Add("dateColumn", "Дата");
            dataGridView1.Columns.Add("priceColumn", "Стоимость");
            dataGridView1.Columns.Add("hallColumn", "Зал");
            dataGridView1.Columns.Add("typeColumn", "Тип сеанса");


            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string filmCondit = "";
                if (filmComboBox.SelectedItem != null)
                {
                    Film film = (Film)filmComboBox.SelectedItem;
                    filmCondit = $"AND Film.Name = '{film.Name}'";
                }

                string sessFromCondit = "";
                if (sessFromComboBox.SelectedItem != null)
                {
                    Session session = (Session)sessFromComboBox.SelectedItem;
                    sessFromCondit = $"AND Session.Date >= '{session.Date}'";
                }

                string sessToCondit = "";
                if (sessToComboBox.SelectedItem != null)
                {
                    Session session = (Session)sessToComboBox.SelectedItem;
                    sessToCondit = $"AND Session.Date <= '{session.Date}'";
                }

                string cmdTxt = "SELECT Session.ID as SessID, Film.Name as FilmName, Film.Length, RatingSystem.Name as RatingName, Session.Date, Session.Price, Hall.Number, Session.Type " +
                    "FROM Film " +
                        "inner join RatingSystem on Film.RatingID = RatingSystem.ID " +
                        "inner join Session on Film.ID = Session.FilmID " +
                        "inner join Hall on Session.HallID = Hall.ID " +
                        "inner join Cinema on Hall.CinemaID = Cinema.ID " +
                    $"where Cinema.ID = @cinemaID {filmCondit} {sessFromCondit} {sessToCondit} ";

                var cmd = new SqlCommand(cmdTxt, cnn);
                Cinema cinema = (Cinema)cinemaComboBox.SelectedItem;
                cmd.Parameters.AddWithValue("cinemaID", cinema.ID);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ArrayList values = new ArrayList();
                        values.Add(Int32.Parse(dr["SessID"].ToString()));
                        values.Add(dr["FilmName"].ToString());
                        values.Add(Int32.Parse(dr["Length"].ToString()));
                        values.Add(dr["RatingName"].ToString());
                        values.Add(DateTime.Parse(dr["Date"].ToString()));
                        values.Add(Decimal.Parse(dr["Price"].ToString()));
                        values.Add(Int32.Parse(dr["Number"].ToString()));
                        values.Add(dr["Type"].ToString());
                        dataGridView1.Rows.Add(values.ToArray());
                    }
                }
                dataGridView1.Rows[0].Selected = true;
                dataGridView1_CellClick(this, new DataGridViewCellEventArgs(0, 0));
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int sessID = Int32.Parse(dataGridView1[0, rowIndex].Value?.ToString());

                using (var cnn = new SqlConnection())
                {
                    cnn.ConnectionString = ConnectionString;
                    cnn.Open();
                    string cmdTxt = $"select * from Film where " +
                        $"Film.ID IN (select Session.FilmID from Session where Session.ID = @sessID)";
                    var cmd = new SqlCommand(cmdTxt, cnn);

                    cmd.Parameters.AddWithValue("sessID", sessID);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Название фильма
                            string str = dr["Name"].ToString() + " (" + dataGridView1[3, rowIndex].Value.ToString() + ")";
                            filmNameLabel.Text = str;

                            //Длительность фильма
                            str = dataGridView1[2, rowIndex].Value.ToString();
                            str = $"{Int32.Parse(str) / 60} ч. {Int32.Parse(str) % 60} мин.";
                            hoursLabel.Text = str;

                            //Стоимость билета
                            str = dataGridView1[5, rowIndex].Value.ToString();
                            string[] priceRubs = str.Split(',', StringSplitOptions.RemoveEmptyEntries);
                            rubsLabel.Text = $"{priceRubs[0]} руб. {priceRubs[1]} коп.";

                            //Описание фильма
                            str = dr["Description"].ToString();
                            descriptionTxtBox.Text = str;

                            //ДОБАВИТЬ ПОСТЕР
                            str = dr["Poster"].ToString();
                            try
                            {
                                posterPicBox.Load(str);
                            }
                            catch
                            {
                                str = "https://res.cloudinary.com/ddpp4zqhr/image/upload/v1616604138/CinemaChainSystemImages/not-found-image-15383864787lu_gbbtly.jpg";
                                posterPicBox.Load(str);
                            }

                            ticketActionBtn.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ticketActionBtn.Enabled = false;
            }
        }
        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelComboBox.ForeColor = Color.Black;
            atrbComboBox.Items.Clear();
            atrbComboBox.Text = "";
            valueComboBox.Items.Clear();
            valueComboBox.Text = "";
            AdmLoadAtrbs("");
            atrbComboBox.Enabled = true;
        }

        private void modelComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBox[] children = new ComboBox[2];
            children[0] = atrbComboBox;
            children[1] = valueComboBox;
            ComboBoxesTxtChanged(modelComboBox, children);
        }
        private void AdmLoadAtrbs(string condition)
        {
            ticketActionBtn.Enabled = false;
            switch (modelComboBox.Text)
            {
                case "Фильм":
                    AdmLoadFilms(condition);
                    break;

                case "Сеанс":
                    AdmLoadSessions(condition);
                    break;

                case "Билет":
                    AdmLoadTickets(condition);
                    break;

                case "Зал":
                    AdmLoadHalls(condition);
                    break;

                case "Кинотеатр":
                    AdmLoadCinemas(condition);
                    break;

                case "Город":
                    AdmLoadCities(condition);
                    break;

                case "Рейтинговая система":
                    AdmLoadRatingSystems(condition);
                    break;

                case "Место":
                    AdmLoadPlaces(condition);
                    break;
            }

            atrbChekListBox.Items.Clear();
            atrbComboBox.Items.Clear();
            for (int i = 0; i < colNames.Count; i++)
            {
                atrbChekListBox.Items.Add(colNames[i], true);
                atrbComboBox.Items.Add(colNames[i]);
            }

        }
        private void AdmLoadColsName(SqlDataReader dr)
        {
            colNames = new ArrayList();
            for (int i = 0; i < dr.FieldCount; i++)
            {
                colNames.Add(dr.GetName(i));
            }
        }
        private void AdmLoadFilms(string condition)
        {
            dataGridView1.Columns.Clear();


            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();


                string cmdTxt = "Select * from (" +
                    "Select Film.*, RatingSystem.Name as RatingName from Film " +
                    "inner join RatingSystem on Film.RatingID = RatingSystem.ID " +
                    ") as result " +
                    $"{condition}";

                if (condition == "")
                    curQuery = cmdTxt;

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    AdmLoadColsName(dr);

                    for (int i = 0; i < colNames.Count; i++)
                    {
                        dataGridView1.Columns.Add($"{colNames[i]}Column", colNames[i].ToString());
                    }

                    while (dr.Read())
                    {
                        ArrayList values = new ArrayList();

                        values.Add(Int32.Parse(dr["ID"].ToString()));
                        values.Add(dr["Name"].ToString());
                        values.Add(Int32.Parse(dr["Length"].ToString()));
                        values.Add(dr["Poster"].ToString());
                        values.Add(dr["Description"].ToString());
                        values.Add(DateTime.Parse(dr["ReleaseDate"].ToString()));
                        values.Add(Int32.Parse(dr["RatingID"].ToString()));
                        values.Add(dr["RatingName"].ToString());

                        dataGridView1.Rows.Add(values.ToArray());
                    }
                }
            }
        }
        private void AdmLoadSessions(string condition)
        {
            dataGridView1.Columns.Clear();

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = "Select * from (" +
                    "Select Session.*, Film.Name as FilmName, Film.Length as FilmLength, Hall.Number as HallNumber " +
                    "from Session " +
                    "inner join Film on Session.FilmID = Film.ID " +
                    "inner join Hall on session.HallID = Hall.ID " +
                    ") as result " +
                    $"{condition}";

                if (condition == "")
                    curQuery = cmdTxt;

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    AdmLoadColsName(dr);

                    for (int i = 0; i < colNames.Count; i++)
                    {
                        dataGridView1.Columns.Add($"{colNames[i]}Column", colNames[i].ToString());
                    }
                    while (dr.Read())
                    {
                        ArrayList values = new ArrayList();

                        values.Add(Int32.Parse(dr["ID"].ToString()));
                        values.Add(DateTime.Parse(dr["Date"].ToString()));
                        values.Add(Decimal.Parse(dr["Price"].ToString()));
                        values.Add(dr["Type"].ToString());
                        values.Add(Int32.Parse(dr["FilmID"].ToString()));
                        values.Add(Int32.Parse(dr["HallID"].ToString()));
                        values.Add(dr["FilmName"].ToString());
                        values.Add(Int32.Parse(dr["FilmLength"].ToString()));
                        values.Add(Int32.Parse(dr["HallNumber"].ToString()));

                        dataGridView1.Rows.Add(values.ToArray());
                    }
                }
            }
        }
        private void AdmLoadTickets(string condition)
        {
            dataGridView1.Columns.Clear();

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = "Select * from (" +
                    "Select Ticket.*, Place.PlaceNumber, Place.RowNumber, Place.SessionID, Session.Date as SessionDate, " +
                    "Session.FilmID as FilmID, Film.Name as FilmName, Session.HallID, Hall.Number as HallNumber, " +
                    "Cinema.ID as CinemaID, Cinema.Name as CinemaName, Cinema.Address as CinemaAddress, Cinema.CityID as CityID " +
                    "from Ticket " +
                    "inner join Place on Ticket.PlaceID = Place.ID " +
                    "inner join Session on Place.SessionID = Session.ID " +
                    "inner join Film on Session.FilmID = Film.ID " +
                    "inner join Hall on Session.HallID = Hall.ID " +
                    "inner join Cinema on Hall.ID = Cinema.ID " +
                    ") as result " +
                    $"{condition}";

                if (condition == "")
                    curQuery = cmdTxt;

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    AdmLoadColsName(dr);

                    for (int i = 0; i < colNames.Count; i++)
                    {
                        dataGridView1.Columns.Add($"{colNames[i]}Column", colNames[i].ToString());
                    }

                    while (dr.Read())
                    {
                        ArrayList values = new ArrayList();

                        values.Add(Int32.Parse(dr["ID"].ToString()));
                        values.Add(Int32.Parse(dr["PlaceNumber"].ToString()));
                        values.Add(Int32.Parse(dr["RowNumber"].ToString()));
                        values.Add(Int32.Parse(dr["SessionID"].ToString()));
                        values.Add(Int32.Parse(dr["HallID"].ToString()));
                        values.Add(Int32.Parse(dr["HallNumber"].ToString()));
                        values.Add(Int32.Parse(dr["CinemaID"].ToString()));
                        values.Add(dr["CinemaName"].ToString());
                        values.Add(dr["CinemaAddress"].ToString());
                        values.Add(Int32.Parse(dr["CityID"].ToString()));

                        dataGridView1.Rows.Add(values.ToArray());
                    }
                }
            }
        }
        private void AdmLoadHalls(string condition)
        {
            dataGridView1.Columns.Clear();

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = "Select * from (" +
                    "Select Hall.*, Cinema.Name as CinemaName, Cinema.Address as CinemaAddress from Hall " +
                    "inner join Cinema on Hall.CinemaID = Cinema.ID " +
                    ") as result " +
                    $"{condition}";

                if (condition == "")
                    curQuery = cmdTxt;

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    AdmLoadColsName(dr);

                    for (int i = 0; i < colNames.Count; i++)
                    {
                        dataGridView1.Columns.Add($"{colNames[i]}Column", colNames[i].ToString());
                    }

                    while (dr.Read())
                    {
                        ArrayList values = new ArrayList();

                        values.Add(Int32.Parse(dr["ID"].ToString()));
                        values.Add(Int32.Parse(dr["Number"].ToString()));
                        values.Add(dr["Description"].ToString());
                        values.Add(Int32.Parse(dr["RowsCount"].ToString()));
                        values.Add(Int32.Parse(dr["PlacesInARow"].ToString()));
                        values.Add(Int32.Parse(dr["CinemaID"].ToString()));
                        values.Add(dr["CinemaName"].ToString());
                        values.Add(dr["CinemaAddress"].ToString());

                        dataGridView1.Rows.Add(values.ToArray());
                    }
                }
            }
        }
        private void AdmLoadCinemas(string condition)
        {
            dataGridView1.Columns.Clear();

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = "Select * from (" +
                    "Select Cinema.*, City.Name as CityName, City.Region as CityRegion from Cinema " +
                    "inner join City on Cinema.CityID = City.ID " +
                    ") as result " +
                    $"{condition}";

                if (condition == "")
                    curQuery = cmdTxt;

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    AdmLoadColsName(dr);

                    for (int i = 0; i < colNames.Count; i++)
                    {
                        dataGridView1.Columns.Add($"{colNames[i]}Column", colNames[i].ToString());
                    }

                    while (dr.Read())
                    {
                        ArrayList values = new ArrayList();

                        values.Add(Int32.Parse(dr["ID"].ToString()));
                        values.Add(dr["Name"].ToString());
                        values.Add(dr["Address"].ToString());
                        values.Add(dr["PhoneNumber"].ToString());
                        values.Add(DateTime.Parse(dr["OpeningDate"].ToString()));
                        string closingDate = dr["ClosingDate"].ToString();
                        if (closingDate != "")
                            values.Add(DateTime.Parse(closingDate));
                        else
                            values.Add(null);
                        values.Add(Int32.Parse(dr["CityID"].ToString()));
                        values.Add(dr["CityName"].ToString());
                        values.Add(dr["CityRegion"].ToString());

                        dataGridView1.Rows.Add(values.ToArray());
                    }
                }
            }
        }
        private void AdmLoadCities(string condition)
        {
            dataGridView1.Columns.Clear();

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"Select * from (Select * from City) as result {condition}";

                if (condition == "")
                    curQuery = cmdTxt;

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    AdmLoadColsName(dr);

                    for (int i = 0; i < colNames.Count; i++)
                    {
                        dataGridView1.Columns.Add($"{colNames[i]}Column", colNames[i].ToString());
                    }

                    while (dr.Read())
                    {
                        ArrayList values = new ArrayList();

                        values.Add(Int32.Parse(dr["ID"].ToString()));
                        values.Add(dr["Name"].ToString());
                        values.Add(dr["Region"].ToString());

                        dataGridView1.Rows.Add(values.ToArray());
                    }
                }
            }
        }
        private void AdmLoadRatingSystems(string condition)
        {
            dataGridView1.Columns.Clear();

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"Select * from (Select * from RatingSystem) as result {condition}";

                if (condition == "")
                    curQuery = cmdTxt;

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    AdmLoadColsName(dr);

                    for (int i = 0; i < colNames.Count; i++)
                    {
                        dataGridView1.Columns.Add($"{colNames[i]}Column", colNames[i].ToString());
                    }

                    while (dr.Read())
                    {
                        ArrayList values = new ArrayList();

                        values.Add(Int32.Parse(dr["ID"].ToString()));
                        values.Add(dr["Name"].ToString());

                        dataGridView1.Rows.Add(values.ToArray());
                    }
                }
            }
        }
        private void AdmLoadPlaces(string condition)
        {
            dataGridView1.Columns.Clear();

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = "Select * from (" +
                    "Select Place.*, Session.HallID as HallID, Hall.Number as HallNumber, Cinema.ID as CinemaID, Cinema.Name as CinemaName, Cinema.Address as CinemaAddress, Cinema.CityID as CityID " +
                    "from Place " +
                    "inner join Session on Place.SessionID = Session.ID " +
                    "inner join Hall on Session.HallID = Hall.ID " +
                    "inner join Cinema on Hall.ID = Cinema.ID " +
                    ") as result " +
                    $"{condition}";

                if (condition == "")
                    curQuery = cmdTxt;

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    AdmLoadColsName(dr);

                    for (int i = 0; i < colNames.Count; i++)
                    {
                        dataGridView1.Columns.Add($"{colNames[i]}Column", colNames[i].ToString());
                    }

                    while (dr.Read())
                    {
                        ArrayList values = new ArrayList();

                        values.Add(Int32.Parse(dr["ID"].ToString()));
                        values.Add(Int32.Parse(dr["PlaceNumber"].ToString()));
                        values.Add(Int32.Parse(dr["RowNumber"].ToString()));
                        values.Add(Int32.Parse(dr["SessionID"].ToString()));
                        values.Add(Int32.Parse(dr["HallID"].ToString()));
                        values.Add(Int32.Parse(dr["HallNumber"].ToString()));
                        values.Add(Int32.Parse(dr["CinemaID"].ToString()));
                        values.Add(dr["CinemaName"].ToString());
                        values.Add(dr["CinemaAddress"].ToString());
                        values.Add(Int32.Parse(dr["CityID"].ToString()));

                        dataGridView1.Rows.Add(values.ToArray());
                    }
                }
            }
        }


        private void atrbChekListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Checked) //checked т.к. событие возникает перед тем как изменить статус
            {
                dataGridView1.Columns[e.Index].Visible = false;
            }
            else
            {
                dataGridView1.Columns[e.Index].Visible = true;
            }
        }


        private void atrbComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            atrbComboBox.ForeColor = Color.Black;
            valueComboBox.Enabled = true;            
            valueComboBox.Items.Clear();
            valueComboBox.Text = "";

            if (atrbComboBox.Text == "")
            {
                return;
            }
            
            using (var cnn = new SqlConnection())
            {

                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"select distinct {atrbComboBox.Text} from ( " + curQuery + ") as result";
                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    //ArrayList items = new ArrayList();
                    while (dr.Read())
                    {
                        valueComboBox.Items.Add(dr[atrbComboBox.Text]);

                        ///МУКИ С СОРТИРОВКОЙ ДАТЫ (ВЫШЕ АРРЭЙ ЛИСТ СЮДА ЖЕ, НИЖЕ ПОСЛЕ ВАЙЛ ТОЖЕ СЮДА)

                        //items.Add(dr[atrbComboBox.Text]);
                        //Type p = dr[atrbComboBox.Text].GetType();
                        //if (dr[atrbComboBox.Text].GetType() == typeof(DateTime))
                        //{
                        //    DateTime date = DateTime.Parse(dr[atrbComboBox.Text].ToString());
                        //    valueComboBox.Items.Add(date);                            
                        //}
                        //else

                        ///ЕСЛИ БЫ МОЖНО БЫЛО УСТАНАВЛИВАТЬ ДИАПАЗОН ПО ВРЕМЕНИ

                        //if (dr[atrbComboBox.Text].GetType() == typeof(DateTime))
                        //{
                        //    valueComboBox.Enabled = false;
                        //    dateFromComboBox.Enabled = true;
                        //    dateToComboBox.Enabled = true;
                        //    dateFromComboBox.Items.Add(dr[atrbComboBox.Text]);
                        //    dateToComboBox.Items.Add(dr[atrbComboBox.Text]);
                        //}
                        //else
                        //{
                        //    valueComboBox.Enabled = true;
                        //    valueComboBox.Items.Clear();
                        //    switch (modelComboBox.Text)
                        //    {
                        //        case "Зал":
                        //        case "Город":
                        //        case "Место":
                        //            dateFromComboBox.Enabled = false;
                        //            dateToComboBox.Enabled = false;
                        //            valueComboBox.Items.Add(dr[atrbComboBox.Text]);
                        //            break;

                        //        default:
                        //            valueComboBox.Items.Add(dr[atrbComboBox.Text]);
                        //            dateFromComboBox.Enabled = true;
                        //            dateToComboBox.Enabled = true;
                        //            break;
                        //    }
                            
                        //    valueComboBox.Items.Add(dr[atrbComboBox.Text]);
                        //}
                        
                    }
                    //items[0] = ((DateTime)items[0]).AddHours(2);
                    //string str = items[0].ToString();
                    //items.Sort();
                    //valueComboBox.Items.AddRange(items.ToArray());
                }
            }
        }

        private void atrbComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBox[] children = new ComboBox[1];            
            children[0] = valueComboBox;
            ComboBoxesTxtChanged(atrbComboBox, children);
        }

        private void valueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueComboBox.ForeColor = Color.Black;
            string condition = "";

            if (atrbComboBox.Text != "Price")
                condition = $"where {atrbComboBox.Text} = '{valueComboBox.Text}'";
            else
                condition = $"where {atrbComboBox.Text} = {valueComboBox.Text.Replace(',','.')}";
            AdmLoadAtrbs(condition);
        }
        private void valueComboBox_TextChanged(object sender, EventArgs e)
        {
            ComboBoxesTxtChanged(valueComboBox, new ComboBox[0]);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            switch (modelComboBox.Text)
            {
                case "Фильм":
                    FilmInfo filmInfoForm = new FilmInfo();
                    filmInfoForm.Text = "Добавить фильм";
                    filmInfoForm.titleLabel.Text = "Добавить фильм";
                    filmInfoForm.IDLabel.Text = "ID: Автоматически";
                    filmInfoForm.operation = "Add";
                    form = filmInfoForm;
                    break;

                case "Сеанс":
                    SessionInfo sessionInfoForm = new SessionInfo();
                    sessionInfoForm.Text = "Добавить сеанс";
                    sessionInfoForm.titleLabel.Text = "Добавить сеанс";
                    sessionInfoForm.IDLabel.Text = "ID: Автоматически";
                    sessionInfoForm.operation = "Add";
                    sessionInfoForm.dateTxtBox.Enabled = false;
                    form = sessionInfoForm;
                    break;

                case "Билет":
                    MessageBox.Show("Добавление билетов происходит через основной поиск сеансов.",
                       "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Зал":
                    HallInfo hallInfoForm = new HallInfo();
                    hallInfoForm.Text = "Добавить зал";
                    hallInfoForm.titleLabel.Text = "Добавить зал";
                    hallInfoForm.IDLabel.Text = "ID: Автоматически";                    
                    hallInfoForm.operation = "Add";
                    hallInfoForm.numberTxtBox.Enabled = false;
                    form = hallInfoForm;
                    break;

                case "Кинотеатр":
                    CinemaInfo cinemaInfoForm = new CinemaInfo();
                    cinemaInfoForm.Text = "Добавить кинотеатр";
                    cinemaInfoForm.titleLabel.Text = "Добавить кинотеатр";
                    cinemaInfoForm.IDLabel.Text = "ID: Автоматически";
                    cinemaInfoForm.operation = "Add";
                    form = cinemaInfoForm;
                    break;

                case "Город":
                    CityInfo cityInfoForm = new CityInfo();
                    cityInfoForm.Text = "Добавить город";
                    cityInfoForm.titleLabel.Text = "Добавить город";
                    cityInfoForm.IDLabel.Text = "ID: Автоматически";
                    cityInfoForm.operation = "Add";
                    form = cityInfoForm;
                    break;

                case "Рейтинговая система":
                    RatingSystemInfo ratingSystemInfoForm = new RatingSystemInfo();
                    ratingSystemInfoForm.Text = "Добавить город";
                    ratingSystemInfoForm.titleLabel.Text = "Добавить город";
                    ratingSystemInfoForm.IDLabel.Text = "ID: Автоматически";
                    ratingSystemInfoForm.operation = "Add";
                    form = ratingSystemInfoForm;
                    break;

                case "Место":
                    MessageBox.Show("Нельзя вручную добавить место," +
                        " так как места для сеансов генерируются автоматически на основе имеющихся билетов!", 
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
            form.ShowDialog();
            AdmLoadAtrbs("");                       
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isEmptyCell = false;
            int rowIndex;
            int ID;
            string name;
            string description;
            Form form = new Form();
            switch (modelComboBox.Text)
            {
                case "Фильм":
                    try
                    {
                        rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        ID = Int32.Parse(dataGridView1[0, rowIndex].Value?.ToString());
                        name = dataGridView1[1, rowIndex].Value?.ToString();
                        int length = Int32.Parse(dataGridView1[2, rowIndex].Value?.ToString());
                        string poster = dataGridView1[3, rowIndex].Value?.ToString();
                        description = dataGridView1[4, rowIndex].Value?.ToString();
                        DateTime releaseDate = DateTime.Parse(dataGridView1[5, rowIndex].Value?.ToString());
                        int ratingID = Int32.Parse(dataGridView1[6, rowIndex].Value?.ToString());
                        string ratingName = dataGridView1[7, rowIndex].Value?.ToString();

                        Film editingFilm = new Film(ID, name, length, poster, description, releaseDate, ratingID);
                        FilmInfo filmInfoForm = new FilmInfo();
                        filmInfoForm.editingFilm = editingFilm;
                        filmInfoForm.Text = "Редактировать фильм";
                        filmInfoForm.titleLabel.Text = "Редактировать фильм";
                        filmInfoForm.IDLabel.Text = $"ID: {editingFilm.ID}";
                        filmInfoForm.nameTxtBox.Text = editingFilm.Name;
                        filmInfoForm.lengthTxtBox.Text = editingFilm.Length.ToString();
                        filmInfoForm.posterTxtBox.Text = editingFilm.Poster;
                        filmInfoForm.descriptionTxtBox.Text = editingFilm.Description;
                        filmInfoForm.releaseDateTxtBox.Text = editingFilm.ReleaseDate.ToString();
                        filmInfoForm.ratingComboBox.Text = ratingName;
                        filmInfoForm.operation = "Edit";
                        form = filmInfoForm;
                    }
                    catch (Exception ex)
                    {
                        isEmptyCell = true;
                    }
                                        
                    break;

                case "Сеанс":
                    try
                    {
                        rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        ID = Int32.Parse(dataGridView1[0, rowIndex].Value?.ToString());
                        DateTime date = DateTime.Parse(dataGridView1[1, rowIndex].Value?.ToString());
                        Decimal price = Decimal.Parse(dataGridView1[2, rowIndex].Value?.ToString());
                        string type = dataGridView1[3, rowIndex].Value?.ToString();
                        int filmID = Int32.Parse(dataGridView1[4, rowIndex].Value?.ToString());
                        int hallID = Int32.Parse(dataGridView1[5, rowIndex].Value?.ToString());                        

                        int hallNumber = Int32.Parse(dataGridView1[8, rowIndex].Value?.ToString());

                        Session editingSession = new Session(ID, date, price, type, filmID, hallID);
                        SessionInfo sessionInfoForm = new SessionInfo();

                        sessionInfoForm.operation = "Edit";
                        sessionInfoForm.hallComboBox.Text = $"ID:{hallID}, Зал №{hallNumber}";
                        sessionInfoForm.hallComboBox.Enabled = false;

                        sessionInfoForm.editingSession = editingSession;
                        sessionInfoForm.Text = "Редактировать сеанс";
                        sessionInfoForm.titleLabel.Text = "Редактировать сеанс";
                        sessionInfoForm.IDLabel.Text = $"ID: {editingSession.ID}";

                        sessionInfoForm.dateTxtBox.Text = editingSession.Date.ToString();
                        sessionInfoForm.priceTxtBox.Text = editingSession.Price.ToString();
                        sessionInfoForm.typeTxtBox.Text = editingSession.Type.ToString();                        

                        
                        sessionInfoForm.dateTxtBox.Enabled = true;
                        sessionInfoForm.LoadFilms();
                        form = sessionInfoForm;
                    }
                    catch (Exception ex)
                    {
                        isEmptyCell = true;
                    }
                    break;

                case "Билет":
                    MessageBox.Show("Редактирование билетов происходит через основной поиск сеансов.",
                       "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Зал":
                    try
                    {
                        rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        ID = Int32.Parse(dataGridView1[0, rowIndex].Value?.ToString());
                        int number = Int32.Parse(dataGridView1[1, rowIndex].Value?.ToString());
                        description = dataGridView1[2, rowIndex].Value?.ToString();
                        int rowsCount = Int32.Parse(dataGridView1[3, rowIndex].Value?.ToString());
                        int placesInARow = Int32.Parse(dataGridView1[4, rowIndex].Value?.ToString());
                        int cinemaID = Int32.Parse(dataGridView1[5, rowIndex].Value?.ToString());

                        string cinemaName = dataGridView1[6, rowIndex].Value?.ToString();
                        string cinemaAddress = dataGridView1[7, rowIndex].Value?.ToString();

                        Hall editingHall = new Hall(ID, number, description, rowsCount, placesInARow, cinemaID);
                        HallInfo hallInfoForm = new HallInfo();
                        
                        hallInfoForm.cinemaComboBox.Text = $"ID:{cinemaID}, {cinemaName} ({cinemaAddress})";
                        hallInfoForm.cinemaComboBox.Enabled = false;

                        hallInfoForm.editingHall = editingHall;
                        hallInfoForm.Text = "Редактировать зал";
                        hallInfoForm.titleLabel.Text = "Редактировать зал";
                        hallInfoForm.IDLabel.Text = $"ID: {editingHall.ID}";
                        hallInfoForm.numberTxtBox.Text = editingHall.Number.ToString();
                        hallInfoForm.descriptionTxtBox.Text = editingHall.Description;
                        hallInfoForm.rowsCountTxtBox.Text = editingHall.RowsCount.ToString();
                        hallInfoForm.placesInARowTxtBox.Text = editingHall.PlacesInARow.ToString();

                        hallInfoForm.operation = "Edit";
                        form = hallInfoForm;
                    }
                    catch (Exception ex)
                    {
                        isEmptyCell = true;
                    }
                    break;

                case "Кинотеатр":
                    try
                    {
                        rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        ID = Int32.Parse(dataGridView1[0, rowIndex].Value?.ToString());
                        name = dataGridView1[1, rowIndex].Value?.ToString();
                        string address = dataGridView1[2, rowIndex].Value?.ToString();
                        string phone = dataGridView1[3, rowIndex].Value?.ToString();
                        DateTime openingDate = DateTime.Parse(dataGridView1[4, rowIndex].Value?.ToString());
                        
                        int cityID = Int32.Parse(dataGridView1[6, rowIndex].Value?.ToString());
                        string cityName = dataGridView1[7, rowIndex].Value?.ToString();
                        string regionName = dataGridView1[8, rowIndex].Value?.ToString();

                        Cinema editingCinema = new Cinema();
                        CinemaInfo cinemaInfoForm = new CinemaInfo();
                        cinemaInfoForm.cDateTxtBox.Enabled = true;
                        try
                        {
                            DateTime closingDate = DateTime.Parse(dataGridView1[5, rowIndex].Value?.ToString());
                            editingCinema = new Cinema(ID, name, address, phone, openingDate, closingDate, cityID);
                            cinemaInfoForm.cDateTxtBox.Text = editingCinema.ClosingDate.ToString();
                        }
                        catch(Exception ex)
                        {
                            editingCinema = new Cinema(ID, name, address, phone, openingDate, cityID);
                            
                        }
                        
                        cinemaInfoForm.editingCinema = editingCinema;
                        cinemaInfoForm.Text = "Редактировать кинотеатр";
                        cinemaInfoForm.titleLabel.Text = "Редактировать кинотеатр";
                        cinemaInfoForm.IDLabel.Text = $"ID: {editingCinema.ID}";
                        cinemaInfoForm.nameTxtBox.Text = editingCinema.Name;
                        cinemaInfoForm.addressTxtBox.Text = editingCinema.Address;
                        cinemaInfoForm.phoneTxtBox.Text = editingCinema.Phone;
                        cinemaInfoForm.oDateTxtBox.Text = editingCinema.OpeningDate.ToString();                                                
                        cinemaInfoForm.cityComboBox.Text = $"{cityName}({regionName})";

                        cinemaInfoForm.operation = "Edit";
                        form = cinemaInfoForm;
                    }
                    catch(Exception ex)
                    {
                        isEmptyCell = true;
                    }
                    break;

                case "Город":
                    try
                    {
                        rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        ID = Int32.Parse(dataGridView1[0, rowIndex].Value?.ToString());
                        name = dataGridView1[1, rowIndex].Value?.ToString();
                        string region = dataGridView1[2, rowIndex].Value?.ToString();

                        City editingCity = new City(ID, name, region);
                        CityInfo cityInfoForm = new CityInfo();
                        cityInfoForm.editingCity = editingCity;
                        cityInfoForm.Text = "Редактировать город";
                        cityInfoForm.titleLabel.Text = "Редактировать город";
                        cityInfoForm.IDLabel.Text = $"ID: {editingCity.ID}";
                        cityInfoForm.nameTxtBox.Text = editingCity.Name;
                        cityInfoForm.regionTxtBox.Text = editingCity.Region;

                        cityInfoForm.operation = "Edit";
                        form = cityInfoForm;
                    }
                    catch (Exception ex)
                    {
                        isEmptyCell = true;
                    }
                    break;

                case "Рейтинговая система":
                    try
                    {
                        rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        ID = Int32.Parse(dataGridView1[0, rowIndex].Value?.ToString());
                        name = dataGridView1[1, rowIndex].Value?.ToString();

                        RatingSystem editingRatingSystem = new RatingSystem(ID, name);
                        RatingSystemInfo ratingSystemInfoForm = new RatingSystemInfo();
                        ratingSystemInfoForm.editingRatingSystem = editingRatingSystem;
                        ratingSystemInfoForm.Text = "Редактировать рейтнговую систему";
                        ratingSystemInfoForm.titleLabel.Text = "Редактировать рейтнговую систему";
                        ratingSystemInfoForm.IDLabel.Text = $"ID: {editingRatingSystem.ID}";
                        ratingSystemInfoForm.nameTxtBox.Text = editingRatingSystem.Name;

                        ratingSystemInfoForm.operation = "Edit";
                        form = ratingSystemInfoForm;
                    }
                    catch (Exception ex)
                    {
                        isEmptyCell = true;
                    }
                    break;

                case "Место":
                    MessageBox.Show("Нельзя вручную редактировать место, так как места для сеансов генерируются автоматически на основе имеющихся билетов!",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
            if (!isEmptyCell)
            {
                form.ShowDialog();
                AdmLoadAtrbs("");
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            string table = "";
            int ID;
            switch (modelComboBox.Text)
            {
                case "Фильм":
                    table = "Film";
                    break;

                case "Сеанс":
                    table = "Session";
                    break;

                case "Билет":
                    table = "Ticket";
                    break;

                case "Зал":
                    table = "Hall";
                    break;

                case "Кинотеатр":
                    table = "Cinema";
                    break;

                case "Город":
                    table = "City";
                    break;

                case "Рейтинговая система":
                    table = "RatingSystem";
                    break;

                case "Место":
                    MessageBox.Show("Нельзя вручную удалить место, так как места для сеансов генерируются автоматически на основе имеющихся билетов!" +
                        "Для удаления места удалить соответствующий билет!",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }

            try
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                ID = Int32.Parse(dataGridView1[0, rowIndex].Value?.ToString());

                string warning = $"Вы уверены, что хотите удалить запись с данным ключом (ID = {ID}) из таблицы {table}?" +
                    $"\nОбратите внимание, что данные удалятся каскадно " +
                    $"(все связанные \"дочерние\" элементы из других таблиц тоже будут удалены) ";

                if (MessageBox.Show($"{warning}", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;

                using (var cnn = new SqlConnection())
                {

                    cnn.ConnectionString = ConnectionString;
                    cnn.Open();

                    string cmdTxt = $"DELETE from {table} where ID = {ID} ";
                    var cmd = new SqlCommand(cmdTxt, cnn);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show($"Запись с ключом \"ID = {ID}\" удалена из таблицы {table}",
                    "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                AdmLoadAtrbs("");                
            }
            catch (Exception ex)
            {                
                
            }
        }
        private void ticketActionBtn_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            try
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int ID = Int32.Parse(dataGridView1[0, rowIndex].Value?.ToString());
                DateTime date = new DateTime();
                decimal price = 0;
                string type = "";
                int filmID = -1;
                int hallID = -1;

                using (var cnn = new SqlConnection())
                {
                    cnn.ConnectionString = ConnectionString;
                    cnn.Open();

                    string cmdTxt = $"Select * from Session where Session.ID = {ID}";

                    var cmd = new SqlCommand(cmdTxt, cnn);

                    using (var dr = cmd.ExecuteReader())
                    {                        
                        while (dr.Read())
                        {
                            date = DateTime.Parse(dr["Date"].ToString());
                            price = Decimal.Parse(dr["Price"].ToString());
                            type = dr["Type"].ToString();
                            filmID = Int32.Parse(dr["FilmID"].ToString());
                            hallID = Int32.Parse(dr["HallID"].ToString());
                        }
                    }
                }
                HallScheme hallSchemeForm = new HallScheme();
                hallSchemeForm.session = new Session(ID, date, price, type, filmID, hallID);
                hallSchemeForm.LoadScheme();
                form = hallSchemeForm;
            }
            catch (Exception ex)
            {

            }
            form.ShowDialog();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (loginTxtBox.Text == login && passwordTxtBox.Text == password)
                ChangeUser("admin");
            else
                MessageBox.Show("Неправильный логин или пароль!",
                    "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void ChangeUser(string user)
        {
            if (user == "admin")
            {
                admSrchPanel.Enabled = true;
                enterBtn.Enabled = false;
                exitBtn.Enabled = true;
                loginTxtBox.Enabled = false;
                passwordTxtBox.Enabled = false;
                userLabel.Text = "Пользователь: администратор";
            }
            else
            {
                admSrchPanel.Enabled = false;
                enterBtn.Enabled = true;
                exitBtn.Enabled = false;
                loginTxtBox.Enabled = true;
                passwordTxtBox.Enabled = true;
                loginTxtBox.Text = "";
                passwordTxtBox.Text = "";
                userLabel.Text = "Пользователь: кассир";

                if (ticketActionBtn.Enabled == false)
                    dataGridView1.Columns.Clear();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            ChangeUser("cashier");
        }        
    }
}
