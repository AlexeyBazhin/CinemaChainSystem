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
    public partial class HallInfo : Form
    {
        public HallInfo()
        {
            InitializeComponent();
            LoadCinemas();
        }
        private const string ConnectionString =
            @"Data Source=ALEXCLANKPC;Initial Catalog=CinemaChainSystem;Integrated Security=True;";

        public string operation = "";
        public Hall editingHall = new Hall();

        private void LoadCinemas()
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"Select * from Cinema";

                var cmd = new SqlCommand(cmdTxt, cnn);

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
                        int cityID = Int32.Parse(dr["CityID"].ToString());
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

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!CheckFill(numberTxtBox.Text, "номер зала"))
                return;
            if (!CheckFill(rowsCountTxtBox.Text, "количество рядов"))
                return;
            if (!CheckFill(placesInARowTxtBox.Text, "количество мест в ряду"))
                return;

            if (operation == "Add")
            {
                if (!CheckFill(cinemaComboBox.Text, "кинотеатр"))
                    return;
                AddInDB();
                numberTxtBox.Enabled = false;
                MessageBox.Show($"Зал №{numberTxtBox.Text} ({cinemaLabel.Text}) добавлен", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (EditInDB())
                {
                    MessageBox.Show($"Зал отредактрован.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }

            numberTxtBox.Text = "";
            descriptionTxtBox.Text = "";
            rowsCountTxtBox.Text = "";
            placesInARowTxtBox.Text = "";
        }

        private void AddInDB()
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string description = "NULL";
                if (descriptionTxtBox.Text != "")
                    description = $"'{descriptionTxtBox.Text}'";
                                
                string cmdTxt = $"INSERT INTO Hall (Number, Description, RowsCount, PlacesInARow, CinemaID) " +
                    $"VALUES ('{numberTxtBox.Text}', {description}, '{rowsCountTxtBox.Text}', '{placesInARowTxtBox.Text}', " +
                    $"{((Cinema)cinemaComboBox.SelectedItem).ID})";

                var cmd = new SqlCommand(cmdTxt, cnn);

                cmd.ExecuteNonQuery();
            }
        }
        private bool EditInDB()
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                

                string cmdTxt = $"SELECT COUNT(*) as Count FROM Session WHERE Session.HallID = {editingHall.ID}";
                var cmd = new SqlCommand(cmdTxt, cnn);
                int count = 0;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        count = (Int32.Parse(dr["Count"].ToString()));
                    }
                }

                if (count == 0 || 
                    (Int32.Parse(rowsCountTxtBox.Text) == editingHall.RowsCount &&
                    Int32.Parse(placesInARowTxtBox.Text) == editingHall.PlacesInARow))
                {
                    string description = "";
                    if (descriptionTxtBox.Text != "")
                        description = $"{descriptionTxtBox.Text}";

                    cmdTxt = $"UPDATE Hall set Number = {numberTxtBox.Text},  Description = '{description}', " +
                        $"RowsCount = {rowsCountTxtBox.Text}, PlacesInARow = {placesInARowTxtBox.Text} " +
                        $"where ID = {editingHall.ID}";
                    cmd = new SqlCommand(cmdTxt, cnn);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    MessageBox.Show($"Нельзя редактировать размеры зала, пока в этом зале проводятся сеансы!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                } 
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
        private void numberTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (numberTxtBox.Text == "")
                return;

            try
            {
                Int32.Parse(numberTxtBox.Text);
            }
            catch(Exception ex)
            {
                
                MessageBox.Show($"Слишком большое число!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numberTxtBox.Text = numberTxtBox.Text.Remove(numberTxtBox.Text.Length - 1);
            }
        }
        private void numberTxtBox_Leave(object sender, EventArgs e)
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                int cinemaID = 0;
                if (operation == "Add")
                    cinemaID = ((Cinema)cinemaComboBox.SelectedItem).ID;
                else
                    cinemaID = editingHall.CinemaID;
                string cmdTxt = $"Select Number from Hall where CinemaID = {cinemaID}";
                var cmd = new SqlCommand(cmdTxt, cnn);

                List<string> numbers = new List<string>();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        numbers.Add(dr["Number"].ToString());
                    }
                }
                if (numbers.Contains(numberTxtBox.Text))
                {
                    MessageBox.Show($"Зал с таким номером уже есть в данном кинотеатре!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    numberTxtBox.Text = "";
                }
            }
        }

        private void countsTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (rowsCountTxtBox.Text == "" || placesInARowTxtBox.Text == "")
                return;

            TextBox txtBox = (TextBox)sender;
            if (Int32.Parse(txtBox.Text) == 0)
            {
                txtBox.Text = "";
                return;
            }

            if (Int32.Parse(txtBox.Text) > 400)
            {
                MessageBox.Show($"Мест в зале не может быть больше 400!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBox.Text = "";
                return;
            }

            if (Int32.Parse(rowsCountTxtBox.Text) * Int32.Parse(placesInARowTxtBox.Text) > 400)
            {
                MessageBox.Show($"Мест в зале не может быть больше 400!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBox.Text = "";
            }
        }

        private void cinemaComboBox_TextChanged(object sender, EventArgs e)
        {
            if (cinemaComboBox.SelectedItem == null)
            {
                cinemaComboBox.Text = "";
                numberTxtBox.Text = "";
                numberTxtBox.Enabled = false;
            }

        }

        private void cinemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cinemaComboBox.SelectedItem != null)
            {
                numberTxtBox.Enabled = true;
                numberTxtBox.Text = "";
            }
        }
    }
}
