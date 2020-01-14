namespace EHospital
{
    partial class LogInPatients
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordPacient = new System.Windows.Forms.TextBox();
            this.jmbgLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPatient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwordDoctor = new System.Windows.Forms.TextBox();
            this.idCardLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginDoctors = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.passwordPacient);
            this.panel1.Controls.Add(this.jmbgLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginPatient);
            this.panel1.Location = new System.Drawing.Point(37, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 317);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EHospital.Properties.Resources.hospital_login;
            this.pictureBox1.Location = new System.Drawing.Point(95, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 62);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // passwordPacient
            // 
            this.passwordPacient.Location = new System.Drawing.Point(47, 186);
            this.passwordPacient.Name = "passwordPacient";
            this.passwordPacient.Size = new System.Drawing.Size(152, 20);
            this.passwordPacient.TabIndex = 5;
            // 
            // jmbgLogin
            // 
            this.jmbgLogin.Location = new System.Drawing.Point(47, 124);
            this.jmbgLogin.Name = "jmbgLogin";
            this.jmbgLogin.Size = new System.Drawing.Size(152, 20);
            this.jmbgLogin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(44, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "JMBG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(44, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šifra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logovanje pacijenta:";
            // 
            // loginPatient
            // 
            this.loginPatient.Location = new System.Drawing.Point(47, 229);
            this.loginPatient.Name = "loginPatient";
            this.loginPatient.Size = new System.Drawing.Size(159, 39);
            this.loginPatient.TabIndex = 0;
            this.loginPatient.Text = "Uloguj se";
            this.loginPatient.UseVisualStyleBackColor = true;
            this.loginPatient.Click += new System.EventHandler(this.loginPatient_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.passwordDoctor);
            this.panel2.Controls.Add(this.idCardLogin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.loginDoctors);
            this.panel2.Location = new System.Drawing.Point(343, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 317);
            this.panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabel1.Location = new System.Drawing.Point(40, 285);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registracija naloga doktora i sestara!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::EHospital.Properties.Resources.hospital_login;
            this.pictureBox2.Location = new System.Drawing.Point(98, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 62);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // passwordDoctor
            // 
            this.passwordDoctor.Location = new System.Drawing.Point(49, 186);
            this.passwordDoctor.Name = "passwordDoctor";
            this.passwordDoctor.Size = new System.Drawing.Size(152, 20);
            this.passwordDoctor.TabIndex = 7;
            // 
            // idCardLogin
            // 
            this.idCardLogin.Location = new System.Drawing.Point(49, 124);
            this.idCardLogin.Name = "idCardLogin";
            this.idCardLogin.Size = new System.Drawing.Size(152, 20);
            this.idCardLogin.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aquamarine;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Logovanje doktora i sestara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Aquamarine;
            this.label6.Location = new System.Drawing.Point(46, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Šifra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Aquamarine;
            this.label5.Location = new System.Drawing.Point(46, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID kartica:";
            // 
            // loginDoctors
            // 
            this.loginDoctors.Location = new System.Drawing.Point(49, 229);
            this.loginDoctors.Name = "loginDoctors";
            this.loginDoctors.Size = new System.Drawing.Size(152, 39);
            this.loginDoctors.TabIndex = 0;
            this.loginDoctors.Text = "Uloguj se";
            this.loginDoctors.UseVisualStyleBackColor = true;
            this.loginDoctors.Click += new System.EventHandler(this.loginDoctors_Click);
            // 
            // LogInPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EHospital.Properties.Resources.hospital_loagin;
            this.ClientSize = new System.Drawing.Size(656, 405);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "LogInPatients";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LogIn_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordPacient;
        private System.Windows.Forms.TextBox jmbgLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginPatient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordDoctor;
        private System.Windows.Forms.TextBox idCardLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loginDoctors;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

