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
    public partial class CityInfo : Form
    {
        public CityInfo()
        {
            InitializeComponent();
        }
        private const string ConnectionString =
            @"Data Source=ALEXCLANKPC;Initial Catalog=CinemaChainSystem;Integrated Security=True;";

        public string operation = "";
        public City editingCity = new City();

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!CheckFill(nameTxtBox.Text, "название города"))
                return;
            if (!CheckFill(regionTxtBox.Text, "название региона"))
                return;


            if (operation == "Add")
            {
                AddInDB();
                MessageBox.Show($"Город \"{nameTxtBox.Text}\" ({regionTxtBox.Text}) добавлен", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                EditInDB();
                MessageBox.Show($"Город отредактрован.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            nameTxtBox.Text = "";
            regionTxtBox.Text = "";
        }
        private void AddInDB()
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"INSERT INTO City (Name, Region) " +
                    $"VALUES ('{nameTxtBox.Text}', '{regionTxtBox.Text}')";

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

                string cmdTxt = $"UPDATE City set Name = '{nameTxtBox.Text}', Region = '{regionTxtBox.Text}'" +
                    $"where ID = {editingCity.ID}";

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

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text != "")
                return;

            string firstChar = txtBox.Text.Substring(0, 1);
            firstChar = firstChar.ToUpper();
            if (txtBox.Text.Length != 1)
                txtBox.Text = firstChar + txtBox.Text.Substring(1, txtBox.Text.Length - 1);
            else
                txtBox.Text = firstChar;

            if (txtBox.SelectionStart == 0)
                ++txtBox.SelectionStart;
            
        }

        private void charsKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(ch >= 1040 && ch <= 1105) && ch != 8 && ch != 32)
            {
                e.Handled = true;
            }
        }
    }
}
