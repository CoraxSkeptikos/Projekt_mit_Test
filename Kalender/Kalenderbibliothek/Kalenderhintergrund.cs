using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalenderbibliothek
{
    public class Kalenderhintergrund
    {
        public static string[] Starte_Kalender()
        {
            var ausgabe = new string[7];

            ausgabe[0] = Schreibe_Überschrift();
            ausgabe[1] = ("So Mo Di Mi Do Fr Sa");
            ausgabe[2] = (" 1  2  3  4  5  6  7");
            ausgabe[3] = (" 8  9 10 11 12 13 14");
            ausgabe[4] = ("15 16 17 18 19 20 21");
            ausgabe[5] = ("22 23 24 25 26 27 28");
            ausgabe[6] = ("29 30               ");

            return ausgabe;
        }

        internal static string Schreibe_Überschrift()
        {
            DateTime heute = DateTime.Now;
            string[] monate = { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "September", "Oktober", "November", "Dezember" };
            string überschrift = "     ";
            überschrift += monate[heute.Month - 1];
            überschrift += " ";
            überschrift += heute.Year;
            überschrift += "     ";
            return überschrift;
        }
    }
}
