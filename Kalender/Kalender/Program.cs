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
            Von_Vorne_Beginnen();
        }

        internal static void Von_Vorne_Beginnen()
        {
            string eingabe = Console.ReadLine();
            var befehl = Eingabeauswertung(eingabe);
            var datum = Definiere_Datum_Aus_Eingabe(eingabe);
            var erster_tag_der_woche = Definiere_Ersten_Tag_Der_Woche(eingabe);
            var kalenderblatt = Kalenderhintergrund.Starte_Kalender(datum, erster_tag_der_woche);
            Schreibe_Kalender(kalenderblatt, befehl);
            Schließen(befehl);
            Von_Vorne_Beginnen();
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

        internal static DateTime Definiere_Datum_Aus_Eingabe(string eingabe)
        {
            DateTime datum;
            try
            {
                datum = Versuche_Datum_Aus_Eingabe_Abzuleiten(eingabe);
            }
            catch
            {
                datum = DateTime.Now;
            }
            return datum;
        }

        internal static DateTime Versuche_Datum_Aus_Eingabe_Abzuleiten(string eingabe)
        {
            DateTime datum;
            var beschnittene_eingabe = Schneide_cal_Weg(eingabe);
            var eingegebener_monat = Lege_Die_Erste_Zahl_Als_Monat_Fest(beschnittene_eingabe);
            var eingegebenes_jahr = Lege_Die_Zweite_Zahl_Als_Jahr_Fest(beschnittene_eingabe);
            datum = Definiere_Datum_Mit_Hilfe_Der_Auswertung(eingegebenes_jahr, eingegebener_monat);
            return datum;
        }

        internal static string Schneide_cal_Weg(string eingabe)
        {
            string beschnittene_eingabe = eingabe.Substring(eingabe.IndexOf("cal") + 4);
            return beschnittene_eingabe;
        }

        internal static int Lege_Die_Erste_Zahl_Als_Monat_Fest(string beschnittene_eingabe)
        {
            string monat = beschnittene_eingabe.Substring(0, beschnittene_eingabe.IndexOf(" "));
            return Convert.ToInt32(monat);
        }

        internal static int Lege_Die_Zweite_Zahl_Als_Jahr_Fest(string beschnittene_eingabe)
        {
            string jahr = beschnittene_eingabe.Substring(beschnittene_eingabe.IndexOf(" ") + 1);
            jahr = Nach_Jahr_Rest_Abschneiden(jahr);
            return Convert.ToInt32(jahr);
        }

        internal static string Nach_Jahr_Rest_Abschneiden(string jahr)
        {
            if (jahr.Contains(" "))
            {
                jahr = jahr.Substring(0, jahr.IndexOf(" "));
            }
            return jahr;
        }

        internal static DateTime Definiere_Datum_Mit_Hilfe_Der_Auswertung(int jahr, int monat)
        {
            DateTime datum = new DateTime(Convert.ToInt32(jahr), Convert.ToInt32(monat), 1);
            return datum;
        }

        internal static string Definiere_Ersten_Tag_Der_Woche(string eingabe)
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
