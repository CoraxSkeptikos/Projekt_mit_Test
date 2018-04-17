using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalenderbibliothek;

namespace Kalender
{
    class Program
    {
        static void Main(string[] args)
        {
            Funktionsname();
        }

        internal static void Funktionsname()
        {
            var eingabe = Eingabeauswertung();
            var datum = Definiere_Datum();
            Schreibe_Kalender(datum, eingabe);
            Funktionsname();
        }

        internal static void Schreibe_Kalender(DateTime datum, string eingabe)
        {
            if (eingabe == "cal")
            {
                foreach (var item in Kalenderhintergrund.Starte_Kalender(datum))
                {
                    Console.WriteLine(item);
                }
            }
        }

        internal static DateTime Definiere_Datum()
        {
            DateTime datum = DateTime.Now;
            return datum;
        }

        internal static string Eingabeauswertung()
        {
            string eingabe;
            while (true)
            {
                eingabe = Console.ReadLine();
                if (eingabe.Contains("exit"))
                {
                    return "exit";
                }
                else if (eingabe.Contains("cal"))
                {
                    return "cal";
                }
            }
        }
    }
}
