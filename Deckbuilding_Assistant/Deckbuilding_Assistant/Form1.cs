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
            try
            {
                int bibliotheksgroesze = Convert.ToInt32(TBbibliothek.Text);
                bibliotheksgroesze--;
                int anzahlLaender = Convert.ToInt32(TBlaender.Text);
                int cmc = Convert.ToInt32(TBcmc.Text);

                if (!FangeEingabefehlerAb(bibliotheksgroesze, anzahlLaender, cmc))
                {
                    int groeszeStichprobe = cmc + 5;

                    var wahrscheinlichkeit = BerechneKumulativeVerteilung(bibliotheksgroesze, anzahlLaender, groeszeStichprobe, cmc);

                    wahrscheinlichkeit = wahrscheinlichkeit * 100;
                    wahrscheinlichkeit = Math.Round(wahrscheinlichkeit, 2);

                    TBwahrscheinlichkeit.Text = wahrscheinlichkeit.ToString() + "%";
                    LBLmanakostenwert.Text = cmc.ToString();
                    if (cmc == 0)
                    {
                        LBLrundewert.Text = "1";
                    }
                    else
                    {
                        LBLrundewert.Text = cmc.ToString();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte nur ganze Zahlen eingeben!");
                LeereTextboxen();
            }
        }

        private bool FangeEingabefehlerAb(int bibliotheksgroesze, int anzahlLaender, int cmc)
        {
            if (bibliotheksgroesze < 0 || anzahlLaender < 0 || cmc < 0)
            {
                MessageBox.Show("Bitte keine negativen Zahlen eingeben!");
                LeereTextboxen();
                return true;
            }
            else if (anzahlLaender > bibliotheksgroesze || cmc > anzahlLaender)
            {
                MessageBox.Show("Etwas scheint nicht zu stimmen. Bitte überprüfe deine Angaben!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LeereTextboxen()
        {
            TBbibliothek.Clear();
            TBcmc.Clear();
            TBlaender.Clear();
        }

        private static double BerechneKumulativeVerteilung(int gesamtmenge, int erfolgeGesamt, int groeszeStichprobe, int erfolgeAngestrebt)
        {
            double verteilung = 0;
            while (erfolgeAngestrebt <= groeszeStichprobe && erfolgeAngestrebt <= erfolgeGesamt)
            {
                verteilung += BerechneHypergeometrischeVerteilung(gesamtmenge, erfolgeGesamt, groeszeStichprobe, erfolgeAngestrebt);
                erfolgeAngestrebt++;
            }
            return verteilung;
        }

        private static double BerechneHypergeometrischeVerteilung(int gesamtmenge, int erfolgeGesamt, int groeszeStichprobe, int erfolgeAngestrebt)
        {
            int misserfolgeGesamt = gesamtmenge - erfolgeGesamt;
            int erlaubteMisserfolge = groeszeStichprobe - erfolgeAngestrebt;
            double schrittC = BerechneBinomialkoeffizient(misserfolgeGesamt, erlaubteMisserfolge);
            double schrittD = BerechneBinomialkoeffizient(erfolgeGesamt, erfolgeAngestrebt);
            double schrittE = schrittC * schrittD;
            double schrittF = BerechneBinomialkoeffizient(gesamtmenge, groeszeStichprobe);
            double verteilung = schrittE / schrittF;
            return verteilung;
        }

        private static double BerechneBinomialkoeffizient(int n, int k)
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
        //[Test]
        //public void TesteBinomialkoeffizient()
        //{
        //    Assert.AreEqual(0, Form1.BerechneBinomialkoeffizient(3, 92));
        //    Assert.AreEqual(1, Form1.BerechneBinomialkoeffizient(32, 0));
        //    Assert.AreEqual(50, Form1.BerechneBinomialkoeffizient(50, 1));
        //    Assert.AreEqual(1225, Form1.BerechneBinomialkoeffizient(50, 2));
        //    Assert.AreEqual(19600, Form1.BerechneBinomialkoeffizient(50, 3));
        //}

        //[Test]
        //public void TesteHypergeometrischeVerteilung()
        //{
        //    Assert.AreEqual(0.285033, Math.Round(Form1.BerechneHypergeometrischeVerteilung(60, 20, 8, 2), 6));
        //    Assert.AreEqual(0.235767, Math.Round(Form1.BerechneHypergeometrischeVerteilung(99, 30, 7, 3), 6));
        //    Assert.AreEqual(0.417901, Math.Round(Form1.BerechneHypergeometrischeVerteilung(40, 4, 7, 1), 6));
        //}

        //[Test]
        //public void TesteKumulativeVerteilung()
        //{
        //    Assert.AreEqual(0.824212, Math.Round(Form1.BerechneKumulativeVerteilung(60, 20, 8, 2), 6));
        //    Assert.AreEqual(0.357563, Math.Round(Form1.BerechneKumulativeVerteilung(99, 30, 7, 3), 6));
        //    Assert.AreEqual(0.552249, Math.Round(Form1.BerechneKumulativeVerteilung(40, 4, 7, 1), 6));
        //}
    }
}