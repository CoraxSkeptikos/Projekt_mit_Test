using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deckbuilding_Assistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTberechnen_Click(object sender, EventArgs e)
        {

        }

        private double BerechneHypergeometrischeVerteilung(int N, int K, int n, int k)
        {
            double H = 0;

            H = (BerechneBinomialkoeffizient(K, k) * BerechneBinomialkoeffizient(N - K, n - k)) / BerechneBinomialkoeffizient(N, n);

            return H;
        }

        private int BerechneBinomialkoeffizient(int n, int k)
        {
            int ergebnis = 0;

            ergebnis = BerechneFakultaet(n) / (BerechneFakultaet(k) * BerechneFakultaet(n - k));

            return ergebnis;
        }

        private int BerechneFakultaet(int n)
        {
            int ergebnis = 1;

            while (n != 1)
            {
                ergebnis = ergebnis * n;
                n--;
            }

            return ergebnis;
        }
    }
}
