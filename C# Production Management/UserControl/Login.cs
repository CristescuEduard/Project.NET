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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tbUser.Text == "eduard" && tbPass.Text == "cristescu")
            {
                MessageBox.Show("Welcome, " + tbUser.Text + "!");
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Clienti.accdb");
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT Parola FROM Clienti where Username ='" + tbUser.Text + "'";
                    string pass = Convert.ToString(comanda.ExecuteScalar());
                    if (pass == tbPass.Text && tbUser.Text != "" && tbPass.Text != "")
                    {
                        MessageBox.Show("Welcome, " + tbUser.Text + "!");
                        comanda.CommandText = "SELECT ID FROM Clienti where Username ='" + tbUser.Text + "'";
                        int id = Convert.ToInt32(comanda.ExecuteScalar());
                        Form2 form2 = new Form2(id);
                        form2.ShowDialog();
                    }
                    else if ((tbUser.Text == "" && tbPass.Text == ""))
                    {
                        MessageBox.Show("Input your username and password!");
                    }
                    else { MessageBox.Show("Invalid user or password! Try Again!"); }
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
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Clienti.accdb");
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT MAX(ID) FROM Clienti";
                    int n = Convert.ToInt32(comanda.ExecuteScalar()), i, ok = 0;
                    for (i = 0; i <= n - 1; i++)
                    {
                        comanda.CommandText = "SELECT Username FROM Clienti";
                        string uss = Convert.ToString(comanda.ExecuteScalar());
                        comanda.CommandText = "SELECT Parola FROM Clienti";
                        string pass = Convert.ToString(comanda.ExecuteScalar());
                        if (uss == tbUser.Text && pass == tbPass.Text && tbUser.Text != "" && tbPass.Text != "")
                        {
                            MessageBox.Show("Welcome, " + tbUser.Text + "!");
                            ((Form)this.TopLevelControl).Close();
                            ok = 1;
                        }
                        else if ((tbUser.Text == "" && tbPass.Text == ""))
                        {
                            MessageBox.Show("Input your username and password!");
                        }
                    }
                    if (ok == 0) { MessageBox.Show("Invalid user or password! Try Again!"); }
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

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;
        }
    }
}
