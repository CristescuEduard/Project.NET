using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;

namespace Productie
{
    public partial class Form3 : Form
    {
        Graphics g;
        double[] vect = new double[20];
        int nrElem = 0;
        bool vb = false;
        const int marg = 10;
        Color culoare = Color.DarkCyan;
        Font font = new Font(FontFamily.GenericSerif, 12, FontStyle.Bold);
        public Form3()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                Graphics gr = e.Graphics;
                Rectangle rec = new Rectangle(e.PageBounds.X + marg, e.PageBounds.Y + 4 * marg,
                    e.PageBounds.Width - 2 * marg, e.PageBounds.Height - 5 * marg);
                Pen pen = new Pen(Color.Aqua, 3);
                gr.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rec.Height));
                    gr.FillEllipse(br, recs[i]);
                    gr.DrawString(vect[i].ToString(), font, br, new Point(recs[i].Location.X,
                        recs[i].Location.Y - font.Height));
                }
                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)recs[i].Location.Y),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), (int)recs[i + 1].Location.Y));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=Clienti.accdb");
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM Comenzi";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    vect[nrElem] = Convert.ToDouble(reader["Pret"].ToString());
                    nrElem++;
                    vb = true;
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
                MessageBox.Show("Date incarcate!");
                conexiune.Close();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics gr = e.Graphics;
                Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + 4 * marg,
                    panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 5 * marg);
                Pen pen = new Pen(Color.Aqua, 3);
                gr.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rec.Height));
                    gr.FillEllipse(br, recs[i]);
                    gr.DrawString(vect[i].ToString(), font, br, new Point(recs[i].Location.X,
                        recs[i].Location.Y - font.Height));
                }

                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)recs[i].Location.Y),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), (int)recs[i + 1].Location.Y));
            }
        }
    }
}