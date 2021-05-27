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
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();
            register1.Visible = false;
            time2.Visible = true;
            login1.Visible = false;
            
            connString = "Provider = Microsoft.ACE.OLDB.12.0; Data Source=Clienti.accdb";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           time2.Visible = false;
           register1.Visible = true;
           login1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           time2.Visible = true;
           register1.Visible = false;
           login1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           time2.Visible = false;
           register1.Visible = false;
           login1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
