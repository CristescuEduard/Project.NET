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
    public partial class Comenzi : UserControl
    {
        public Comenzi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Clienti.accdb");
            try
            {
                listView1.Items.Clear();
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT ID,Id_Comanda, Firma,Produs,Cantitate,Data,Factura,Pret FROM Comenzi where ID =" + Form2.id + "";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["Firma"].ToString());
                    itm.SubItems.Add(reader["Produs"].ToString());
                    itm.SubItems.Add(reader["Cantitate"].ToString());
                    itm.SubItems.Add(reader["Data"].ToString());
                    itm.SubItems.Add(reader["Factura"].ToString());
                    itm.SubItems.Add(reader["Pret"].ToString());
                    itm.SubItems.Add(reader["ID"].ToString());
                    listView1.Items.Add(itm);
                }
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
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Clienti.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        int id = Convert.ToInt32(itm.SubItems[6].Text);
                        comanda.CommandText = "Select ID from Comenzi where ID=" + id;
                        int ID = Convert.ToInt32(comanda.ExecuteScalar());
                        comanda.CommandText = "Select Id_Comanda from Comenzi where ID=" + id;
                        int Id = Convert.ToInt32(comanda.ExecuteScalar());
                        comanda.CommandText = "Select Firma from Comenzi where ID=" + id;
                        string Firma = Convert.ToString(comanda.ExecuteScalar());
                        comanda.CommandText = "Select Produs from Comenzi where ID=" + id;
                        string Produs = Convert.ToString(comanda.ExecuteScalar());
                        comanda.CommandText = "Select Cantitate from Comenzi where ID=" + id;
                        int cantitate = Convert.ToInt32(comanda.ExecuteScalar());
                        comanda.CommandText = "Select Data from Comenzi where ID=" + id;
                        string data = Convert.ToString(comanda.ExecuteScalar());
                        comanda.CommandText = "Select Factura from Comenzi where ID=" + id;
                        string factura = Convert.ToString(comanda.ExecuteScalar());
                        comanda.CommandText = "Select Pret from Comenzi where ID=" + id;
                        int pret = Convert.ToInt32(comanda.ExecuteScalar());
                        Form4 form4 = new Form4(ID,Id);
                        form4.Show();
                    }
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
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Clienti.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        string pro= itm.SubItems[1].Text;
                        comanda.CommandText = "Delete from Comenzi where Produs='"+ pro+"'";
                        comanda.ExecuteNonQuery();
                        MessageBox.Show("Stergere realizata cu succes!");
                    }
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
            }
        }
    }
}
