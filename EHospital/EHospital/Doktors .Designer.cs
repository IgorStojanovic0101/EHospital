using System.ComponentModel;

namespace EHospital
{
    partial class Doktors
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shiftDoctor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.smena = new System.Windows.Forms.Label();
            this.id_cartice = new System.Windows.Forms.Label();
            this.odeljenje = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.Label();
            this.changeShift = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createAccountPatient = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Odeljenje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID kartice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Smena:";
            // 
            // shiftDoctor
            // 
            this.shiftDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftDoctor.Location = new System.Drawing.Point(284, 167);
            this.shiftDoctor.Name = "shiftDoctor";
            this.shiftDoctor.Size = new System.Drawing.Size(75, 23);
            this.shiftDoctor.TabIndex = 7;
            this.shiftDoctor.Text = "Promeni";
            this.shiftDoctor.UseVisualStyleBackColor = true;
            this.shiftDoctor.Click += new System.EventHandler(this.shiftDoctor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.smena);
            this.groupBox1.Controls.Add(this.id_cartice);
            this.groupBox1.Controls.Add(this.odeljenje);
            this.groupBox1.Controls.Add(this.prezime);
            this.groupBox1.Controls.Add(this.ime);
            this.groupBox1.Controls.Add(this.changeShift);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.shiftDoctor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 202);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije doktora i sestara:";
            // 
            // smena
            // 
            this.smena.AutoSize = true;
            this.smena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.smena.Location = new System.Drawing.Point(215, 132);
            this.smena.Name = "smena";
            this.smena.Size = new System.Drawing.Size(0, 13);
            this.smena.TabIndex = 14;
            // 
            // id_cartice
            // 
            this.id_cartice.AutoSize = true;
            this.id_cartice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cartice.Location = new System.Drawing.Point(215, 108);
            this.id_cartice.Name = "id_cartice";
            this.id_cartice.Size = new System.Drawing.Size(0, 15);
            this.id_cartice.TabIndex = 13;
            // 
            // odeljenje
            // 
            this.odeljenje.AutoSize = true;
            this.odeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.odeljenje.Location = new System.Drawing.Point(207, 89);
            this.odeljenje.Name = "odeljenje";
            this.odeljenje.Size = new System.Drawing.Size(0, 13);
            this.odeljenje.TabIndex = 12;
            // 
            // prezime
            // 
            this.prezime.AutoSize = true;
            this.prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.prezime.Location = new System.Drawing.Point(207, 67);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(0, 13);
            this.prezime.TabIndex = 11;
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ime.Location = new System.Drawing.Point(209, 45);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(0, 13);
            this.ime.TabIndex = 10;
            // 
            // changeShift
            // 
            this.changeShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeShift.Location = new System.Drawing.Point(240, 169);
            this.changeShift.Name = "changeShift";
            this.changeShift.Size = new System.Drawing.Size(38, 20);
            this.changeShift.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Promeni smenu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EHospital.Properties.Resources.doctorID;
            this.pictureBox1.Location = new System.Drawing.Point(6, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createAccountPatient);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 74);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Napravi nalog ili izmeni informacije o pacijentu:";
            // 
            // createAccountPatient
            // 
            this.createAccountPatient.Location = new System.Drawing.Point(19, 29);
            this.createAccountPatient.Name = "createAccountPatient";
            this.createAccountPatient.Size = new System.Drawing.Size(383, 23);
            this.createAccountPatient.TabIndex = 9;
            this.createAccountPatient.Text = "Napravi nalog ili izmeni informacije o pacijentu";
            this.createAccountPatient.UseVisualStyleBackColor = true;
            this.createAccountPatient.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(18, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 74);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prikazivanje informacija o terminu zakazivanja:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Prikazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Doktors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 424);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Doktors";
            this.Text = "Doktors";
            this.Load += new System.EventHandler(this.Doktors_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button shiftDoctor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox changeShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button createAccountPatient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label smena;
        private System.Windows.Forms.Label id_cartice;
        private System.Windows.Forms.Label odeljenje;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.Label ime;
    }
}