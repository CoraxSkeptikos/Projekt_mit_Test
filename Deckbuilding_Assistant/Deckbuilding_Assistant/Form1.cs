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

        public static double BerechneHypergeometrischeVerteilung(int N, int K, int n, int k)
        {
            double H = 0;

            H = (BerechneBinomialkoeffizient(K, k) * BerechneBinomialkoeffizient(N - K, n - k)) / BerechneBinomialkoeffizient(N, n);

            return H;
        }

        private static int BerechneBinomialkoeffizient(int n, int k)
        {
            int ergebnis = 0;

            ergebnis = BerechneFakultaet(n) / (BerechneFakultaet(k) * BerechneFakultaet(n - k));

            return ergebnis;
        }

        private static int BerechneFakultaet(int n)
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
    [TestFixture]
    class testklasse
    {
        [Test]
        public void TesteHypergeometrischeVerteilung()
        {
            Assert.AreEqual(0.29, Math.Round(Form1.BerechneHypergeometrischeVerteilung(60, 20, 8, 2), 2));
        }
    }
}
