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
    public partial class Form2 : Form
    {
        public static int id;
        public Form2(int id)
        {
            InitializeComponent();
            detalii1.Visible = false;
            comanda1.Visible = false;
            Form2.id = id;
            comenzi1.Visible = false;
            time1.Visible = true;
        }
        public Form2()
        {
            InitializeComponent();
            detalii1.Visible=false;
            comanda1.Visible = false;
            comenzi1.Visible = false;
            time1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            detalii1.Visible=true;
            comanda1.Visible = false;
            comenzi1.Visible = false;
            time1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            detalii1.Visible = false;
            comanda1.Visible = true;
            comenzi1.Visible = false;
            time1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            detalii1.Visible = false;
            comanda1.Visible = false;
            comenzi1.Visible = true;
            time1.Visible = true;
        }

        private void time1_Load(object sender, EventArgs e)
        {

        }

        private void comanda1_Load(object sender, EventArgs e)
        {

        }
    }
}
