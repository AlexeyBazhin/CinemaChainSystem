using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaChainSystem
{
    public partial class CinemaInfo : Form
    {
        public CinemaInfo()
        {
            InitializeComponent();
            LoadCities();
        }
        private const string ConnectionString =
            @"Data Source=ALEXCLANKPC;Initial Catalog=CinemaChainSystem;Integrated Security=True;";

        public string operation = "";
        public Cinema editingCinema = new Cinema();
        private void LoadCities()
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"Select * from City";

                var cmd = new SqlCommand(cmdTxt, cnn);

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
        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!CheckFill(nameTxtBox.Text, "название кинотеатра"))
                return;
            if (!CheckFill(phoneTxtBox.Text, "телефонный номер кинотеатра"))
                return;
            if (!CheckFill(addressTxtBox.Text, "адрес кинотеатра"))
                return;
            if (!CheckFill(oDateTxtBox.Text, "дату открытия кинотеатра"))
                return;
            if (!CheckFill(cityComboBox.Text, "город, в котором расположен кинотеатр"))
                return;

            if (operation == "Add")
            {
                AddInDB();
                MessageBox.Show($"Кинотеатр \"{nameTxtBox.Text}\" ({cityComboBox.Text}) добавлен", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                EditInDB();
                MessageBox.Show($"Кинотеатр отредактрован.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            nameTxtBox.Text = "";
            phoneTxtBox.Text = "";
            addressTxtBox.Text = "";
            oDateTxtBox.Text = "";
            cDateTxtBox.Text = "";
            cityComboBox.Text = "";
        }
        private void AddInDB()
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cDate = "NULL";
                if (cDateTxtBox.Text != "")
                    cDate = $"'{cDateTxtBox.Text}'";

                string cmdTxt = $"INSERT INTO Cinema (Name, Address, PhoneNumber, OpeningDate, ClosingDate, CityID) " +
                    $"VALUES ('{nameTxtBox.Text}', '{addressTxtBox.Text}', '{phoneTxtBox.Text}', " +
                    $"'{oDateTxtBox.Text}', {cDate}, '{((City)cityComboBox.SelectedItem).ID}')";

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
                string cDate = "NULL";
                if (cDateTxtBox.Text != "")
                    cDate = $"'{cDateTxtBox.Text}'";
                
                string cmdTxt = $"UPDATE Cinema set Name = '{nameTxtBox.Text}', Address = '{addressTxtBox.Text}', PhoneNumber = '{phoneTxtBox.Text}', " +
                    $"OpeningDate = '{oDateTxtBox.Text}', ClosingDate = {cDate}, " +
                    $"CityID = '{((City)cityComboBox.SelectedItem).ID}' " +
                    $"where ID = {editingCinema.ID}";

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


        private void InputOnlyDigs(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void DateTxtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox dateTxtBox = (TextBox)sender;
            if (dateTxtBox.Text.Length == 2 || dateTxtBox.Text.Length == 5)
            {
                dateTxtBox.Text += ".";
                dateTxtBox.SelectionStart = dateTxtBox.Text.Length;
                return;
            }

            if (dateTxtBox.Text.Length > 10)
                dateTxtBox.Text = dateTxtBox.Text.Remove(10);
            dateTxtBox.SelectionStart = dateTxtBox.Text.Length;
        }

        private void oDateTxtBox_Leave(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            bool isCorrectDate = DateTime.TryParse(oDateTxtBox.Text, out date);
            if (!(isCorrectDate && date >= DateTime.Parse("01.01.2000") && date <= DateTime.Now.AddMonths(3)))
            {
                MessageBox.Show("Введите корректную дату!\nДата открытия не должна быть раньше 01.01.2000 и позже чем через три месяца.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                oDateTxtBox.Text = "";
                cDateTxtBox.Enabled = false;
            }
            else
                cDateTxtBox.Enabled = true;
        }
        private void cDateTxtBox_Leave(object sender, EventArgs e)
        {
            DateTime maxSessDate = new DateTime();

            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"Select MAX(Session.Date) as Max from Cinema " +
                    $"inner join Hall on Cinema.ID = Hall.CinemaID " +
                    $"inner join Session on Hall.ID = Session.HallID " +
                    $"where Cinema.ID = {editingCinema.ID}";

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        try
                        {
                            maxSessDate = DateTime.Parse(dr["Max"].ToString());
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }
            DateTime date = new DateTime();
            bool isCorrectDate = DateTime.TryParse(cDateTxtBox.Text, out date);
            if (cDateTxtBox.Text != "")
            {
                if (!(isCorrectDate && date > DateTime.Parse(oDateTxtBox.Text) &&
                    date <= DateTime.Now.AddMonths(3) && date > maxSessDate))
                {
                    MessageBox.Show("Введите корректную дату!\n" +
                        "Дата открытия НЕ должна быть:\n Раньше 01.01.2000\n Позже чем через три месяца\n Быть раньше даты последнего имеющегося сеанса",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cDateTxtBox.Text = "";
                }
            }
        }
        private void phoneTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxtBox.Text.Length > 11)
                phoneTxtBox.Text = phoneTxtBox.Text.Remove(11);
            phoneTxtBox.SelectionStart = phoneTxtBox.Text.Length;
        }
        private void phoneTxtBox_Leave(object sender, EventArgs e)
        {
            //Regex regex = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");
            //Regex regex1 = new Regex(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$");
            //regex.
            //if (lengthTxtBox.Text != "" && Int32.Parse(lengthTxtBox.Text) > 600)
            //    MessageBox.Show("Фильм не может длиться дольше 10 часов! Введите корректную длительность фильма.",
            //        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void addressTxtBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void cityComboBox_TextChanged(object sender, EventArgs e)
        {
            if (cityComboBox.SelectedItem == null)
                cityComboBox.Text = "";
        }

        private void oDateTxtBox_Enter(object sender, EventArgs e)
        {
            oDateTxtBox.Text = "";
        }

        private void cDateTxtBox_Enter(object sender, EventArgs e)
        {
            cDateTxtBox.Text = "";
        }
    }
}
