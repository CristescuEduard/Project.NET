
namespace Productie
{
    partial class Detalii
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Mail,
            this.Telefon});
            this.listView1.ForeColor = System.Drawing.Color.Snow;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(76, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 174);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prenume.Width = 85;
            // 
            // Mail
            // 
            this.Mail.Text = "Mail";
            this.Mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mail.Width = 86;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefon.Width = 103;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Productie.Properties.Resources.icons8_view_26;
            this.button2.Location = new System.Drawing.Point(177, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Arata";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Detalii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Name = "Detalii";
            this.Size = new System.Drawing.Size(529, 392);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.Button button2;
    }
}
