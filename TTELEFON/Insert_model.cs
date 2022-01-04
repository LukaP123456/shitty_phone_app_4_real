using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TTELEFON
{
    public partial class Insert_model : Form 
    {
        private SqlDataReader reader;

        public Insert_model()
        {
            InitializeComponent();
        }

        readonly string connectionString = @"Data Source=DESKTOP-ADKNJHA;Initial Catalog=TELEFON;Integrated Security=True";

        private SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }
        //Prikazace nam samo formu za insertovanje ukoliko smo uneli odgovarajuce podatke
        private void Insert_model_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = getConnection();
                connection.Open();
                SqlCommand sc = new SqlCommand("select proizvodjac_ime, proizvodjacID from proizvodjac", connection);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("proizvodjac_ime ", typeof(string));
                dt.Columns.Add("proizvodjacID ", typeof(int));

                dt.Load(reader);
                comboBox_proizvodjac.ValueMember = "proizvodjacID";
                comboBox_proizvodjac.DisplayMember = "proizvodjac_ime";
                comboBox_proizvodjac.DataSource = dt;
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Exception: " + err.Message);
            }
        }



        //Klikom da dugme jedan unose se podaci u tabelu model i zatim se taj isti model moze izabrati za kupovinu u Form1 delu programa
        private void button1_Click(object sender, EventArgs e)
        {
            var connection = getConnection();
            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO model " +
                "(model_naziv,cena,memorija,CPU,prednja_kamera,zadnja_kamera,dijagonala_ekrana,RAM_memorija,interna_memorija,kapacitet_baterije,rezolucija,proizvodjac_ID)  values "
                + "(@model_naziv,@cena,@memorija,@CPU,@prednja_kamera,@zadnja_kamera,@dijagonala_ekrana,@RAM_memorija,@interna_memorija,@kapacitet_baterije,@rezolucija,@proizvodjac_ID)"


            };

            var proizvodjacID = (int)comboBox_proizvodjac.SelectedValue;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@model_naziv", naziv_mod_txtBox.Text);
            command.Parameters.AddWithValue("@cena", cena_txtBox.Text);
            command.Parameters.AddWithValue("@memorija", memorija_txtBox.Text);
            command.Parameters.AddWithValue("@CPU", CPU_txtBox.Text);
            command.Parameters.AddWithValue("@prednja_kamera", prednja_kamera_txtBox.Text);
            command.Parameters.AddWithValue("@zadnja_kamera", zadnja_kamera_txtBox.Text);
            command.Parameters.AddWithValue("@dijagonala_ekrana", dijagonala_txtBox.Text);
            command.Parameters.AddWithValue("@RAM_memorija", RAM_txtBox.Text);
            command.Parameters.AddWithValue("@interna_memorija", interna_txtBox.Text);
            command.Parameters.AddWithValue("@kapacitet_baterije", kapacitet_txtBox.Text);
            command.Parameters.AddWithValue("@rezolucija", rezolucija_txtBox.Text);
            command.Parameters.AddWithValue("@proizvodjac_ID", proizvodjacID);



           

            connection.Open();

            int result = command.ExecuteNonQuery();
            
            

            if (result > 0)
            {
                MessageBox.Show("Uspesno ste uneli novi proizvod");
            }
            else
            {
                MessageBox.Show("Doslo je do greske niste uneli proizvod");
            }

            //Brisu se uneti podaci iz tekstualnih polja na kraju izvrsavanja programa
            proizvodjac_drzava_txtBox.Clear();

            connection.Close();
            naziv_mod_txtBox.Clear();
            cena_txtBox.Clear();
            memorija_txtBox.Clear();
            CPU_txtBox.Clear();
            prednja_kamera_txtBox.Clear();
            zadnja_kamera_txtBox.Clear();
            dijagonala_txtBox.Clear();
            RAM_txtBox.Clear();
            interna_txtBox.Clear();
            kapacitet_txtBox.Clear();
            rezolucija_txtBox.Clear();


        }

       
    }

}