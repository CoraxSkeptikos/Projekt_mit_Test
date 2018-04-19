using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalenderbibliothek
{
    public class Kalenderhintergrund
    {
        public static string[] Starte_Kalender(DateTime datum, int erster_tag_der_woche)
        {
            var monate = Erstelle_Monatsarray();

            var ausgabe = Erstelle_Ausgabe(datum, monate, erster_tag_der_woche);

            return ausgabe;
        }

        internal static string[] Erstelle_Monatsarray()
        {
            string[] monate = { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };
            return monate;
        }

        internal static string[] Erstelle_Ausgabe(DateTime datum, string[] monate, int erster_tag_der_woche)
        {
            var ausgabe = new string[8];

            ausgabe[0] = Erstelle_Überschrift(datum, monate);
            ausgabe[1] = Erstelle_Wochentagszeile(erster_tag_der_woche);

            var tage = Erstelle_Erste_Zeile_Tage(datum, erster_tag_der_woche);
            ausgabe[2] = Array_Zu_String_zusammenführen(tage);

            ausgabe = Erstelle_Weitere_Zeilen(tage, datum, ausgabe);

            return ausgabe;
        }

        internal static string Erstelle_Überschrift(DateTime datum, string[] monate)
        {
            string überschrift = "     ";
            überschrift += monate[datum.Month - 1];
            überschrift += " ";
            überschrift += datum.Year;
            überschrift += "     ";
            return überschrift;
        }

        internal static string Erstelle_Wochentagszeile(int erster_tag_der_woche)
        {
            switch (erster_tag_der_woche)
            {
                case 5:
                    return "Fr Sa So Mo Di Mi Do";
                case 6:
                    return "Sa So Mo Di Mi Do Fr";
                case 7:
                    return "So Mo Di Mi Do Fr Sa";
                case 1:
                default:
                    return "Mo Di Mi Do Fr Sa So";
            }
        }

        internal static string[] Erstelle_Erste_Zeile_Tage(DateTime datum, int erster_tag_der_woche)
        {
            var tage = Erstelle_Tagesarray();

            var erster_tag_des_monats = Ermittle_Ersten_Tag_Des_Monats(datum);

            tage = Erstelle_Erste_Zeile_Tage_Nach_Wochenformat(tage, erster_tag_des_monats, erster_tag_der_woche);

            return tage;
        }

        internal static string[] Erstelle_Tagesarray()
        {
            var tage = new string[7];
            return tage;
        }

        internal static DateTime Ermittle_Ersten_Tag_Des_Monats(DateTime datum)
        {
            var erster_tag_des_monats = new DateTime(datum.Year, datum.Month, 1);
            return erster_tag_des_monats;
        }

        internal static string[] Erstelle_Erste_Zeile_Tage_Nach_Wochenformat(string[] tage, DateTime erster_tag_des_monats, int erster_tag_der_woche)
        {
            var wochentag_des_ersten_tages_des_monats = Ermittle_Wochentag_Des_Ersten_Tages_Des_Monats(erster_tag_des_monats);

            tage = Beginne_Am_Ersten_Tag_Der_Woche(tage, erster_tag_der_woche, wochentag_des_ersten_tages_des_monats);
            tage = Beginne_Am_Zweiten_Tag_Der_Woche(tage, erster_tag_der_woche, wochentag_des_ersten_tages_des_monats);
            tage = Beginne_Am_Dritten_Tag_Der_Woche(tage, erster_tag_der_woche, wochentag_des_ersten_tages_des_monats);
            tage = Beginne_Am_Vierten_Tag_Der_Woche(tage, erster_tag_der_woche, wochentag_des_ersten_tages_des_monats);
            tage = Beginne_Am_Fünften_Tag_Der_Woche(tage, erster_tag_der_woche, wochentag_des_ersten_tages_des_monats);
            tage = Beginne_Am_Sechsten_Tag_Der_Woche(tage, erster_tag_der_woche, wochentag_des_ersten_tages_des_monats);
            tage = Beginne_Am_Siebten_Tag_Der_Woche(tage, erster_tag_der_woche, wochentag_des_ersten_tages_des_monats);

            return tage;
        }

        internal static int Ermittle_Wochentag_Des_Ersten_Tages_Des_Monats(DateTime erster_tag_des_monats)
        {
            switch (erster_tag_des_monats.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return 7;
                case DayOfWeek.Monday:
                    return 1;
                case DayOfWeek.Tuesday:
                    return 2;
                case DayOfWeek.Wednesday:
                    return 3;
                case DayOfWeek.Thursday:
                    return 4;
                case DayOfWeek.Friday:
                    return 5;
                case DayOfWeek.Saturday:
                    return 6;
                default:
                    throw new Exception("Fehler beim Ermitteln des Wochentages des ersten Tages des Monats.");
            }
        }

        internal static string[] Beginne_Am_Ersten_Tag_Der_Woche(string[] tage, int erster_tag_der_woche, int wochentag_des_ersten_tages_des_monats)
        {
            if (wochentag_des_ersten_tages_des_monats == erster_tag_der_woche)
            {
                tage[0] = " 1 ";
                tage[1] = " 2 ";
                tage[2] = " 3 ";
                tage[3] = " 4 ";
                tage[4] = " 5 ";
                tage[5] = " 6 ";
                tage[6] = " 7 ";
            }
            return tage;
        }

        internal static string[] Beginne_Am_Zweiten_Tag_Der_Woche(string[] tage, int erster_tag_der_woche, int wochentag_des_ersten_tages_des_monats)
        {
            var vergleichswert = Vergleichswert_Errechnen(erster_tag_der_woche, 1);
            if (wochentag_des_ersten_tages_des_monats == vergleichswert)
            {
                tage[0] = "   ";
                tage[1] = " 1 ";
                tage[2] = " 2 ";
                tage[3] = " 3 ";
                tage[4] = " 4 ";
                tage[5] = " 5 ";
                tage[6] = " 6 ";
            }
            return tage;
        }

        internal static int Vergleichswert_Errechnen(int erster_tag_der_woche, int summand)
        {
            var vergleichswert = erster_tag_der_woche + summand;
            if (vergleichswert > 7)
            {
                vergleichswert %= 7;
            }
            return vergleichswert;
        }

        internal static string[] Beginne_Am_Dritten_Tag_Der_Woche(string[] tage, int erster_tag_der_woche, int wochentag_des_ersten_tages_des_monats)
        {
            var vergleichswert = Vergleichswert_Errechnen(erster_tag_der_woche, 2);
            if (wochentag_des_ersten_tages_des_monats == vergleichswert)
            {
                tage[0] = "   ";
                tage[1] = "   ";
                tage[2] = " 1 ";
                tage[3] = " 2 ";
                tage[4] = " 3 ";
                tage[5] = " 4 ";
                tage[6] = " 5 ";
            }
            return tage;
        }

        internal static string[] Beginne_Am_Vierten_Tag_Der_Woche(string[] tage, int erster_tag_der_woche, int wochentag_des_ersten_tages_des_monats)
        {
            var vergleichswert = Vergleichswert_Errechnen(erster_tag_der_woche, 3);
            if (wochentag_des_ersten_tages_des_monats == vergleichswert)
            {
                tage[0] = "   ";
                tage[1] = "   ";
                tage[2] = "   ";
                tage[3] = " 1 ";
                tage[4] = " 2 ";
                tage[5] = " 3 ";
                tage[6] = " 4 ";
            }
            return tage;
        }

        internal static string[] Beginne_Am_Fünften_Tag_Der_Woche(string[] tage, int erster_tag_der_woche, int wochentag_des_ersten_tages_des_monats)
        {
            var vergleichswert = Vergleichswert_Errechnen(erster_tag_der_woche, 4);
            if (wochentag_des_ersten_tages_des_monats == vergleichswert)
            {
                tage[0] = "   ";
                tage[1] = "   ";
                tage[2] = "   ";
                tage[3] = "   ";
                tage[4] = " 1 ";
                tage[5] = " 2 ";
                tage[6] = " 3 ";
            }
            return tage;
        }

        internal static string[] Beginne_Am_Sechsten_Tag_Der_Woche(string[] tage, int erster_tag_der_woche, int wochentag_des_ersten_tages_des_monats)
        {
            var vergleichswert = Vergleichswert_Errechnen(erster_tag_der_woche, 5);
            if (wochentag_des_ersten_tages_des_monats == vergleichswert)
            {
                tage[0] = "   ";
                tage[1] = "   ";
                tage[2] = "   ";
                tage[3] = "   ";
                tage[4] = "   ";
                tage[5] = " 1 ";
                tage[6] = " 2 ";
            }
            return tage;
        }

        internal static string[] Beginne_Am_Siebten_Tag_Der_Woche(string[] tage, int erster_tag_der_woche, int wochentag_des_ersten_tages_des_monats)
        {
            var vergleichswert = Vergleichswert_Errechnen(erster_tag_der_woche, 6);
            if (wochentag_des_ersten_tages_des_monats == vergleichswert)
            {
                tage[0] = "   ";
                tage[1] = "   ";
                tage[2] = "   ";
                tage[3] = "   ";
                tage[4] = "   ";
                tage[5] = "   ";
                tage[6] = " 1 ";
            }
            return tage;
        }

        internal static string Array_Zu_String_zusammenführen(string[] tage)
        {
            string zeile = "";
            foreach (var item in tage)
            {
                zeile += item;
            }
            return zeile;
        }

        internal static string[] Erstelle_Weitere_Zeilen(string[] tage, DateTime datum, string[] ausgabe)
        {
            int letztertag;
            var monatsende = Monatsende_Als_Zahl_Ausgeben(datum);
            for (int i = 3; i < ausgabe.Length; i++)
            {
                letztertag = Formatiere_Den_Letzten_Erfassten_Tag_Wieder_Als_Zahl(tage[6]);
                tage = Erstelle_Zeile(tage, datum, letztertag, monatsende);
                ausgabe[i] = Array_Zu_String_zusammenführen(tage);
            }

            return ausgabe;
        }

        internal static string[] Erstelle_Zeile(string[] tage, DateTime datum, int tag, int monatsende)
        {
            for (int i = 0; i < tage.Length; i++)
            {
                tag ++;
                tage[i] = Führendes_Leerzeichen_Anfügen_Wo_Benötigt(tag);
                tage[i] += Tageszahl_Anfügen_Wenn_Monatsende_Nicht_Erreicht(tag, monatsende);
                tage[i] += " ";
            }

            return tage;
        }

        internal static int Formatiere_Den_Letzten_Erfassten_Tag_Wieder_Als_Zahl(string letzter_erfasster_tag)
        {
            try
            {
                return Convert.ToInt32(letzter_erfasster_tag.Trim());
            }
            catch (Exception)
            {
                return 32;
            }
        }

        internal static string Führendes_Leerzeichen_Anfügen_Wo_Benötigt(int tag)
        {
            string stelle = "";
            if (tag < 10)
            {
                stelle = " ";
            }
            return stelle;
        }

        internal static int Monatsende_Als_Zahl_Ausgeben(DateTime datum)
        {
            return DateTime.DaysInMonth(datum.Year, datum.Month);
        }

        internal static string Tageszahl_Anfügen_Wenn_Monatsende_Nicht_Erreicht(int tag, int monatsende)
        {
            if (tag <= monatsende)
            {
                return Convert.ToString(tag);
            }
            else
            {
                return "  ";
            }
        }
    }
}
