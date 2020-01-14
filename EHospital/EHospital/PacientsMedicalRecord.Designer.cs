namespace EHospital
{
    partial class PacientsMedicalRecord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordCreate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.registerThePatient = new System.Windows.Forms.Button();
            this.cardExpirationDateCreate = new System.Windows.Forms.DateTimePicker();
            this.birthYearCreate = new System.Windows.Forms.DateTimePicker();
            this.nationalityCreate = new System.Windows.Forms.TextBox();
            this.citizenshipCreate = new System.Windows.Forms.TextBox();
            this.placeOfBirthCreate = new System.Windows.Forms.TextBox();
            this.bloodTypeCreate = new System.Windows.Forms.TextBox();
            this.genderCreate = new System.Windows.Forms.TextBox();
            this.jmbgCreate = new System.Windows.Forms.TextBox();
            this.surnameCreate = new System.Windows.Forms.TextBox();
            this.nameCreate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updatePatient = new System.Windows.Forms.Button();
            this.jmbgUpdate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.datumVazenjaKarticeUpdate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passwordCreate);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.registerThePatient);
            this.panel1.Controls.Add(this.cardExpirationDateCreate);
            this.panel1.Controls.Add(this.birthYearCreate);
            this.panel1.Controls.Add(this.nationalityCreate);
            this.panel1.Controls.Add(this.citizenshipCreate);
            this.panel1.Controls.Add(this.placeOfBirthCreate);
            this.panel1.Controls.Add(this.bloodTypeCreate);
            this.panel1.Controls.Add(this.genderCreate);
            this.panel1.Controls.Add(this.jmbgCreate);
            this.panel1.Controls.Add(this.surnameCreate);
            this.panel1.Controls.Add(this.nameCreate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 415);
            this.panel1.TabIndex = 0;
            // 
            // passwordCreate
            // 
            this.passwordCreate.Location = new System.Drawing.Point(202, 332);
            this.passwordCreate.Name = "passwordCreate";
            this.passwordCreate.Size = new System.Drawing.Size(130, 20);
            this.passwordCreate.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 335);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Sifra:";
            // 
            // registerThePatient
            // 
            this.registerThePatient.Location = new System.Drawing.Point(100, 372);
            this.registerThePatient.Name = "registerThePatient";
            this.registerThePatient.Size = new System.Drawing.Size(159, 23);
            this.registerThePatient.TabIndex = 29;
            this.registerThePatient.Text = "Registruj pacijenta";
            this.registerThePatient.UseVisualStyleBackColor = true;
            this.registerThePatient.Click += new System.EventHandler(this.registerThePatient_Click);
            // 
            // cardExpirationDateCreate
            // 
            this.cardExpirationDateCreate.CustomFormat = "dd-MM-yyyy";
            this.cardExpirationDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cardExpirationDateCreate.Location = new System.Drawing.Point(202, 306);
            this.cardExpirationDateCreate.Name = "cardExpirationDateCreate";
            this.cardExpirationDateCreate.Size = new System.Drawing.Size(130, 20);
            this.cardExpirationDateCreate.TabIndex = 28;
            this.cardExpirationDateCreate.Value = new System.DateTime(2019, 12, 30, 0, 0, 0, 0);
            // 
            // birthYearCreate
            // 
            this.birthYearCreate.CustomFormat = "dd-MM-yyyy";
            this.birthYearCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthYearCreate.Location = new System.Drawing.Point(202, 150);
            this.birthYearCreate.Name = "birthYearCreate";
            this.birthYearCreate.Size = new System.Drawing.Size(130, 20);
            this.birthYearCreate.TabIndex = 27;
            this.birthYearCreate.Value = new System.DateTime(2019, 12, 30, 0, 0, 0, 0);
            // 
            // nationalityCreate
            // 
            this.nationalityCreate.Location = new System.Drawing.Point(202, 280);
            this.nationalityCreate.Name = "nationalityCreate";
            this.nationalityCreate.Size = new System.Drawing.Size(130, 20);
            this.nationalityCreate.TabIndex = 26;
            // 
            // citizenshipCreate
            // 
            this.citizenshipCreate.Location = new System.Drawing.Point(202, 254);
            this.citizenshipCreate.Name = "citizenshipCreate";
            this.citizenshipCreate.Size = new System.Drawing.Size(130, 20);
            this.citizenshipCreate.TabIndex = 25;
            // 
            // placeOfBirthCreate
            // 
            this.placeOfBirthCreate.Location = new System.Drawing.Point(202, 228);
            this.placeOfBirthCreate.Name = "placeOfBirthCreate";
            this.placeOfBirthCreate.Size = new System.Drawing.Size(130, 20);
            this.placeOfBirthCreate.TabIndex = 24;
            // 
            // bloodTypeCreate
            // 
            this.bloodTypeCreate.Location = new System.Drawing.Point(202, 202);
            this.bloodTypeCreate.Name = "bloodTypeCreate";
            this.bloodTypeCreate.Size = new System.Drawing.Size(130, 20);
            this.bloodTypeCreate.TabIndex = 23;
            // 
            // genderCreate
            // 
            this.genderCreate.Location = new System.Drawing.Point(202, 176);
            this.genderCreate.Name = "genderCreate";
            this.genderCreate.Size = new System.Drawing.Size(130, 20);
            this.genderCreate.TabIndex = 22;
            // 
            // jmbgCreate
            // 
            this.jmbgCreate.Location = new System.Drawing.Point(202, 124);
            this.jmbgCreate.Name = "jmbgCreate";
            this.jmbgCreate.Size = new System.Drawing.Size(130, 20);
            this.jmbgCreate.TabIndex = 20;
            // 
            // surnameCreate
            // 
            this.surnameCreate.Location = new System.Drawing.Point(202, 98);
            this.surnameCreate.Name = "surnameCreate";
            this.surnameCreate.Size = new System.Drawing.Size(130, 20);
            this.surnameCreate.TabIndex = 19;
            // 
            // nameCreate
            // 
            this.nameCreate.Location = new System.Drawing.Point(202, 72);
            this.nameCreate.Name = "nameCreate";
            this.nameCreate.Size = new System.Drawing.Size(130, 20);
            this.nameCreate.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Datum važenja zdravstvene knjižice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nacionalnost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mesto rođenja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Drževljanstvo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Krvna grupa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pol:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Godina rođenja:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "JMBG:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Prezime:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(22, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kreiranje naloga pacijenta:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updatePatient);
            this.panel2.Controls.Add(this.jmbgUpdate);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.datumVazenjaKarticeUpdate);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(377, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 180);
            this.panel2.TabIndex = 1;
            // 
            // updatePatient
            // 
            this.updatePatient.Location = new System.Drawing.Point(88, 143);
            this.updatePatient.Name = "updatePatient";
            this.updatePatient.Size = new System.Drawing.Size(153, 23);
            this.updatePatient.TabIndex = 33;
            this.updatePatient.Text = "Izmeni";
            this.updatePatient.UseVisualStyleBackColor = true;
            this.updatePatient.Click += new System.EventHandler(this.updatePatient_Click);
            // 
            // jmbgUpdate
            // 
            this.jmbgUpdate.Location = new System.Drawing.Point(165, 75);
            this.jmbgUpdate.Name = "jmbgUpdate";
            this.jmbgUpdate.Size = new System.Drawing.Size(141, 20);
            this.jmbgUpdate.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Uneti JMBG pacijenta:";
            // 
            // datumVazenjaKarticeUpdate
            // 
            this.datumVazenjaKarticeUpdate.CustomFormat = "dd-MM-yyyy";
            this.datumVazenjaKarticeUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumVazenjaKarticeUpdate.Location = new System.Drawing.Point(190, 101);
            this.datumVazenjaKarticeUpdate.Name = "datumVazenjaKarticeUpdate";
            this.datumVazenjaKarticeUpdate.Size = new System.Drawing.Size(116, 20);
            this.datumVazenjaKarticeUpdate.TabIndex = 29;
            this.datumVazenjaKarticeUpdate.Value = new System.DateTime(2019, 12, 30, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Datum važenja zdravstvene knjižice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izmena informacija zdravstvene knjizice:";
            // 
            // PacientsMedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PacientsMedicalRecord";
            this.Text = "PacientsMedicalRecord";
            this.Load += new System.EventHandler(this.PacientsMedicalRecord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker birthYearCreate;
        private System.Windows.Forms.TextBox nationalityCreate;
        private System.Windows.Forms.TextBox citizenshipCreate;
        private System.Windows.Forms.TextBox placeOfBirthCreate;
        private System.Windows.Forms.TextBox bloodTypeCreate;
        private System.Windows.Forms.TextBox genderCreate;
        private System.Windows.Forms.TextBox jmbgCreate;
        private System.Windows.Forms.TextBox surnameCreate;
        private System.Windows.Forms.TextBox nameCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker cardExpirationDateCreate;
        private System.Windows.Forms.TextBox jmbgUpdate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker datumVazenjaKarticeUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button registerThePatient;
        private System.Windows.Forms.Button updatePatient;
        private System.Windows.Forms.TextBox passwordCreate;
        private System.Windows.Forms.Label label17;
    }
}