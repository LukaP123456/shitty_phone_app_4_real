using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TTELEFON
{
    public partial class Form1 : Form
    {
        //Uspostavljamo konekciju sa bazom i programom 
        readonly string connectionString = @"Data Source=DESKTOP-ADKNJHA;Initial Catalog=TELEFON;Integrated Security=True";

        private SqlDataReader reader;

        Registracija rg = new Registracija();

        public Form1()
        {
            InitializeComponent();
        }
        //Metoda koju cemo pozivati svaki put kad nam treba otvorena konekcija sa bazom 
        private SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            kodBox.Enabled = false;
            
            //Ovaj deo ispod stavlja adresu prodavnice u prodavnica.Combo
            try
            {
                SqlConnection connection = getConnection();
                connection.Open();
                SqlCommand sc = new SqlCommand("select prodavnicaID, drzava + ',' + grad + ',' + ulica as \"toDisplay\" from prodavnica ", connection);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("prodavnicaID ", typeof(int));
                dt.Columns.Add("toDisplay ", typeof(string));

                dt.Load(reader);
                prodavnicaCombo.ValueMember = "prodavnicaID";
                prodavnicaCombo.DisplayMember = "toDisplay"; 

                prodavnicaCombo.DataSource = dt;
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Exception: " + err.ToString());
            }

            //Ovaj deo ispod uzima i stavlja podatke u comboBox1 tj stavlja naziv proizvodjaca telefona u comboBox
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
                comboBox1.ValueMember = "proizvodjacID";
                comboBox1.DisplayMember = "proizvodjac_ime";
                comboBox1.DataSource = dt;
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Exception: " + err.Message);
            }

        }

        //Menja ime modela u comboBox2 na osnovu ime proizvodjaca u comboBox1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var proizvodjacId = (int)comboBox1.SelectedValue;

            string query = "select model_naziv from model where proizvodjac_ID= " + proizvodjacId;

            try
            {
                var connection = getConnection();
                connection.Open();
                SqlCommand sc = new SqlCommand(query, connection);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("model_naziv ", typeof(string));

                dt.Load(reader);
                comboBox2.ValueMember = "model_naziv";
                comboBox2.DisplayMember = "model_naziv";
                comboBox2.DataSource = dt;
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Exception: " + err.Message);
            }
        }
        //Menja mogucnost pristupa tekstualnim poljima ukoliko je kucaRadio checkovan pristup combo boxu prodavnice nece biti moguc i obrnuto 
        private void kucaRadio_CheckedChanged(object sender, EventArgs e)
        {
            drzavaBox.Enabled = false;
            gradBox.Enabled = false;
            adresaBox.Enabled = false;
            postanskiBox.Enabled = false;
            prodavnicaCombo.Enabled = true;

            if (prodavnicaRadio.Checked == true)
            {
                drzavaBox.Enabled = false;
                gradBox.Enabled = false;
                adresaBox.Enabled = false;
                postanskiBox.Enabled = false;
                prodavnicaCombo.Enabled = true;

            }
            else if (kucaRadio.Checked == true)
            {
                prodavnicaCombo.Enabled = false;
                drzavaBox.Enabled = true;
                gradBox.Enabled = true;
                adresaBox.Enabled = true;
                postanskiBox.Enabled = true;
            }
            
           
        }
        //Omogucava pristup tekstualnom polju za unos koda i sprecava unos koda ukoliko nije cekirano check box
        private void kod_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (kod_checkBox.Checked == true)
            {
                kodBox.Enabled = true;
            }
            else if (kod_checkBox.Checked == false)
            {
                kodBox.Enabled = false;
            }
           
        }

      
        //Dugme koje aktivira veliki deo programa. Aktivacijom dugmeta pravi se porudzbina i unose se svi relevantni podaci u sve odgovarajuce tabele
        private void buttonPorurdzbina_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                //PROMOKOD UZIMA IZ BAZE AKO JE VALIDAN TJ NALAZI SE U BAZI
                SqlConnection promo_kod_konekcija = getConnection();
               
              
                string promoKodQuery = ("SELECT promo_kodID from promo_kod where kod = @promo_kodID and datum_isteka_koda > getdate()");
                SqlCommand promoKodCommand = new SqlCommand(promoKodQuery, promo_kod_konekcija);

                promoKodCommand.Parameters.AddWithValue("@promo_kodID", kodBox.Text);

                int? promoKodID = null;

                promo_kod_konekcija.Open();

                SqlDataReader reader = promoKodCommand.ExecuteReader();
                //Ukoliko je reader nesto procitao odnosno promoKodQuery je pronasao podatak koji odgovara kveriju reader ce procitati i izvrsiti zadatu komandu
                if (reader.HasRows)
                {
                    reader.Read();

                    promoKodID = reader.GetInt32("promo_kodID");
                }
                //Zatvaramo konekciju
                promo_kod_konekcija.Close();
                

                //TIP PLACANJA
                //Dodeljuje vrednost varijabli tipPlacanja koja ce se kasnije prikazati u Message boxu za narudzbinu
                //U zavisnosti koji tip placanja kupac zeli dodelice se taj ID varijabli tipPlacanja
                int tipPlacanja = 0;

                if (GotovinaRadio.Checked)
                {
                    tipPlacanja = 1003;
                }
                else if (KarticaRadio.Checked)
                {
                    tipPlacanja = 1002;
                }


                //OVAJ DEO INSERTUJE KUPCA
                //Insertuje sve podatke koje kupac upise u program i unese ih u bazu
                var connection = getConnection();
                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "INSERT INTO kupac " +
                    "(ime, prezime,Email) output INSERTED.kupacID VALUES " +
                    "(@ime, @prezime,@mail)"
                };
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ime", imeBox.Text);
                command.Parameters.AddWithValue("@prezime", prezimeBox.Text);
                command.Parameters.AddWithValue("@mail", mailBox.Text);

                connection.Open();

                int kupacID = (int)command.ExecuteScalar();

                //Isto kao i za kupca samo sto sacuva podatke o adresi kupca i unese ih u adresa tabelu
                command.CommandText = "INSERT INTO adresa " +
                   "(drzava,grad,ulica,zip,kupacID) output INSERTED.adresaID VALUES " +
                   "(@drzava,@grad,@ulica,@zip,@kupacID)";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@drzava", drzavaBox.Text);
                command.Parameters.AddWithValue("@grad", gradBox.Text);
                command.Parameters.AddWithValue("@ulica", adresaBox.Text);
                command.Parameters.AddWithValue("@zip", postanskiBox.Text);
                command.Parameters.AddWithValue("@kupacID", kupacID);

                int result = command.ExecuteNonQuery();

                int adresaID = (int)command.ExecuteScalar();


                //Metoda isprazni() ce isprazniti sva tekstualna polja nakon izvrsenja komande.
                isprazni();


                //**********************************************************************
                //OVAJ DEO INSERTUJE PORUDZBINU U TABELU PORUDZBINA

                var porudzbina_command = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "INSERT INTO porudzbina " +
                    "(kupac_id, tip_placanjaID,promo_kodID,datum_narucivanja) output INSERTED.porudzbinaID VALUES " +
                    "(@kupacID,@tip_placanjaID, @promo_kodID,getdate())"
                };
                porudzbina_command.Parameters.Clear();


                porudzbina_command.Parameters.AddWithValue("@kupacID", kupacID);
                porudzbina_command.Parameters.AddWithValue("@tip_placanjaID", tipPlacanja);
                //Proverava da li je promoKodId jedank sa null ukoliko jeste dobice vrednost null sto znaci da kupac nije iskoristio promo kod 
                if (promoKodID != null)
                {
                    porudzbina_command.Parameters.AddWithValue("@promo_kodID", promoKodID);
                }
                else
                {
                    porudzbina_command.Parameters.AddWithValue("@promo_kodID", DBNull.Value);
                }

                int porudzbinaID = (int)porudzbina_command.ExecuteScalar();






                //PORUDZBINA_PRODAVNICA
                //Insertuje u pordzbina_prodavnica ako je chekovan kucaRadio
                //U zavisnosti od toga da li je kuppac odabrao dostavu na kucnu adresu ili dostavu u prodavnici dva razlicita kverija ce se izvrsiti
                if (kucaRadio.Checked)
                {
                    porudzbina_command.CommandText = "INSERT INTO porudzbina_adresa " +
                  "(adresaID,porudzbinaID,vreme_isporuke)  VALUES " +
                  "(@adresaID,@porudzbinaID,getdate()+20 )";

                    porudzbina_command.Parameters.Clear();


                    porudzbina_command.Parameters.AddWithValue("@adresaID", adresaID);
                    porudzbina_command.Parameters.AddWithValue("@porudzbinaID", porudzbinaID);


                    int porudzbina_result = porudzbina_command.ExecuteNonQuery();



                }
                //PORUDZBINA_PRODAVNICA
                //Insertuje u pordzbina_adresa ako je chekovan prodavnicaRadio
                else if (prodavnicaRadio.Checked)
                {
                    porudzbina_command.CommandText = "INSERT INTO porudzbina_prodavnica " +
                 "(datum_stizanja_proizvoda,prodavnicaID,porudzbinaID) VALUES " +
                 "(getdate()+20,@prodavnicaID,@porudzbinaID )";

                    porudzbina_command.Parameters.Clear();
                    //ovde parametri

                    int prodavnicaID = (int)prodavnicaCombo.SelectedValue;

                    porudzbina_command.Parameters.AddWithValue("@porudzbinaID", porudzbinaID);
                    porudzbina_command.Parameters.AddWithValue("@prodavnicaID", prodavnicaID);


                    int porudzbina_result = porudzbina_command.ExecuteNonQuery();


                }



                //STAVKA
                var stavka_command = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "INSERT INTO stavka " +
                    "(br_komada,proizvodjacID,model_naziv,porudzbinaID)   VALUES " +
                    "(1, @proizvodjacID,@model_naziv,@porudzbinaID)"
                };
                stavka_command.Parameters.Clear();
               
                var proizvodjacID = comboBox1.SelectedValue;

                stavka_command.Parameters.AddWithValue("@proizvodjacID", proizvodjacID);
                stavka_command.Parameters.AddWithValue("@porudzbinaID", porudzbinaID);
                stavka_command.Parameters.AddWithValue("@model_naziv", comboBox2.Text);

                int stavka_result = stavka_command.ExecuteNonQuery();


                connection.Close();
                if (result > 0)
                {
                    MessageBox.Show("Uspesno ste narucili proizvod");
                    //Ponovo u zavisnosti od toga da li kupac zeli dostavu na kucnu adresu ili u prodavnici razlicito vreme ce mu iskociti na kraju u vidu MessageBoxa
                    if (kucaRadio.Checked)
                    {
                        SqlConnection poruka_konekcija = getConnection();

                       
                        string poruka_kveri = ("SELECT vreme_isporuke from porudzbina_adresa");
                        SqlCommand poruka_command = new SqlCommand(poruka_kveri, poruka_konekcija);

                        poruka_konekcija.Open();
                        SqlDataReader poruka_reader = poruka_command.ExecuteReader();


                        if (poruka_reader.HasRows)
                        {
                            poruka_reader.Read();
                            var vreme_isporuke = poruka_reader.GetDateTime("vreme_isporuke").ToString();

                            MessageBox.Show(string.Format("Vreme stizanja vase porudzbine {0}", vreme_isporuke));


                        }

                        poruka_konekcija.Close();
                       
                    }
                    else if (prodavnicaRadio.Checked)
                    {
                        SqlConnection poruka_konekcija = getConnection();


                        string poruka_kveri = ("SELECT datum_stizanja_proizvoda from porudzbina_prodavnica");
                        SqlCommand poruka_command = new SqlCommand(poruka_kveri, poruka_konekcija);

                        poruka_konekcija.Open();
                        SqlDataReader poruka_reader = poruka_command.ExecuteReader();



                        if (poruka_reader.HasRows)
                        {
                            poruka_reader.Read();
                            var vreme_isporuke = poruka_reader.GetDateTime("datum_stizanja_proizvoda ").ToString();

                            MessageBox.Show(string.Format("Vreme stizanja vase porudzbine {0}", vreme_isporuke));

                        }

                        poruka_konekcija.Close();
                    }
                }
                //Poruka koja ce iskociti ako nesto nije ispunjeno na odgovarajuci nacin
                else
                {
                    MessageBox.Show("Doslo je do greske niste narucili proizvod");
                }

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        //Svaki put kada kupac izabere drugi model u text boxu ce se ispisati svi podaci o tom modelu i na osnovu tih podataka kupac moze odluciti sta zeli kupiti
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connection = getConnection();
            var proizvodjacId = (int)comboBox1.SelectedValue;
            var model_naziv = comboBox2.SelectedValue;

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "SELECT * from model where proizvodjac_ID = " + proizvodjacId + "and model_naziv = '" + model_naziv + "'"
            };

            try
            {

                connection.Open();
                int result = command.ExecuteNonQuery();
                reader = command.ExecuteReader(CommandBehavior.SingleRow);


                if (reader.Read())
                {
                    string naziv = (string)reader["model_naziv"].ToString();
                    string cena = (string)reader["cena"].ToString();
                    string CPU = (string)reader["CPU"].ToString();
                    string pkamera = (string)reader["prednja_kamera"].ToString();
                    string zkamera = (string)reader["zadnja_kamera"].ToString();
                    string dekrana = (string)reader["dijagonala_ekrana"].ToString();
                    string rmemorija = (string)reader["RAM_memorija"].ToString();
                    string imemorija = (string)reader["interna_memorija"].ToString();
                    string baterija = (string)reader["kapacitet_baterije"].ToString();

                    podaciTextBox.Text = "Ime modela: " + naziv + " \r\nCena: " + cena + "\r\nCPU: " + CPU + "\r\nPrednja kamera: " + pkamera + "\r\nZadnja kamera: " + zkamera + "\r\nDijagonala ekrana: " + dekrana
                        + "\r\nRAM memorija: " + rmemorija + " \r\nInterna memorija: " + imemorija + "\r\nBaterija: " + baterija;


                }
                else
                {
                    MessageBox.Show("Nema zeljenog modela");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            
        }


        //Klikom na dugme pronadji ispisace se svi podaci o musteriji ukoliko je ta musterija narucila nesto preko aplikacije koristeci isti mejl
        private void pronadji_Click(object sender, EventArgs e)
        {
            var connection = getConnection();
            try
            {

                var command = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM kupac WHERE Email = @Email"
                };

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Email", mailBox.Text);

                var customerID = 0;
                var success = false;


                connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {

                    success = true;
                    imeBox.Text = reader["ime"].ToString();
                    prezimeBox.Text = reader["prezime"].ToString();
                    customerID = Convert.ToInt32(reader["kupacID"].ToString());
                }
                reader.Close(); 
                if (success)
                {
                    command.Parameters.Clear();
                    command.CommandText = "SELECT * FROM adresa WHERE kupacID = @kupacID";
                    command.Parameters.AddWithValue("@kupacID", customerID);
                    reader = command.ExecuteReader();                                       

                    success = false;
                    if (reader.Read())
                    {
                        success = true;
                        drzavaBox.Text = reader["grad"].ToString();
                        gradBox.Text = reader["drzava"].ToString(); //savetovao bi ti da koristis reader.getString Int Double sta god ovde funkciju i 
                        // punis sa indexom po redu koji ti ocitao
                        adresaBox.Text = reader["ulica"].ToString(); 
                        postanskiBox.Text = reader["zip"].ToString();
                    }
                    if (success)
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show(" address select Error");
                    }
                }
                else
                {
                    MessageBox.Show("E-mail entered doesn't exist");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

        }
        //Telo metode isprazni kojom se brisu svi uneti podaci
        private void isprazni()
        {
            imeBox.Clear();
            prezimeBox.Clear();
            mailBox.Clear();
            drzavaBox.Clear();
            adresaBox.Clear();
            postanskiBox.Clear();
            gradBox.Clear();
        }
        //Klikom na dugme Prijava admina prikazace se prozor namenjen radniku ili adminu koji ima mogucnost unosa novih modela u prodavnicu
        private void Registracija_btn_Click(object sender, EventArgs e)
        {
            rg.Show();
        }

       
    }
}