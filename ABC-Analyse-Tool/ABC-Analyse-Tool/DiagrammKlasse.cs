using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ABC_Analyse_Tool
{
    class DiagrammKlasse
    {
        private static void DiagrammErstellen(char[] kategorien, int[] mengenprozent, Chart chart1)
        {
            chart1.Series["Mengenanteile"].Points.Clear();
            chart1.Series["Mengenanteile"].Points.AddXY("A", MengenanteilBerechnen(kategorien, mengenprozent, 'A'));
            chart1.Series["Mengenanteile"].Points.AddXY("B", MengenanteilBerechnen(kategorien, mengenprozent, 'B'));
            chart1.Series["Mengenanteile"].Points.AddXY("C", MengenanteilBerechnen(kategorien, mengenprozent, 'C'));
            chart1.Series["Mengenanteile"].Points[0].Color = Color.Tomato;
            chart1.Series["Mengenanteile"].Points[1].Color = Color.Khaki;
            chart1.Series["Mengenanteile"].Points[2].Color = Color.SkyBlue;
        }

        private static int MengenanteilBerechnen(char[] kategorien, int[] mengenprozent, char kategorie)
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
    }
}
