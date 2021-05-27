using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Productie
{
    public partial class Comanda : UserControl
    {
        public Comanda()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Clienti.accdb");
            try
            {
                int pret = 0;
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT MAX(Id_Comanda) FROM Comenzi";
                int id_max = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "INSERT INTO Comenzi VALUES(?,?,?,?,?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = Form2.id;
                comanda.Parameters.Add("Id_Comanda", OleDbType.Integer).Value = id_max+1;
                comanda.Parameters.Add("Firma", OleDbType.Char, 20).Value = cbFirma.Text;
                comanda.Parameters.Add("Produs", OleDbType.Char, 20).Value = cbProdus.Text;
                if (cbProdus.Text == "Motor") pret = 3000;
                else if (cbProdus.Text == "Masina") pret = 6000;
                else if (cbProdus.Text == "Caroserie") pret = 1000;
                comanda.Parameters.Add("Cantitate", OleDbType.Integer).Value = Convert.ToInt32(tbCantitate.Text);
                comanda.Parameters.Add("Data", OleDbType.Char, 50).Value = dtData.Text; 
                comanda.Parameters.Add("Factura", OleDbType.Char, 20).Value = cbFactura.Text;
                if (cbFirma.Text == "Dacia")
                {
                comanda.Parameters.Add("Pret", OleDbType.Integer).Value = pret * Convert.ToInt32(tbCantitate.Text) * 4;
                }
                if (cbFirma.Text == "Renault")
                {
                    comanda.Parameters.Add("Pret", OleDbType.Integer).Value = pret * Convert.ToInt32(tbCantitate.Text) * 5;
                }
                if (cbFirma.Text == "Ford")
                {
                    comanda.Parameters.Add("Pret", OleDbType.Integer).Value = pret * Convert.ToInt32(tbCantitate.Text) * 6;
                }
                comanda.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbCantitate.Clear();
                MessageBox.Show("Comanda adaugata");
            }
        }

        private void cbFirma_Validating(object sender, CancelEventArgs e)
        {
            if (cbFirma.Text != "Dacia" && cbFirma.Text != "Renault" && cbFirma.Text != "Ford")
            {
                errorProvider2.SetError(cbFirma, "Selectati una din cele trei variante");
                cbFirma.Focus();
            }
            else if (cbFirma.Text == "")
            {
                errorProvider2.SetError(cbFirma, "Trebuie selectata fabrica");
            }
        }

        private void cbProdus_Validating(object sender, CancelEventArgs e)
        {
            if (cbProdus.Text != "Motor" && cbProdus.Text != "Caroserie" && cbProdus.Text != "Masina")
            {
                errorProvider2.SetError(cbProdus, "Selectati una din cele trei variante");
                cbProdus.Focus();
            }
            else if (cbProdus.Text == "")
            {
                errorProvider2.SetError(cbProdus, "Trebuie selectata fabrica");
            }
        }

        private void tbCantitate_Validating(object sender, CancelEventArgs e)
        {
            if (tbCantitate.Text == "")
            {
                errorProvider2.SetError(tbCantitate, "Cantitatea trebuie introdusa");
                tbCantitate.Focus();
            }
            else
            {
                errorProvider2.SetError(tbCantitate, "");
            }

        }

        private void dtData_Validating(object sender, CancelEventArgs e)
        {
                DateTime data = Convert.ToDateTime(dtData.Text);
                DateTime local = DateTime.Now;
                TimeSpan ts = data.Subtract(local);
                int dif = Convert.ToInt32(ts.Days);
                if (dif < 7)
                {
                    errorProvider2.SetError(dtData, "Selectati o data mai mare cu cel putin 7 zile decat cea curenta");
                    dtData.Focus();
                }
                else if (dtData.Text == "")
                {
                errorProvider2.SetError(dtData, "Trebuie selectata data de livrare");
                }
                else
                {
                errorProvider2.SetError(dtData, "");
                }

        }

        private void cbFactura_Validating(object sender, CancelEventArgs e)
        {
            if(cbFactura.Text!="Persoana Fizica"&& cbFactura.Text != "Persoana Juridica")
            {
                errorProvider2.SetError(cbFactura, "Selectati una din cele doua variante");
                cbFactura.Focus();
            }
            else if (cbFactura.Text == "")
            {
                errorProvider2.SetError(cbFactura, "Trebuie selectata modalitatea de facturare");
            }
            else
            {
                errorProvider2.SetError(cbFactura, "");
            }
        }

        private void dtData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Clienti.accdb");
                try
                {
                    int pret = 0;
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT MAX(Id_Comanda) FROM Comenzi";
                    int id_max = Convert.ToInt32(comanda.ExecuteScalar());
                    comanda.CommandText = "INSERT INTO Comenzi VALUES(?,?,?,?,?,?,?,?)";
                    comanda.Parameters.Add("ID", OleDbType.Integer).Value = Form2.id;
                    comanda.Parameters.Add("Id_Comanda", OleDbType.Integer).Value = id_max + 1;
                    comanda.Parameters.Add("Firma", OleDbType.Char, 20).Value = cbFirma.Text;
                    comanda.Parameters.Add("Produs", OleDbType.Char, 20).Value = cbProdus.Text;
                    if (cbProdus.Text == "Motor") pret = 3000;
                    else if (cbProdus.Text == "Masina") pret = 6000;
                    else if (cbProdus.Text == "Caroserie") pret = 1000;
                    comanda.Parameters.Add("Cantitate", OleDbType.Integer).Value = Convert.ToInt32(tbCantitate.Text);
                    comanda.Parameters.Add("Data", OleDbType.Char, 50).Value = dtData.Text;
                    comanda.Parameters.Add("Factura", OleDbType.Char, 20).Value = cbFactura.Text;
                    if (cbFirma.Text == "Dacia")
                    {
                        comanda.Parameters.Add("Pret", OleDbType.Integer).Value = pret * Convert.ToInt32(tbCantitate.Text) * 4;
                    }
                    if (cbFirma.Text == "Renault")
                    {
                        comanda.Parameters.Add("Pret", OleDbType.Integer).Value = pret * Convert.ToInt32(tbCantitate.Text) * 5;
                    }
                    if (cbFirma.Text == "Ford")
                    {
                        comanda.Parameters.Add("Pret", OleDbType.Integer).Value = pret * Convert.ToInt32(tbCantitate.Text) * 6;
                    }
                    comanda.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                    tbCantitate.Clear();
                    MessageBox.Show("Comanda adaugata");
                }
            }
        }
    }
}
