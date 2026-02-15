using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<sportTevekenyseg> lista = new List<sportTevekenyseg>();

            string connectionString = ConfigurationManager
                                    .ConnectionStrings["SportDB"]
                                    .ConnectionString;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Sportag, Datum, IdotartamPerc, Helyszin FROM sporttevekenyseg";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sportTevekenyseg s = new sportTevekenyseg()
                        {
                            Sportag = reader.GetString("Sportag"),
                            Datum = reader.GetDateTime("Datum"),
                            IdotartamPerc = reader.GetInt32("IdotartamPerc"),
                            Helyszin = reader.GetString("Helyszin")
                        };

                        lista.Add(s);
                    }
                }

                string filePath = txtPath.Text;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Sportag,Datum,IdotartamPerc,Helyszin"); // fejléc

                for (int i = 0; i < lista.Count; i++)
                {
                    sb.AppendLine($"{lista[i].Sportag},{lista[i].Datum},{lista[i].IdotartamPerc},{lista[i].Helyszin}");
                }

                File.WriteAllText(filePath, sb.ToString());

                MessageBox.Show("Sikeres exportálás!");

            }
        }  


        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            List<sportTevekenyseg> lista = new List<sportTevekenyseg>();

            string filePathImport = txtFileImport.Text;

            string[] lines = File.ReadAllLines(filePathImport);
            foreach (string line in lines) 
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4)
                {
                    sportTevekenyseg s = new sportTevekenyseg()
                    {
                        Sportag = parts[0],
                        Datum = DateTime.Parse(parts[1]),
                        IdotartamPerc = int.Parse(parts[2]),
                        Helyszin = parts[3]
                    };
                    lista.Add(s);
                }
            }


            string connStr = ConfigurationManager
                                .ConnectionStrings["SportDB"]
                                .ConnectionString;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"INSERT INTO sporttevekenyseg
                        (Sportag, Datum, IdotartamPerc, Helyszin)
                        VALUES (@sportag, @datum, @idotartam, @helyszin)";

                
                    int i = 0;
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@sportag", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@datum", MySqlDbType.DateTime);
                    cmd.Parameters.Add("@idotartam", MySqlDbType.Int32);
                    cmd.Parameters.Add("@helyszin", MySqlDbType.VarChar);

                    conn.Open();
                    foreach (var item in lista)
                    {
                        cmd.Parameters["@sportag"].Value = item.Sportag;
                        cmd.Parameters["@datum"].Value = item.Datum;
                        cmd.Parameters["@idotartam"].Value = item.IdotartamPerc;
                        cmd.Parameters["@helyszin"].Value = item.Helyszin;
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Sikeres mentés!");

        }

        private void txtPathImport_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

