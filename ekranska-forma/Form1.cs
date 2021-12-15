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

        struct SqlRow
        {
            public int id;
            public string naziv;
            public int trajanje;
            public int maxUcenika;
            public string prijemniIspit;

            public SqlRow(int id, string naziv, int trajanje, int maxUcenika, string prijemniIspit)
            {
                this.id = id;
                this.naziv = naziv;
                this.trajanje = trajanje;
                this.maxUcenika = maxUcenika;
                this.prijemniIspit = prijemniIspit;
            }
        }

        SqlConnection connection;

        List<SqlRow> data = new List<SqlRow>();
        int currentDataIdx = 0;

        private void ReadAllData()
        {

            string query = "select id, naziv, trajanje, maxUcenika, prijemniIspit from Smer order by id asc;";

            SqlCommand cmd = new SqlCommand(query, connection);

            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            data.Clear();

            while (reader.Read())
            {
                data.Add(new SqlRow((int)reader[0], (string)reader[1], (int)reader[2], (int)reader[3], (string)reader[4]));
            }

            connection.Close();
        }

        private void AddData(SqlRow row)
        {
            string query = $"insert into Smer(naziv, trajanje, maxUcenika, prijemniIspit) values('{row.naziv}', {row.trajanje}, {row.maxUcenika}, '{row.prijemniIspit}');";

            SqlCommand cmd = new SqlCommand(query, connection);

            if (connection.State != ConnectionState.Open)
                connection.Open();

            cmd.ExecuteNonQuery();

            ReadAllData();
            DisplayData();

            connection.Close();
        }

        private void UpdateData(SqlRow row)
        {
            string query = $"update Smer set naziv = '{row.naziv}', trajanje = {row.trajanje}, maxUcenika = {row.maxUcenika}, prijemniIspit =  '{row.prijemniIspit}' where id = {row.id};";

            SqlCommand cmd = new SqlCommand(query, connection);

            if (connection.State != ConnectionState.Open)
                connection.Open();

            cmd.ExecuteNonQuery();

            ReadAllData();
            DisplayData();

            connection.Close();
        }

        private void DeleteData(int id)
        {
            string query = $"delete from Smer where id = {id};";

            SqlCommand cmd = new SqlCommand(query, connection);

            if (connection.State != ConnectionState.Open)
                connection.Open();

            cmd.ExecuteNonQuery();

            currentDataIdx = Math.Max(currentDataIdx - 1, 0);

            ReadAllData();
            DisplayData();

            connection.Close();
        }

        private void DisplayData()
        {
            if (data.Count == 0)
            {
                nameTb.Text = "";
                trajanjeTb.Text = "";
                maxUcenikaTb.Text = "";
                prijemniIspitTb.Text = "";
            }

            var currentData = data[currentDataIdx];

            nameTb.Text = currentData.naziv;
            trajanjeTb.Text = currentData.trajanje.ToString();
            maxUcenikaTb.Text = currentData.maxUcenika.ToString();
            prijemniIspitTb.Text = currentData.prijemniIspit;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const string connectionString = @"Data Source=DESKTOP-DVS4TKU;Initial Catalog=EkranskaForma;Integrated security=SSPI";

            connection = new SqlConnection(connectionString);

            ReadAllData();

            DisplayData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void gotoStartButton_Click(object sender, EventArgs e)
        {
            currentDataIdx = 0;
            DisplayData();
        }

        private void gotoPrevButton_Click(object sender, EventArgs e)
        {
            currentDataIdx = Math.Max(currentDataIdx - 1, 0);
            DisplayData();
        }

        private void gotoNextButton_Click(object sender, EventArgs e)
        {
            currentDataIdx = Math.Min(currentDataIdx + 1, data.Count - 1);
            DisplayData();
        }

        private void gotoEndButton_Click(object sender, EventArgs e)
        {
            currentDataIdx = data.Count - 1;
            DisplayData();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            var currentData = new SqlRow();

            if (nameTb.Text.Length == 0 || prijemniIspitTb.Text.Length == 0)
            {
                MessageBox.Show("Sva polja moraju biti popunjena");
                return;
            }

            currentData.naziv = nameTb.Text;
            try
            {
                currentData.trajanje = int.Parse(trajanjeTb.Text);
                currentData.maxUcenika = int.Parse(maxUcenikaTb.Text);
            } catch (Exception exc)
            {
                MessageBox.Show("Trajanje i Max Ucenika moraju biti validni brojevi");
                return;
            }
            currentData.prijemniIspit = prijemniIspitTb.Text;

            AddData(currentData);
        }

        private void izmeniButton_Click(object sender, EventArgs e)
        {
            if (data.Count == 0)
            {
                MessageBox.Show("Ne postoje podaci koji se mogu izmeniti");
                return;
            }

            var currentData = new SqlRow();

            if (nameTb.Text.Length == 0 || prijemniIspitTb.Text.Length == 0)
            {
                MessageBox.Show("Sva polja moraju biti popunjena");
                return;
            }

            currentData.naziv = nameTb.Text;
            try
            {
                currentData.trajanje = int.Parse(trajanjeTb.Text);
                currentData.maxUcenika = int.Parse(maxUcenikaTb.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Trajanje i Max Ucenika moraju biti validni brojevi");
                return;
            }
            currentData.prijemniIspit = prijemniIspitTb.Text;

            currentData.id = data[currentDataIdx].id;

            UpdateData(currentData);
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            if (data.Count == 0)
            {
                MessageBox.Show("Ne postoje podaci koji se mogu obrisati");
                return;
            }

            DeleteData(data[currentDataIdx].id);

        }
    }
}
