
namespace Productie
{
    partial class Register
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registration = new System.Windows.Forms.Button();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCParola = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eroare = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eroare)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(113, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(74, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(69, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(135, 61);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 22);
            this.tbNume.TabIndex = 3;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbParola_Validating);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(135, 101);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(100, 22);
            this.tbPrenume.TabIndex = 4;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbCParola_Validating);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(135, 152);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(100, 22);
            this.tbMail.TabIndex = 5;
            this.tbMail.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.registration);
            this.panel1.Controls.Add(this.tbPrenume);
            this.panel1.Controls.Add(this.tbParola);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbCParola);
            this.panel1.Controls.Add(this.tbTelefon);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbMail);
            this.panel1.Controls.Add(this.tbNume);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(67, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 524);
            this.panel1.TabIndex = 6;
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.DarkCyan;
            this.registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registration.FlatAppearance.BorderSize = 0;
            this.registration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registration.ForeColor = System.Drawing.Color.Snow;
            this.registration.Location = new System.Drawing.Point(116, 395);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(79, 40);
            this.registration.TabIndex = 15;
            this.registration.Text = "Register";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            this.registration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registration_KeyPress);
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(135, 299);
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(100, 22);
            this.tbParola.TabIndex = 12;
            this.tbParola.TextChanged += new System.EventHandler(this.tbParola_TextChanged);
            this.tbParola.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating_1);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(135, 342);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 22);
            this.tbUsername.TabIndex = 14;
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(10, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nume Utilizator:";
            // 
            // tbCParola
            // 
            this.tbCParola.Location = new System.Drawing.Point(135, 258);
            this.tbCParola.Name = "tbCParola";
            this.tbCParola.Size = new System.Drawing.Size(100, 22);
            this.tbCParola.TabIndex = 11;
            this.tbCParola.TextChanged += new System.EventHandler(this.tbCParola_TextChanged);
            this.tbCParola.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(135, 211);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(100, 22);
            this.tbTelefon.TabIndex = 10;
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbMail_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(1, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Confirmare Parola";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(60, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Prenume:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(80, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nume:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(92, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mail:";
            // 
            // eroare
            // 
            this.eroare.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(459, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eroare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.TextBox tbCParola;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.ErrorProvider eroare;
    }
}
