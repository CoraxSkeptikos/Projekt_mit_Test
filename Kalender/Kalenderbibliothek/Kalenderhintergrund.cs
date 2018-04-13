using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalenderbibliothek
{
    public class Kalenderhintergrund
    {
        public static List<string> Starte_Kalender()
        {
            var ausgabe = new List<string>();

            ausgabe.Add("     April 2018     ");
            ausgabe.Add("So Mo Di Mi Do Fr Sa");
            ausgabe.Add(" 1  2  3  4  5  6  7");
            ausgabe.Add(" 8  9 10 11 12 13 14");
            ausgabe.Add("15 16 17 18 19 20 21");
            ausgabe.Add("22 23 24 25 26 27 28");
            ausgabe.Add("29 30               ");

            return ausgabe;
        }
    }
}
