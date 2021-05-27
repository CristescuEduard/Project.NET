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
    public partial class Detalii : UserControl
    {
        public Detalii()
        {
            InitializeComponent();
        }

        private void RTBUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Clienti.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT Nume,Prenume,Mail,Telefon FROM Clienti WHERE ID =" + Form2.id + "";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["Nume"].ToString());
                    itm.SubItems.Add(reader["Prenume"].ToString());
                    itm.SubItems.Add(reader["Mail"].ToString());
                    itm.SubItems.Add(reader["Telefon"].ToString());
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
    }
}