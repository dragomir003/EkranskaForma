using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ekranska_forma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const string connectionString = @"Data Source=DESKTOP-DVS4TKU;Initial Catalog=EkranskaForma;Integrated security=SSPI";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            MessageBox.Show(connection.State == ConnectionState.Open ? "Connected" : "Not connected");

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
