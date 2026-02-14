using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            string sportag = txtSportag.Text;
            DateTime datum = dtpDatum.Value;
            int idotartam = (int)nudIdotartam.Value;
            string helyszin = txtHelyszin.Text;

            if (string.IsNullOrWhiteSpace(sportag) ||
                string.IsNullOrWhiteSpace(helyszin))
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

            string connStr = ConfigurationManager
                                .ConnectionStrings["SportDB"]
                                .ConnectionString;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"INSERT INTO sporttevekenyseg
                        (Sportag, Datum, IdotartamPerc, Helyszin)
                        VALUES (@sportag, @datum, @idotartam, @helyszin)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sportag", sportag);
                    cmd.Parameters.AddWithValue("@datum", datum);
                    cmd.Parameters.AddWithValue("@idotartam", idotartam);
                    cmd.Parameters.AddWithValue("@helyszin", helyszin);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Sikeres mentés!");

            txtSportag.Clear();
            txtHelyszin.Clear();
            nudIdotartam.Value = 0;
        }

    }
}

