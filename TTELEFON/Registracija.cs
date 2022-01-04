using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TTELEFON
{
    public partial class Registracija : Form
    {
       
        public Registracija()
        {
            InitializeComponent();
        }

        readonly string connectionString = @"Data Source=DESKTOP-ADKNJHA;Initial Catalog=TELEFON;Integrated Security=True";

        private SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }

        //Unose se podaci u dva tekstualna polja i zatim se proveravaju ti podaci da li se nalaze u bazi. Ukoliko se nalaze u bazi podataka prikazace se sledeci insert prozor 
        private void Registracija_btn_Click(object sender, EventArgs e)
        {
            string ime_prezime, sifra;

            SqlConnection connection = getConnection();

            try
            {
                string querry = ("SELECT * from radnik where ime_prezime = '" + ime_radnika_box.Text.Trim() + "' and  sifra = '" + sifra_radnika_box.Text.Trim()+"'");
                SqlDataAdapter sda = new SqlDataAdapter(querry,connection);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    ime_prezime = ime_radnika_box.Text;
                    sifra = sifra_radnika_box.Text;

                    Insert_model im = new Insert_model();
                    im.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ime_radnika_box.Clear();
                    sifra_radnika_box.Clear();

                    ime_radnika_box.Focus();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }



        }
        //Ukoliko neko zeli na lak nacin izbrisati podatke koje su uneli klknuce dugme clear
        private void butto_clear_Click(object sender, EventArgs e)
        {
            ime_radnika_box.Clear();
            sifra_radnika_box.Clear();
        }
    }
}
