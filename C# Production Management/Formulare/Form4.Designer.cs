
namespace Productie
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFirma = new System.Windows.Forms.ComboBox();
            this.cbFactura = new System.Windows.Forms.ComboBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.cbProdus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(131, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificati Comanda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(60, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firma";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(60, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(60, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantitate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(60, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(60, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Factura";
            // 
            // cbFirma
            // 
            this.cbFirma.FormattingEnabled = true;
            this.cbFirma.Items.AddRange(new object[] {
            "Dacia",
            "Renault",
            "Ford"});
            this.cbFirma.Location = new System.Drawing.Point(144, 96);
            this.cbFirma.Name = "cbFirma";
            this.cbFirma.Size = new System.Drawing.Size(121, 24);
            this.cbFirma.TabIndex = 6;
            this.cbFirma.Validating += new System.ComponentModel.CancelEventHandler(this.cbFirma_Validating);
            // 
            // cbFactura
            // 
            this.cbFactura.FormattingEnabled = true;
            this.cbFactura.Items.AddRange(new object[] {
            "Persoana Juridica",
            "Persoana Fizica"});
            this.cbFactura.Location = new System.Drawing.Point(144, 265);
            this.cbFactura.Name = "cbFactura";
            this.cbFactura.Size = new System.Drawing.Size(121, 24);
            this.cbFactura.TabIndex = 7;
            this.cbFactura.Validating += new System.ComponentModel.CancelEventHandler(this.cbFactura_Validating);
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(144, 186);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(121, 22);
            this.tbCantitate.TabIndex = 9;
            this.tbCantitate.Validating += new System.ComponentModel.CancelEventHandler(this.tbCantitate_Validating);
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(144, 228);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(121, 22);
            this.dtData.TabIndex = 10;
            this.dtData.Validating += new System.ComponentModel.CancelEventHandler(this.dtData_Validating);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(144, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salveaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Productie.Properties.Resources.icons8_xbox_x_32;
            this.button2.Location = new System.Drawing.Point(315, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 39);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbProdus
            // 
            this.cbProdus.FormattingEnabled = true;
            this.cbProdus.Items.AddRange(new object[] {
            "Motor",
            "Masina",
            "Caroserie"});
            this.cbProdus.Location = new System.Drawing.Point(144, 144);
            this.cbProdus.Name = "cbProdus";
            this.cbProdus.Size = new System.Drawing.Size(121, 24);
            this.cbProdus.TabIndex = 13;
            this.cbProdus.Validating += new System.ComponentModel.CancelEventHandler(this.cbProdus_Validating_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.cbProdus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.cbFactura);
            this.Controls.Add(this.cbFirma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "Modificati";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFirma;
        private System.Windows.Forms.ComboBox cbFactura;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbProdus;
    }
}