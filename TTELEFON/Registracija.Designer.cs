
namespace TTELEFON
{
    partial class Registracija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ime_radnika_box = new System.Windows.Forms.TextBox();
            this.Registracija_btn = new System.Windows.Forms.Button();
            this.sifra_radnika_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butto_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime ";
            // 
            // ime_radnika_box
            // 
            this.ime_radnika_box.Location = new System.Drawing.Point(116, 34);
            this.ime_radnika_box.Name = "ime_radnika_box";
            this.ime_radnika_box.Size = new System.Drawing.Size(202, 23);
            this.ime_radnika_box.TabIndex = 1;
            // 
            // Registracija_btn
            // 
            this.Registracija_btn.Location = new System.Drawing.Point(116, 136);
            this.Registracija_btn.Name = "Registracija_btn";
            this.Registracija_btn.Size = new System.Drawing.Size(75, 23);
            this.Registracija_btn.TabIndex = 2;
            this.Registracija_btn.Text = "Submit";
            this.Registracija_btn.UseVisualStyleBackColor = true;
            this.Registracija_btn.Click += new System.EventHandler(this.Registracija_btn_Click);
            // 
            // sifra_radnika_box
            // 
            this.sifra_radnika_box.Location = new System.Drawing.Point(116, 73);
            this.sifra_radnika_box.Name = "sifra_radnika_box";
            this.sifra_radnika_box.Size = new System.Drawing.Size(202, 23);
            this.sifra_radnika_box.TabIndex = 6;
            this.sifra_radnika_box.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Šifra ";
            // 
            // butto_clear
            // 
            this.butto_clear.Location = new System.Drawing.Point(228, 136);
            this.butto_clear.Name = "butto_clear";
            this.butto_clear.Size = new System.Drawing.Size(75, 23);
            this.butto_clear.TabIndex = 7;
            this.butto_clear.Text = "clear";
            this.butto_clear.UseVisualStyleBackColor = true;
            this.butto_clear.Click += new System.EventHandler(this.butto_clear_Click);
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 254);
            this.Controls.Add(this.butto_clear);
            this.Controls.Add(this.sifra_radnika_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Registracija_btn);
            this.Controls.Add(this.ime_radnika_box);
            this.Controls.Add(this.label1);
            this.Name = "Registracija";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ime_radnika_box;
        private System.Windows.Forms.Button Registracija_btn;
        private System.Windows.Forms.TextBox sifra_radnika_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butto_clear;
    }
}