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
    public partial class FilmInfo : Form
    {
        public FilmInfo()
        {
            InitializeComponent();
            LoadRatings();            
        }

        private const string ConnectionString =
            @"Data Source=ALEXCLANKPC;Initial Catalog=CinemaChainSystem;Integrated Security=True;";

        public string operation = "";
        public Film editingFilm = new Film();
        private void LoadRatings()
        {            
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"Select * from RatingSystem";

                var cmd = new SqlCommand(cmdTxt, cnn);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        RatingSystem ratingSystem = new RatingSystem(Int32.Parse(dr["ID"].ToString()) ,dr["Name"].ToString());
                        ratingComboBox.Items.Add(ratingSystem);
                    }
                }
            }
        }
        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!CheckFill(nameTxtBox.Text, "название фильма"))
                return;
            if (!CheckFill(lengthTxtBox.Text, "длительность фильма"))
                return;
            if (!CheckFill(releaseDateTxtBox.Text, "премьеру фильма"))
                return;
            if (!CheckFill(ratingComboBox.Text, "возрастное ограничение фильма"))
                return;

            if (operation == "Add")
            {
                AddInDB();
                MessageBox.Show($"Фильм \"{nameTxtBox.Text}\" ({releaseDateTxtBox.Text}) добавлен", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                EditInDB();
                MessageBox.Show($"Фильм отредактрован.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            nameTxtBox.Text = "";
            lengthTxtBox.Text = "";
            posterTxtBox.Text = "";
            descriptionTxtBox.Text = "";
            releaseDateTxtBox.Text = "";
            ratingComboBox.Text = "";
        }
        private void AddInDB()
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"INSERT INTO Film (Name, Length, Poster, Description, ReleaseDate, RatingID) " +
                    $"VALUES ('{nameTxtBox.Text}', '{lengthTxtBox.Text}', '{posterTxtBox.Text}', " +
                    $"'{descriptionTxtBox.Text}', '{releaseDateTxtBox.Text}', '{((RatingSystem)ratingComboBox.SelectedItem).ID}')";

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

                string cmdTxt = $"UPDATE Film set Name = '{nameTxtBox.Text}', Length = '{lengthTxtBox.Text}', Poster = '{posterTxtBox.Text}', " +
                    $"Description = '{descriptionTxtBox.Text}', ReleaseDate = '{releaseDateTxtBox.Text}', " +
                    $"RatingID = '{((RatingSystem)ratingComboBox.SelectedItem).ID}' " +
                    $"where ID = {editingFilm.ID}";

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

        private void releaseDateTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (releaseDateTxtBox.Text.Length == 2 || releaseDateTxtBox.Text.Length == 5)
            {
                releaseDateTxtBox.Text += ".";
                releaseDateTxtBox.SelectionStart = releaseDateTxtBox.Text.Length;
                return;
            }

            if (releaseDateTxtBox.Text.Length > 10)
                releaseDateTxtBox.Text = releaseDateTxtBox.Text.Remove(10);
            releaseDateTxtBox.SelectionStart = releaseDateTxtBox.Text.Length;
        }

        private void releaseDateTxtBox_Leave(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            bool isCorrectDate = DateTime.TryParse(releaseDateTxtBox.Text, out date);
            if ( !(isCorrectDate && date >= DateTime.Parse("25.01.1896") && date <= DateTime.Now.AddYears(1)) )
            { 
                MessageBox.Show("Введите корректную дату!\nДата премьеры не может быть раньше 25.01.1986 и позже чем через год.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                releaseDateTxtBox.Text = "";
            }
        }

        private void lengthTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (lengthTxtBox.Text != "" && Int32.Parse(lengthTxtBox.Text) > 600)
                MessageBox.Show("Фильм не может длиться дольше 10 часов! Введите корректную длительность фильма.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void lengthTxtBox_Leave(object sender, EventArgs e)
        {
            if (Int32.Parse(lengthTxtBox.Text) > 600)
                lengthTxtBox.Text = "";
        }

        private void ratingComboBox_TextChanged(object sender, EventArgs e)
        {
            if (ratingComboBox.SelectedItem == null)
                ratingComboBox.Text = "";
        }
    }
}
