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
    public partial class RatingSystemInfo : Form
    {
        public RatingSystemInfo()
        {
            InitializeComponent();
        }
        private const string ConnectionString =
            @"Data Source=ALEXCLANKPC;Initial Catalog=CinemaChainSystem;Integrated Security=True;";
        public string operation = "";
        public RatingSystem editingRatingSystem = new RatingSystem();

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (!CheckFill(nameTxtBox.Text, "название рейтинговой системы"))
                return;


            if (operation == "Add")
            {
                AddInDB();
                MessageBox.Show($"Рейтинговая система \"{nameTxtBox.Text}\" добавлена", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                EditInDB();
                MessageBox.Show($"Рейтинговая система отредактрована.", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

            nameTxtBox.Text = "";
        }
        private void AddInDB()
        {
            using (var cnn = new SqlConnection())
            {
                cnn.ConnectionString = ConnectionString;
                cnn.Open();

                string cmdTxt = $"INSERT INTO RatingSystem (Name) " +
                    $"VALUES ('{nameTxtBox.Text}')";

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

                string cmdTxt = $"UPDATE RatingSystem set Name = '{nameTxtBox.Text}'" +
                    $"where ID = {editingRatingSystem.ID}";

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
    }
}
