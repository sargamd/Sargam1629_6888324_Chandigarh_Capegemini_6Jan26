using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
namespace WinFormsApp_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-HP1513\\SQLEXPRESS01;Initial Catalog=SargamDemodb;TrustServerCertificate=True;Integrated Security=True";

            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
            }


        }
    }
}
