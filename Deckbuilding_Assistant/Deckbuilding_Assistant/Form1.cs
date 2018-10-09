﻿using NUnit.Framework;
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

        public static double BerechneBinomialkoeffizient(int n, int k)
        {
            double ergebnis = 1;
            double schrittA = 0;
            double schrittB = 0;
            double schrittC = 0;

            for (int i = 1; i <= k; i++)
            {
                schrittA = i - 1;
                schrittB = n - schrittA;
                schrittC = schrittB / i;
                ergebnis = ergebnis * schrittC;
            }

            return ergebnis;
        }
    }
    [TestFixture]
    class Testklasse
    {
        [Test]
        public void TesteBinomialkoeffizient()
        {
            Assert.AreEqual(0, Form1.BerechneBinomialkoeffizient(3, 92));
            Assert.AreEqual(1, Form1.BerechneBinomialkoeffizient(32, 0));
            Assert.AreEqual(50, Form1.BerechneBinomialkoeffizient(50, 1));
            Assert.AreEqual(1225, Form1.BerechneBinomialkoeffizient(50, 2));
            Assert.AreEqual(19600, Form1.BerechneBinomialkoeffizient(50, 3));
        }

        [Test]
        public void TesteHypergeometrischeVerteilung()
        {
            Assert.AreEqual(0.29, Math.Round(Form1.BerechneHypergeometrischeVerteilung(60, 20, 8, 2), 2));
        }
    }
}