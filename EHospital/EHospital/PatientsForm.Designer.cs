using System.ComponentModel;

namespace EHospital
{
    partial class PatientsForm
    {
        override
      protected void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.timeChack = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.reportReview = new System.Windows.Forms.Button();
            this.findDoctor = new System.Windows.Forms.Button();
            this.dateChack = new System.Windows.Forms.DateTimePicker();
            this.izaberi = new System.Windows.Forms.Label();
            this.datumPregleda = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.choseDoctor = new System.Windows.Forms.ComboBox();
            this.choseDepartment = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.Label();
            this.jmbg = new System.Windows.Forms.Label();
            this.godina = new System.Windows.Forms.Label();
            this.pol = new System.Windows.Forms.Label();
            this.krvna = new System.Windows.Forms.Label();
            this.mesto = new System.Windows.Forms.Label();
            this.drzavljanstvo = new System.Windows.Forms.Label();
            this.nacionalnost = new System.Windows.Forms.Label();
            this.datum_vazenja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EHospital.Properties.Resources.pacientsCard;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.datum_vazenja);
            this.panel1.Controls.Add(this.nacionalnost);
            this.panel1.Controls.Add(this.drzavljanstvo);
            this.panel1.Controls.Add(this.mesto);
            this.panel1.Controls.Add(this.krvna);
            this.panel1.Controls.Add(this.pol);
            this.panel1.Controls.Add(this.godina);
            this.panel1.Controls.Add(this.jmbg);
            this.panel1.Controls.Add(this.prezime);
            this.panel1.Controls.Add(this.ime);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 427);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Datum važenja zdravstvene knjižice:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nacionalnost:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mesto rođenja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Drževljanstvo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(197, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Zdravstveni karton:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Krvna grupa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Godina rođenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "JMBG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(175, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.timeChack);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.reportReview);
            this.panel2.Controls.Add(this.findDoctor);
            this.panel2.Controls.Add(this.dateChack);
            this.panel2.Controls.Add(this.izaberi);
            this.panel2.Controls.Add(this.datumPregleda);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.choseDoctor);
            this.panel2.Controls.Add(this.choseDepartment);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(445, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 427);
            this.panel2.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(78, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "h";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Izabrati vreme:";
            // 
            // timeChack
            // 
            this.timeChack.FormattingEnabled = true;
            this.timeChack.Location = new System.Drawing.Point(27, 156);
            this.timeChack.Name = "timeChack";
            this.timeChack.Size = new System.Drawing.Size(45, 21);
            this.timeChack.TabIndex = 14;
            this.timeChack.SelectedIndexChanged += new System.EventHandler(this.timeChack_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 311);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(206, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Prijavi se za pregled kod izabranog lekara:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Pronađi dostupne lekare:";
            // 
            // reportReview
            // 
            this.reportReview.Location = new System.Drawing.Point(27, 327);
            this.reportReview.Name = "reportReview";
            this.reportReview.Size = new System.Drawing.Size(200, 33);
            this.reportReview.TabIndex = 11;
            this.reportReview.Text = "Prijavi  pregled";
            this.reportReview.UseVisualStyleBackColor = true;
            this.reportReview.Click += new System.EventHandler(this.reportReview_Click);
            // 
            // findDoctor
            // 
            this.findDoctor.Location = new System.Drawing.Point(27, 196);
            this.findDoctor.Name = "findDoctor";
            this.findDoctor.Size = new System.Drawing.Size(200, 33);
            this.findDoctor.TabIndex = 10;
            this.findDoctor.Text = "Pronađi lekara";
            this.findDoctor.UseVisualStyleBackColor = true;
            this.findDoctor.Click += new System.EventHandler(this.findDoctor_Click);
            // 
            // dateChack
            // 
            this.dateChack.CustomFormat = "dd-MM-yyyy";
            this.dateChack.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateChack.Location = new System.Drawing.Point(27, 115);
            this.dateChack.Name = "dateChack";
            this.dateChack.Size = new System.Drawing.Size(108, 20);
            this.dateChack.TabIndex = 8;
            // 
            // izaberi
            // 
            this.izaberi.AutoSize = true;
            this.izaberi.Location = new System.Drawing.Point(24, 264);
            this.izaberi.Name = "izaberi";
            this.izaberi.Size = new System.Drawing.Size(76, 13);
            this.izaberi.TabIndex = 7;
            this.izaberi.Text = "Izabrati lekara:";
            // 
            // datumPregleda
            // 
            this.datumPregleda.AutoSize = true;
            this.datumPregleda.Location = new System.Drawing.Point(24, 99);
            this.datumPregleda.Name = "datumPregleda";
            this.datumPregleda.Size = new System.Drawing.Size(76, 13);
            this.datumPregleda.TabIndex = 6;
            this.datumPregleda.Text = "Izabrati datum:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Izabrati odeljenje:";
            // 
            // choseDoctor
            // 
            this.choseDoctor.FormattingEnabled = true;
            this.choseDoctor.Location = new System.Drawing.Point(27, 280);
            this.choseDoctor.Name = "choseDoctor";
            this.choseDoctor.Size = new System.Drawing.Size(200, 21);
            this.choseDoctor.TabIndex = 4;
            this.choseDoctor.SelectedIndexChanged += new System.EventHandler(this.choseDoctor_SelectedIndexChanged);
            // 
            // choseDepartment
            // 
            this.choseDepartment.FormattingEnabled = true;
            this.choseDepartment.Location = new System.Drawing.Point(27, 75);
            this.choseDepartment.Name = "choseDepartment";
            this.choseDepartment.Size = new System.Drawing.Size(200, 21);
            this.choseDepartment.TabIndex = 1;
            this.choseDepartment.SelectedIndexChanged += new System.EventHandler(this.choseDepartment_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Zakazivanje pregleda:";
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(232, 43);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(0, 13);
            this.ime.TabIndex = 13;
            // 
            // prezime
            // 
            this.prezime.AutoSize = true;
            this.prezime.Location = new System.Drawing.Point(235, 65);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(0, 13);
            this.prezime.TabIndex = 14;
            // 
            // jmbg
            // 
            this.jmbg.AutoSize = true;
            this.jmbg.Location = new System.Drawing.Point(238, 90);
            this.jmbg.Name = "jmbg";
            this.jmbg.Size = new System.Drawing.Size(0, 13);
            this.jmbg.TabIndex = 15;
            // 
            // godina
            // 
            this.godina.AutoSize = true;
            this.godina.Location = new System.Drawing.Point(264, 115);
            this.godina.Name = "godina";
            this.godina.Size = new System.Drawing.Size(0, 13);
            this.godina.TabIndex = 16;
            // 
            // pol
            // 
            this.pol.AutoSize = true;
            this.pol.Location = new System.Drawing.Point(209, 140);
            this.pol.Name = "pol";
            this.pol.Size = new System.Drawing.Size(0, 13);
            this.pol.TabIndex = 17;
            // 
            // krvna
            // 
            this.krvna.AutoSize = true;
            this.krvna.Location = new System.Drawing.Point(116, 171);
            this.krvna.Name = "krvna";
            this.krvna.Size = new System.Drawing.Size(0, 13);
            this.krvna.TabIndex = 18;
            // 
            // mesto
            // 
            this.mesto.AutoSize = true;
            this.mesto.Location = new System.Drawing.Point(119, 196);
            this.mesto.Name = "mesto";
            this.mesto.Size = new System.Drawing.Size(0, 13);
            this.mesto.TabIndex = 19;
            // 
            // drzavljanstvo
            // 
            this.drzavljanstvo.AutoSize = true;
            this.drzavljanstvo.Location = new System.Drawing.Point(122, 221);
            this.drzavljanstvo.Name = "drzavljanstvo";
            this.drzavljanstvo.Size = new System.Drawing.Size(0, 13);
            this.drzavljanstvo.TabIndex = 20;
            // 
            // nacionalnost
            // 
            this.nacionalnost.AutoSize = true;
            this.nacionalnost.Location = new System.Drawing.Point(119, 248);
            this.nacionalnost.Name = "nacionalnost";
            this.nacionalnost.Size = new System.Drawing.Size(0, 13);
            this.nacionalnost.TabIndex = 21;
            // 
            // datum_vazenja
            // 
            this.datum_vazenja.AutoSize = true;
            this.datum_vazenja.Location = new System.Drawing.Point(201, 275);
            this.datum_vazenja.Name = "datum_vazenja";
            this.datum_vazenja.Size = new System.Drawing.Size(0, 13);
            this.datum_vazenja.TabIndex = 22;
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PatientsForm";
            this.Text = "Zakazivanje pregleda:";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox choseDepartment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label datumPregleda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox choseDoctor;
        private System.Windows.Forms.DateTimePicker dateChack;
        private System.Windows.Forms.Label izaberi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button reportReview;
        private System.Windows.Forms.Button findDoctor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox timeChack;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label datum_vazenja;
        private System.Windows.Forms.Label nacionalnost;
        private System.Windows.Forms.Label drzavljanstvo;
        private System.Windows.Forms.Label mesto;
        private System.Windows.Forms.Label krvna;
        private System.Windows.Forms.Label pol;
        private System.Windows.Forms.Label godina;
        private System.Windows.Forms.Label jmbg;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.Label ime;
    }
}