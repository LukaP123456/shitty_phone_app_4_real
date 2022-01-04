
namespace TTELEFON
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Proizvodjac = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.kucaRadio = new System.Windows.Forms.RadioButton();
            this.prodavnicaRadio = new System.Windows.Forms.RadioButton();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.Label();
            this.prezimeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drzavaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gradBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adresaBox = new System.Windows.Forms.TextBox();
            this.postanskiBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.buttonPorurdzbina = new System.Windows.Forms.Button();
            this.prodavnicaCombo = new System.Windows.Forms.ComboBox();
            this.kodBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.podaciTextBox = new System.Windows.Forms.TextBox();
            this.pronadji = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.KarticaRadio = new System.Windows.Forms.RadioButton();
            this.GotovinaRadio = new System.Windows.Forms.RadioButton();
            this.Registracija_btn = new System.Windows.Forms.Button();
            this.kod_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox_placanje = new System.Windows.Forms.GroupBox();
            this.groupBox_placanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(129, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.AutoSize = true;
            this.Proizvodjac.Location = new System.Drawing.Point(44, 43);
            this.Proizvodjac.Name = "Proizvodjac";
            this.Proizvodjac.Size = new System.Drawing.Size(68, 15);
            this.Proizvodjac.TabIndex = 2;
            this.Proizvodjac.Text = "Proizvodjac";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(44, 90);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(41, 15);
            this.Model.TabIndex = 3;
            this.Model.Text = "Model";
            // 
            // kucaRadio
            // 
            this.kucaRadio.AutoSize = true;
            this.kucaRadio.Location = new System.Drawing.Point(44, 152);
            this.kucaRadio.Name = "kucaRadio";
            this.kucaRadio.Size = new System.Drawing.Size(157, 19);
            this.kucaRadio.TabIndex = 6;
            this.kucaRadio.TabStop = true;
            this.kucaRadio.Text = "Dostava na kucnu adresu";
            this.kucaRadio.UseVisualStyleBackColor = true;
            this.kucaRadio.CheckedChanged += new System.EventHandler(this.kucaRadio_CheckedChanged);
            // 
            // prodavnicaRadio
            // 
            this.prodavnicaRadio.AutoSize = true;
            this.prodavnicaRadio.Location = new System.Drawing.Point(226, 152);
            this.prodavnicaRadio.Name = "prodavnicaRadio";
            this.prodavnicaRadio.Size = new System.Drawing.Size(159, 19);
            this.prodavnicaRadio.TabIndex = 7;
            this.prodavnicaRadio.TabStop = true;
            this.prodavnicaRadio.Text = "Preuzimanje u prodavnici";
            this.prodavnicaRadio.UseVisualStyleBackColor = true;
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(101, 208);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(100, 23);
            this.imeBox.TabIndex = 8;
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(12, 211);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(27, 15);
            this.Ime.TabIndex = 9;
            this.Ime.Text = "Ime";
            // 
            // prezimeBox
            // 
            this.prezimeBox.Location = new System.Drawing.Point(101, 238);
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(100, 23);
            this.prezimeBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Drzava";
            // 
            // drzavaBox
            // 
            this.drzavaBox.Location = new System.Drawing.Point(101, 267);
            this.drzavaBox.Name = "drzavaBox";
            this.drzavaBox.Size = new System.Drawing.Size(100, 23);
            this.drzavaBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Grad";
            // 
            // gradBox
            // 
            this.gradBox.Location = new System.Drawing.Point(101, 296);
            this.gradBox.Name = "gradBox";
            this.gradBox.Size = new System.Drawing.Size(100, 23);
            this.gradBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adresa";
            // 
            // adresaBox
            // 
            this.adresaBox.Location = new System.Drawing.Point(101, 325);
            this.adresaBox.Name = "adresaBox";
            this.adresaBox.Size = new System.Drawing.Size(100, 23);
            this.adresaBox.TabIndex = 17;
            // 
            // postanskiBox
            // 
            this.postanskiBox.Location = new System.Drawing.Point(101, 354);
            this.postanskiBox.Name = "postanskiBox";
            this.postanskiBox.Size = new System.Drawing.Size(100, 23);
            this.postanskiBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Postanski broj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "E-mail";
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(101, 390);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(100, 23);
            this.mailBox.TabIndex = 21;
            // 
            // buttonPorurdzbina
            // 
            this.buttonPorurdzbina.Location = new System.Drawing.Point(10, 415);
            this.buttonPorurdzbina.Name = "buttonPorurdzbina";
            this.buttonPorurdzbina.Size = new System.Drawing.Size(75, 23);
            this.buttonPorurdzbina.TabIndex = 22;
            this.buttonPorurdzbina.Text = "Submit";
            this.buttonPorurdzbina.UseVisualStyleBackColor = true;
            this.buttonPorurdzbina.Click += new System.EventHandler(this.buttonPorurdzbina_Click);
            // 
            // prodavnicaCombo
            // 
            this.prodavnicaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prodavnicaCombo.FormattingEnabled = true;
            this.prodavnicaCombo.Location = new System.Drawing.Point(226, 208);
            this.prodavnicaCombo.Name = "prodavnicaCombo";
            this.prodavnicaCombo.Size = new System.Drawing.Size(198, 23);
            this.prodavnicaCombo.TabIndex = 23;
            // 
            // kodBox
            // 
            this.kodBox.Location = new System.Drawing.Point(442, 211);
            this.kodBox.Name = "kodBox";
            this.kodBox.Size = new System.Drawing.Size(196, 23);
            this.kodBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Unesite kod za popust";
            // 
            // podaciTextBox
            // 
            this.podaciTextBox.Location = new System.Drawing.Point(343, 12);
            this.podaciTextBox.Multiline = true;
            this.podaciTextBox.Name = "podaciTextBox";
            this.podaciTextBox.ReadOnly = true;
            this.podaciTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.podaciTextBox.Size = new System.Drawing.Size(445, 134);
            this.podaciTextBox.TabIndex = 30;
            // 
            // pronadji
            // 
            this.pronadji.Location = new System.Drawing.Point(226, 389);
            this.pronadji.Name = "pronadji";
            this.pronadji.Size = new System.Drawing.Size(124, 23);
            this.pronadji.TabIndex = 31;
            this.pronadji.Text = "Pronadji preko mejla";
            this.pronadji.UseVisualStyleBackColor = true;
            this.pronadji.Click += new System.EventHandler(this.pronadji_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 32;
            // 
            // KarticaRadio
            // 
            this.KarticaRadio.AutoSize = true;
            this.KarticaRadio.Location = new System.Drawing.Point(14, 63);
            this.KarticaRadio.Name = "KarticaRadio";
            this.KarticaRadio.Size = new System.Drawing.Size(61, 19);
            this.KarticaRadio.TabIndex = 29;
            this.KarticaRadio.TabStop = true;
            this.KarticaRadio.Text = "Kartica";
            this.KarticaRadio.UseVisualStyleBackColor = true;
            // 
            // GotovinaRadio
            // 
            this.GotovinaRadio.AutoSize = true;
            this.GotovinaRadio.Location = new System.Drawing.Point(14, 38);
            this.GotovinaRadio.Name = "GotovinaRadio";
            this.GotovinaRadio.Size = new System.Drawing.Size(73, 19);
            this.GotovinaRadio.TabIndex = 27;
            this.GotovinaRadio.TabStop = true;
            this.GotovinaRadio.Text = "Gotovina";
            this.GotovinaRadio.UseVisualStyleBackColor = true;
            // 
            // Registracija_btn
            // 
            this.Registracija_btn.Location = new System.Drawing.Point(649, 411);
            this.Registracija_btn.Name = "Registracija_btn";
            this.Registracija_btn.Size = new System.Drawing.Size(123, 23);
            this.Registracija_btn.TabIndex = 33;
            this.Registracija_btn.Text = "Prijava admina";
            this.Registracija_btn.UseVisualStyleBackColor = true;
            this.Registracija_btn.Click += new System.EventHandler(this.Registracija_btn_Click);
            // 
            // kod_checkBox
            // 
            this.kod_checkBox.AutoSize = true;
            this.kod_checkBox.Location = new System.Drawing.Point(442, 151);
            this.kod_checkBox.Name = "kod_checkBox";
            this.kod_checkBox.Size = new System.Drawing.Size(197, 19);
            this.kod_checkBox.TabIndex = 34;
            this.kod_checkBox.Text = "Kliknite ako imate kod za popust";
            this.kod_checkBox.UseVisualStyleBackColor = true;
            this.kod_checkBox.CheckedChanged += new System.EventHandler(this.kod_checkBox_CheckedChanged);
            // 
            // groupBox_placanje
            // 
            this.groupBox_placanje.Controls.Add(this.GotovinaRadio);
            this.groupBox_placanje.Controls.Add(this.KarticaRadio);
            this.groupBox_placanje.Location = new System.Drawing.Point(442, 267);
            this.groupBox_placanje.Name = "groupBox_placanje";
            this.groupBox_placanje.Size = new System.Drawing.Size(200, 100);
            this.groupBox_placanje.TabIndex = 35;
            this.groupBox_placanje.TabStop = false;
            this.groupBox_placanje.Text = "Odaberite nacin placanja";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_placanje);
            this.Controls.Add(this.kod_checkBox);
            this.Controls.Add(this.Registracija_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pronadji);
            this.Controls.Add(this.podaciTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kodBox);
            this.Controls.Add(this.prodavnicaCombo);
            this.Controls.Add(this.buttonPorurdzbina);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.postanskiBox);
            this.Controls.Add(this.adresaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gradBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drzavaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prezimeBox);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.imeBox);
            this.Controls.Add(this.prodavnicaRadio);
            this.Controls.Add(this.kucaRadio);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Proizvodjac);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Prodaja telefona";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_placanje.ResumeLayout(false);
            this.groupBox_placanje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label Proizvodjac;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.RadioButton kucaRadio;
        private System.Windows.Forms.RadioButton prodavnicaRadio;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox prezimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox drzavaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gradBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adresaBox;
        private System.Windows.Forms.TextBox postanskiBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Button buttonPorurdzbina;
        private System.Windows.Forms.ComboBox prodavnicaCombo;
        private System.Windows.Forms.TextBox kodBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox podaciTextBox;
        private System.Windows.Forms.Button pronadji;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton KarticaRadio;
        private System.Windows.Forms.RadioButton GotovinaRadio;
        private System.Windows.Forms.Button Registracija_btn;
        private System.Windows.Forms.CheckBox kod_checkBox;
        private System.Windows.Forms.GroupBox groupBox_placanje;
    }
}

