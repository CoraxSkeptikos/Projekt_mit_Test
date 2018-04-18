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
            var datum = Definiere_Datum_Vorbereitung(eingabe);
            var wochentag = Definiere_Wochentag(eingabe);
            var kalenderblatt = Kalenderhintergrund.Starte_Kalender(datum, wochentag);
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

        internal static DateTime Definiere_Datum_Vorbereitung(string eingabe)
        {
            DateTime datum;
            try
            {
                var sub = Erstelle_Substring(eingabe);
                var monat = Monatsangabe(sub);
                var jahr = Jahresangabe(sub);
                datum = Definiere_Datum_Untergeordnete_Funktion(jahr, monat);
            }
            catch
            {
                datum = DateTime.Now;
            }
            return datum;
        }

        internal static string Erstelle_Substring(string eingabe)
        {
            string sub = eingabe.Substring(eingabe.IndexOf("cal") + 4);
            return sub;
        }

        internal static int Monatsangabe(string sub)
        {
            string monat = sub.Substring(0, sub.IndexOf(" "));
            return Convert.ToInt32(monat);
        }

        internal static int Jahresangabe(string sub)
        {
            string jahr = sub.Substring(sub.IndexOf(" ") + 1);
            if (jahr.Contains(" "))
            {
                jahr = jahr.Substring(0, jahr.IndexOf(" "));
            }
            return Convert.ToInt32(jahr);
        }

        internal static DateTime Definiere_Datum_Untergeordnete_Funktion(int jahr, int monat)
        {
            DateTime datum = new DateTime(Convert.ToInt32(jahr), Convert.ToInt32(monat), 1);
            return datum;
        }

        internal static string Definiere_Wochentag(string eingabe)
        {
            if (eingabe.Contains("Sonntag"))
            {
                return "Sonntag";
            }
            else if (eingabe.Contains("Samstag"))
            {
                return "Samstag";
            }
            else if (eingabe.Contains("Freitag"))
            {
                return "Freitag";
            }
            else
            {
                return "Montag";
            }
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
