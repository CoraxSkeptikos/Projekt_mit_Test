using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABC_Analyse_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hauptfunktion(int aAnteil, int cAnteil)
        {
            var verbindung = Verbinder();
            var maxID = ErfrageMaxID(verbindung);
            var bezeichnungen = ErfrageStringSpalte(verbindung, "Bezeichnung", maxID);
            var mengen = ErfrageDoubleSpalte(verbindung, "Menge", maxID);
            var preise = ErfrageDoubleSpalte(verbindung, "Preis", maxID);
            var werte = ErrechneWerte(mengen, preise);
            var raenge = BestimmeRangfolge(werte);
            var mengenprozent = ErrechneProzent(mengen);
            var wertprozent = ErrechneProzent(werte);
            var wertkumulativ = KummuliereWerte(wertprozent, raenge);
            var kategorien = BestimmeKategorien(wertkumulativ, raenge, aAnteil, cAnteil);

            dataGridView1.Rows.Clear();
            DGVbefuellen(bezeichnungen, mengen, mengenprozent, preise, werte, wertprozent, kategorien);
            dataGridView1.Sort(dataGridView1.Columns["WertAbsolut"], ListSortDirection.Descending);
            DGVfaerben();

            labelValueA.Text = aAnteil.ToString() + "%";
            labelValueC.Text = cAnteil.ToString() + "%";

            DiagrammErstellen(kategorien, mengenprozent);
            
        }

        private void DiagrammErstellen(char[] kategorien, int[] mengenprozent)
        {
            chart1.Series["Mengenanteile"].Points.Clear();
            chart1.Series["Mengenanteile"].Points.AddXY("A", MengenanteilBerechnen(kategorien, mengenprozent, 'A'));
            chart1.Series["Mengenanteile"].Points.AddXY("B", MengenanteilBerechnen(kategorien, mengenprozent, 'B'));
            chart1.Series["Mengenanteile"].Points.AddXY("C", MengenanteilBerechnen(kategorien, mengenprozent, 'C'));
            chart1.Series["Mengenanteile"].Points[0].Color = Color.Tomato;
            chart1.Series["Mengenanteile"].Points[1].Color = Color.Khaki;
            chart1.Series["Mengenanteile"].Points[2].Color = Color.SkyBlue;
        }

        private void DGVfaerben()
        {
            foreach (DataGridViewRow zeile in dataGridView1.Rows)
                if (Convert.ToString(zeile.Cells[6].Value) == "A")
                {
                    zeile.DefaultCellStyle.BackColor = Color.Tomato;
                }
                else if (Convert.ToString(zeile.Cells[6].Value) == "C")
                {
                    zeile.DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                else
                {
                    zeile.DefaultCellStyle.BackColor = Color.Khaki;
                }
        }

        private void DGVbefuellen(string[] bezeichnungen, double[] mengen, int[] mengenprozent, double[] preise, double[] werte, int[] wertprozent, char[] kategorien)
        {
            for (int i = 0; i < bezeichnungen.Length; i++)
            {
                if (bezeichnungen[i] != null && bezeichnungen[i] != "")
                {
                    dataGridView1.Rows.Add(bezeichnungen[i], mengen[i], mengenprozent[i], preise[i], werte[i], wertprozent[i], kategorien[i]);
                }
            }
        }

        private int MengenanteilBerechnen(char[] kategorien, int[] mengenprozent, char kategorie)
        {
            int summe = 0;

            for (int i = 0; i < kategorien.Length; i++)
            {
                if (kategorien[i] == kategorie)
                {
                    summe += mengenprozent[i];
                }
            }

            return summe;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime heute = DateTime.Today;
            labelDatum.Text = heute.ToString("d");

            Hauptfunktion(trackBarA.Value, trackBarC.Value);
        }

        private string[] ErfrageStringSpalte(MySqlConnection verbindung, string spaltenname, int maxID)
        {
            string[] spalte = new string[maxID+1];

            //open the connection
            verbindung.Open();

            MySqlCommand abfrage = new MySqlCommand();
            abfrage.Connection = verbindung;

            for (int i = 0; i <= maxID; i++)
            {
                abfrage.CommandText = "SELECT " + spaltenname + " FROM moebellager WHERE Id = " + i;
                spalte[i] = Convert.ToString(abfrage.ExecuteScalar());
            }

            //close the connection
            verbindung.Close();

            return spalte;
        }

        private double[] ErfrageDoubleSpalte(MySqlConnection verbindung, string spaltenname, int maxID)
        {
            double[] spalte = new double[maxID + 1];

            //open the connection
            verbindung.Open();

            MySqlCommand abfrage = new MySqlCommand();
            abfrage.Connection = verbindung;

            for (int i = 0; i <= maxID; i++)
            {
                abfrage.CommandText = "SELECT " + spaltenname + " FROM moebellager WHERE Id = " + i;
                spalte[i] = Convert.ToDouble(abfrage.ExecuteScalar());
            }

            //close the connection
            verbindung.Close();

            return spalte;
        }

        private static int ErfrageMaxID(MySqlConnection verbindung)
        {
            //open the connection
            verbindung.Open();

            MySqlCommand abfrage = new MySqlCommand();
            abfrage.Connection = verbindung;
            abfrage.CommandText = "SELECT MAX(id) FROM moebellager";
            int maxID = Convert.ToInt32(abfrage.ExecuteScalar());

            //close the connection
            verbindung.Close();

            return maxID;
        }

        private static MySqlConnection Verbinder()
        {
            //create a MySQL connection with a query string
            MySqlConnection verbindung = new MySqlConnection("server='localhost';database='gueter';userid='root';password=''");

            return verbindung;
        }

        private static char[] BestimmeKategorien(int[] wertkumulativ, int[] raenge, int aAnteil, int cAnteil)
        {
            cAnteil = wertkumulativ[raenge[raenge.Length-1]] - cAnteil;

            char[] kategorien = new char[wertkumulativ.Length];

            for (int i = 0; i < kategorien.Length; i++)
            {
                if (wertkumulativ[i] <= aAnteil)
                {
                    kategorien[i] = 'A';
                }
                else if (wertkumulativ[i] <= cAnteil)
                {
                    kategorien[i] = 'B';
                }
                else
                {
                    kategorien[i] = 'C';
                }
            }

            kategorien[raenge[0]] = 'A';

            return kategorien;
        }

        private static int[] KummuliereWerte(int[] wertprozent, int[] raenge)
        {
            int[] wertkumulativ = new int[wertprozent.Length];
            wertkumulativ[raenge[0]] = wertprozent[raenge[0]];

            for (int i = 1; i < wertkumulativ.Length; i++)
            {
                wertkumulativ[raenge[i]] = wertkumulativ[raenge[i-1]] + wertprozent[raenge[i]];
            }

            return wertkumulativ;
        }

        private static int[] ErrechneProzent(double[] werte)
        {
            var summe = ErrechneSumme(werte);
            int[] prozente = new int[werte.Length];

            for (int i = 0; i < werte.Length; i++)
            {
                prozente[i] = Convert.ToInt32(100 * werte[i] / summe);
            }

            return prozente;
        }

        private static double ErrechneSumme(double[] werte)
        {
            double summe = 0;
            foreach (var item in werte)
            {
                summe += item;
            }
            return summe;
        }

        private static int[] BestimmeRangfolge(double[] werte)
        {
            int[] raenge = new int[werte.Length];

            for (int i = 0; i < raenge.Length; i++)
            {
                raenge[i] = i;
            }

            double[] wertkopie = new double[werte.Length];
            Array.Copy(werte, wertkopie, werte.Length);
            Array.Sort(wertkopie, raenge);
            Array.Reverse(raenge);

            return raenge;
        }

        private static double[] ErrechneWerte(double[] mengen, double[] preise)
        {
            double[] werte = new double[mengen.Length];

            for (int i = 0; i < werte.Length; i++)
            {
                werte[i] = mengen[i] * preise[i];
            }

            return werte;
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            Hauptfunktion(trackBarA.Value, trackBarC.Value);
            trackBarA.Maximum = 100 - trackBarC.Value;
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            Hauptfunktion(trackBarA.Value, trackBarC.Value);
            trackBarC.Maximum = 100 - trackBarA.Value;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void buttonDruck_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings.Landscape = true;
                printDocument1.Print();
            }
        }

        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
    }
    //[TestFixture]
    //class testclass
    //{

    //    double[] mengen = { 180, 120, 450, 145, 300, 350 };
    //    double[] preise = { 110, 230, 15, 720, 15, 19 };
    //    double[] werte = { 19800, 27600, 6750, 104400, 4500, 6650 };
    //    int[] raenge = { 3, 1, 0, 2, 5, 4 };
    //    int[] mengenprozent = { 12, 8, 29, 9, 19, 23 };
    //    double gesamtmenge = 1545;
    //    int[] wertprozent = { 12, 16, 4, 62, 3, 4 };
    //    int[] wertkumulativ = { 90, 78, 94, 62, 101, 98 };
    //    char[] kategorien = { 'B', 'B', 'C', 'A', 'C', 'C' };

    //    [Test]
    //    public void TestErrechneWerte()
    //    {
    //        Assert.AreEqual(werte, Form1.ErrechneWerte(mengen, preise));
    //    }

    //    [Test]
    //    public void TestRangfolge()
    //    {
    //        Assert.AreEqual(raenge, Form1.BestimmeRangfolge(werte));
    //    }

    //    [Test]
    //    public void TestSumme()
    //    {
    //        Assert.AreEqual(gesamtmenge, Form1.ErrechneSumme(mengen));
    //    }

    //    [Test]
    //    public void TestProzente()
    //    {
    //        Assert.AreEqual(mengenprozent, Form1.ErrechneProzent(mengen));
    //        Assert.AreEqual(wertprozent, Form1.ErrechneProzent(werte));
    //    }

    //    [Test]
    //    public void TestKumulierteWerte()
    //    {
    //        Assert.AreEqual(wertkumulativ, Form1.KummuliereWerte(wertprozent, raenge));
    //    }

    //    [Test]
    //    public void TestKategorien()
    //    {
    //        Assert.AreEqual(kategorien, Form1.BestimmeKategorien(wertkumulativ, raenge));
    //    }
    //}
}
