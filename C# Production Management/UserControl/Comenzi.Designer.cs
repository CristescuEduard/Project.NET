
namespace Productie
{
    partial class Comenzi
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
            this.Firma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Factura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Firma,
            this.Produs,
            this.Cantitate,
            this.Data,
            this.Factura,
            this.Pret});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.ForeColor = System.Drawing.Color.Snow;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(439, 203);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Firma
            // 
            this.Firma.Text = "Firma";
            this.Firma.Width = 62;
            // 
            // Produs
            // 
            this.Produs.Text = "Produs";
            this.Produs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cantitate
            // 
            this.Cantitate.Text = "Cantitate";
            this.Cantitate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cantitate.Width = 83;
            // 
            // Data
            // 
            this.Data.Text = "Data Livrare";
            this.Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data.Width = 93;
            // 
            // Factura
            // 
            this.Factura.Text = "Factura";
            this.Factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Factura.Width = 83;
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            this.Pret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Image = global::Productie.Properties.Resources.icons8_edit_26;
            this.button3.Location = new System.Drawing.Point(484, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "Modifica";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = global::Productie.Properties.Resources.icons8_delete_26;
            this.button1.Location = new System.Drawing.Point(484, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sterge";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Productie.Properties.Resources.icons8_view_26;
            this.button2.Location = new System.Drawing.Point(176, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Arata";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Comenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Name = "Comenzi";
            this.Size = new System.Drawing.Size(609, 428);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Firma;
        private System.Windows.Forms.ColumnHeader Produs;
        private System.Windows.Forms.ColumnHeader Cantitate;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ColumnHeader Factura;
        private System.Windows.Forms.ColumnHeader Pret;
    }
}
