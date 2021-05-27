using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.IO;

namespace Productie
{
    public partial class Register : UserControl
    {
        List<User> UserList1 = new List<User>();
        public static User u = new User();
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void registration_Click(object sender, EventArgs e)
        {
            string fName = tbNume.Text;
            string lName = tbPrenume.Text;
            string phone = tbTelefon.Text;
            string email = tbMail.Text;
            string pass = tbParola.Text;
            string confPass = tbCParola.Text;
            string uName = tbUsername.Text;
            if (tbNume.Text == "" || tbPrenume.Text == "" || tbTelefon.Text == "" || tbMail.Text == "" || tbUsername.Text == "" || tbParola.Text == "" || tbCParola.Text == "")
            {
                MessageBox.Show("One or more fields ar empty!");

            }
            else
            {
                UserList1.Add(new User(fName, lName, email, phone, pass, confPass, uName));
                foreach (var user in UserList1)
                {
                    MessageBox.Show(user.ToString() + "\n");
                }
            }
            try
            {
                u.Nume = fName;
                u.Prenume = lName;
                u.NrTel = phone;
                u.Mail = email;
                u.Pass = pass;
                u.ConfPass = confPass;
                u.UName = uName;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            // string docPath = @"C:\c#\users.txt";
            // File.WriteAllLines(docPath, new string[]{ uName, pass});
            TextWriter userWrite = new StreamWriter("LoginInfo.txt");
            foreach (User s in UserList1)
            {
                userWrite.WriteLine(s.UName);
                userWrite.WriteLine(s.ConfPass);
            }
            userWrite.Close();
            TextWriter tw = new StreamWriter("UserList.txt");
            foreach (var u in UserList1)
            {
                tw.WriteLine(u);
            }
            tw.Close();
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Clienti.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT MAX(ID) FROM Clienti";
                int id = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "INSERT INTO Clienti VALUES(?,?,?,?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                comanda.Parameters.Add("Nume", OleDbType.Char, 20).Value = tbNume.Text;
                comanda.Parameters.Add("Prenume", OleDbType.Char, 20).Value = tbPrenume.Text;
                comanda.Parameters.Add("Mail", OleDbType.Char, 50).Value = tbMail.Text;
                comanda.Parameters.Add("Parola", OleDbType.Char, 20).Value = tbParola.Text;
                comanda.Parameters.Add("Username", OleDbType.Char, 20).Value = tbUsername.Text;
                comanda.Parameters.Add("Telefon", OleDbType.Integer).Value = Convert.ToInt32(tbTelefon.Text);
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
                tbParola.Clear();
                tbCParola.Clear();
                tbTelefon.Clear();
                tbPrenume.Clear();
                tbNume.Clear();
                tbMail.Clear();
                tbUsername.Clear();
            }
        }

        private void tbNume_Validating_1(object sender, CancelEventArgs e)
        {
            if (tbCParola.Text != tbParola.Text)
            {
                eroare.SetError(tbParola, "Parolele nu se potrivesc!");
                tbParola.Focus();
            }
            else if (tbParola.Text == "")
            {
                eroare.SetError(tbParola, "Trebuie sa confirmi parola");
            }
            else
            {
                eroare.SetError(tbParola, "");
            }
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (tbCParola.Text == "")
            {
                eroare.SetError(tbCParola, "Parola introdusa gresit");
                tbCParola.Focus();
            }
            else
            {
                eroare.SetError(tbCParola, "");
            }
        }

        private void tbMail_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelefon.Text == "")
            {
                eroare.SetError(tbTelefon, "Nu ati adaugat numarul de telefon");
                tbTelefon.Focus();
            }
            else if (!Regex.IsMatch(tbTelefon.Text, @"^(\+4|)?(07[0-8]{1}[0-9]{1}|02[0-9]{2}|03[0-9]{2}){1}?(\s|\.|\-)?([0-9]{3}(\s|\.|\-|)){2}$"))
            {
                eroare.SetError(tbTelefon, "Numarul trebuie sa respecte formatul valid");
                tbTelefon.Focus();
            }
            else
            {
                eroare.SetError(tbTelefon, "");
            }
        }

        private void tbParola_Validating(object sender, CancelEventArgs e)
        {
            if (tbNume.Text == "")
            {
                eroare.SetError(tbNume, "Nume introdus gresit");
                tbParola.Focus();
            }
            else if (!Regex.IsMatch(tbNume.Text, "([A-ZAÎ??Â])+(?=.{1,40}$)[a-zA-ZAÎ??Âaî??]+(?:[-\\s][a-zA-ZAÎ??Âaî??â]+)*$"))
            {
                eroare.SetError(tbNume, "Numele trebuie sa inceapa cu litera mare si sa nu contina numere");
                tbNume.Focus();
            }
            else
            {
                eroare.SetError(tbNume, "");
            }
        }

        private void tbCParola_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenume.Text == "")
            {
                eroare.SetError(tbPrenume, "Nume introdus gresit");
                tbPrenume.Focus();
            }
            else if (!Regex.IsMatch(tbPrenume.Text, "([A-ZAÎ??Â])+(?=.{1,40}$)[a-zA-ZAÎ??Âaî??]+(?:[-\\s][a-zA-ZAÎ??Âaî??â]+)*$"))
            {
                eroare.SetError(tbPrenume, "Numele trebuie sa inceapa cu litera mare si sa nu contina numere");
                tbPrenume.Focus();
            }
            else
            {
                eroare.SetError(tbPrenume, "");
            }
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (tbMail.Text == "")
            {
                eroare.SetError(tbMail, "Mail input is empty!");
                tbMail.Focus();
            }
            else if (!Regex.IsMatch(tbMail.Text, @"[a-zA-Z0-9_\.-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9\.]{2,5}$"))
            {
                eroare.SetError(tbMail, "Email must respect the valid format!");
                tbMail.Focus();
            }
            else
            {
                eroare.SetError(tbMail, "");
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (tbUsername.Text == "")
            {
                eroare.SetError(tbUsername, "Parola introdusa gresit");
                tbUsername.Focus();
            }
            else
            {
                eroare.SetError(tbUsername, "");
            }
        }

        private void registration_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbCParola_TextChanged(object sender, EventArgs e)
        {
            tbCParola.UseSystemPasswordChar = true;
        }

        private void tbParola_TextChanged(object sender, EventArgs e)
        {
            tbParola.UseSystemPasswordChar = true;
        }
    }
}