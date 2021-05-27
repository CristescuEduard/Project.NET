
namespace Productie
{
    partial class Comanda
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFirma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFactura = new System.Windows.Forms.ComboBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.cbProdus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(215, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comanda Acum!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(162, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Firma:";
            // 
            // cbFirma
            // 
            this.cbFirma.FormattingEnabled = true;
            this.cbFirma.Items.AddRange(new object[] {
            "Dacia",
            "Ford",
            "Renault"});
            this.cbFirma.Location = new System.Drawing.Point(230, 108);
            this.cbFirma.Name = "cbFirma";
            this.cbFirma.Size = new System.Drawing.Size(99, 24);
            this.cbFirma.TabIndex = 6;
            this.cbFirma.Validating += new System.ComponentModel.CancelEventHandler(this.cbFirma_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(158, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(151, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantitate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(129, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Livrare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(162, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Factura:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbFactura
            // 
            this.cbFactura.FormattingEnabled = true;
            this.cbFactura.Items.AddRange(new object[] {
            "Persoana Fizica",
            "Persoana Juridica"});
            this.cbFactura.Location = new System.Drawing.Point(230, 294);
            this.cbFactura.Name = "cbFactura";
            this.cbFactura.Size = new System.Drawing.Size(99, 24);
            this.cbFactura.TabIndex = 11;
            this.cbFactura.Validating += new System.ComponentModel.CancelEventHandler(this.cbFactura_Validating);
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(230, 201);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(99, 22);
            this.tbCantitate.TabIndex = 14;
            this.tbCantitate.Validating += new System.ComponentModel.CancelEventHandler(this.tbCantitate_Validating);
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(233, 247);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(96, 22);
            this.dtData.TabIndex = 15;
            this.dtData.ValueChanged += new System.EventHandler(this.dtData_ValueChanged);
            this.dtData.Validating += new System.ComponentModel.CancelEventHandler(this.dtData_Validating);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Productie.Properties.Resources.icons8_email_send_241;
            this.button2.Location = new System.Drawing.Point(209, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 72);
            this.button2.TabIndex = 3;
            this.button2.Text = "Comanda";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button2_KeyPress);
            // 
            // cbProdus
            // 
            this.cbProdus.FormattingEnabled = true;
            this.cbProdus.Items.AddRange(new object[] {
            "Motor",
            "Masina",
            "Caroserie"});
            this.cbProdus.Location = new System.Drawing.Point(230, 154);
            this.cbProdus.Name = "cbProdus";
            this.cbProdus.Size = new System.Drawing.Size(99, 24);
            this.cbProdus.TabIndex = 16;
            // 
            // Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.cbProdus);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.cbFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFirma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Name = "Comanda";
            this.Size = new System.Drawing.Size(534, 520);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFactura;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ComboBox cbProdus;
    }
}
