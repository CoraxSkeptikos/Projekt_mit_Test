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
            Startfunktion();
        }

        internal static void Startfunktion()
        {
            string eingabe = Console.ReadLine();
            var befehl = Eingabeauswertung(eingabe);
            var datum = Definiere_Datum();
            var kalenderblatt = Kalenderhintergrund.Starte_Kalender(datum);
            Schreibe_Kalender(kalenderblatt, befehl);
            Schließen(befehl);
            Startfunktion();
        }

        internal static string Eingabeauswertung(string eingabe)
        {
            if (eingabe.Contains("exit"))
            {
                return "exit";
            }
            else if (eingabe.Contains("cal"))
            {
                return "cal";
            }
            else
            {
                return "";
            }
        }

        internal static DateTime Definiere_Datum()
        {
            DateTime datum = DateTime.Now;
            return datum;
        }

        internal static void Schreibe_Kalender(string[] kalenderblatt, string befehl)
        {
            if (befehl == "cal")
            {
                foreach (var item in kalenderblatt)
                {
                    Console.WriteLine(item);
                }
            }
        }

        internal static void Schließen(string befehl)
        {
            if (befehl == "exit")
            {
                Environment.Exit(0);
            }
        }
    }
}
