
namespace Productie
{
    partial class Form1
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
            this.HelpB = new System.Windows.Forms.Button();
            this.LoginB = new System.Windows.Forms.Button();
            this.RegB = new System.Windows.Forms.Button();
            this.HomeB = new System.Windows.Forms.Button();
            this.time2 = new Productie.time();
            this.login1 = new Productie.Login();
            this.register1 = new Productie.Register();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.HelpB);
            this.panel1.Controls.Add(this.LoginB);
            this.panel1.Controls.Add(this.RegB);
            this.panel1.Controls.Add(this.HomeB);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 451);
            this.panel1.TabIndex = 6;
            // 
            // HelpB
            // 
            this.HelpB.FlatAppearance.BorderSize = 0;
            this.HelpB.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HelpB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpB.ForeColor = System.Drawing.Color.Snow;
            this.HelpB.Image = global::Productie.Properties.Resources.icons8_help_24;
            this.HelpB.Location = new System.Drawing.Point(0, 328);
            this.HelpB.Name = "HelpB";
            this.HelpB.Size = new System.Drawing.Size(279, 92);
            this.HelpB.TabIndex = 3;
            this.HelpB.Text = "Help Center";
            this.HelpB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HelpB.UseVisualStyleBackColor = true;
            this.HelpB.Click += new System.EventHandler(this.button4_Click);
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.Color.CadetBlue;
            this.LoginB.FlatAppearance.BorderSize = 0;
            this.LoginB.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginB.ForeColor = System.Drawing.Color.Snow;
            this.LoginB.Image = global::Productie.Properties.Resources.icons8_login_26;
            this.LoginB.Location = new System.Drawing.Point(0, 230);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(279, 92);
            this.LoginB.TabIndex = 2;
            this.LoginB.Text = "Login";
            this.LoginB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegB
            // 
            this.RegB.BackColor = System.Drawing.Color.CadetBlue;
            this.RegB.FlatAppearance.BorderSize = 0;
            this.RegB.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RegB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegB.ForeColor = System.Drawing.Color.Snow;
            this.RegB.Image = global::Productie.Properties.Resources.icons8_add_user_male_30;
            this.RegB.Location = new System.Drawing.Point(0, 132);
            this.RegB.Name = "RegB";
            this.RegB.Size = new System.Drawing.Size(279, 92);
            this.RegB.TabIndex = 1;
            this.RegB.Text = "Register";
            this.RegB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RegB.UseVisualStyleBackColor = false;
            this.RegB.Click += new System.EventHandler(this.button2_Click);
            // 
            // HomeB
            // 
            this.HomeB.FlatAppearance.BorderSize = 0;
            this.HomeB.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HomeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeB.ForeColor = System.Drawing.Color.Snow;
            this.HomeB.Image = global::Productie.Properties.Resources.icons8_home_26;
            this.HomeB.Location = new System.Drawing.Point(0, 43);
            this.HomeB.Name = "HomeB";
            this.HomeB.Size = new System.Drawing.Size(279, 92);
            this.HomeB.TabIndex = 0;
            this.HomeB.Text = "Home";
            this.HomeB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HomeB.UseVisualStyleBackColor = false;
            this.HomeB.Click += new System.EventHandler(this.button1_Click);
            // 
            // time2
            // 
            this.time2.BackColor = System.Drawing.Color.DarkCyan;
            this.time2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.time2.Location = new System.Drawing.Point(402, 25);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(250, 62);
            this.time2.TabIndex = 8;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.DarkCyan;
            this.login1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login1.Location = new System.Drawing.Point(279, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(433, 451);
            this.login1.TabIndex = 7;
            this.login1.Load += new System.EventHandler(this.login1_Load);
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.DarkCyan;
            this.register1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.register1.Location = new System.Drawing.Point(279, 0);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(432, 448);
            this.register1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Productie.Properties.Resources.icons8_xbox_x_32;
            this.button1.Location = new System.Drawing.Point(636, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private time time1;
        private Register Reg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HelpB;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.Button RegB;
        private System.Windows.Forms.Button HomeB;
        private Register register1;
        private Login login1;
        private time time2;
        private System.Windows.Forms.Button button1;
    }
}

