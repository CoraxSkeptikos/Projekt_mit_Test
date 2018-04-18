using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalenderbibliothek
{
    public class Kalenderhintergrund
    {
        public static string[] Starte_Kalender(DateTime datum, string wochentag)
        {
            var monate = Erstelle_Monatsliste();

            var ausgabe = new string[8];

            ausgabe[0] = Schreibe_Überschrift(datum, monate);
            ausgabe[1] = Schreibe_Wochentage(wochentag);

            var tage = Schreibe_Erste_Zeile_Tage(datum, wochentag);
            ausgabe[2] = Array_Zu_String_zusammenführen(tage);

            tage = Schreibe_Zweite_Zeile_Tage(tage, datum);
            ausgabe[3] = Array_Zu_String_zusammenführen(tage);

            tage = Schreibe_Zweite_Zeile_Tage(tage, datum);
            ausgabe[4] = Array_Zu_String_zusammenführen(tage);

            tage = Schreibe_Zweite_Zeile_Tage(tage, datum);
            ausgabe[5] = Array_Zu_String_zusammenführen(tage);

            tage = Schreibe_Zweite_Zeile_Tage(tage, datum);
            ausgabe[6] = Array_Zu_String_zusammenführen(tage);

            tage = Schreibe_Zweite_Zeile_Tage(tage, datum);
            ausgabe[7] = Array_Zu_String_zusammenführen(tage);

            return ausgabe;
        }

        internal static string Schreibe_Überschrift(DateTime datum, string[] monate)
        {
            string überschrift = "     ";
            überschrift += monate[datum.Month - 1];
            überschrift += " ";
            überschrift += datum.Year;
            überschrift += "     ";
            return überschrift;
        }

        internal static string Schreibe_Wochentage(string starttag)
        {
            switch (starttag)
            {
                case "Freitag":
                    return "Fr Sa So Mo Di Mi Do";
                case "Samstag":
                    return "Sa So Mo Di Mi Do Fr";
                case "Sonntag":
                    return "So Mo Di Mi Do Fr Sa";
                case "Montag":
                default:
                    return "Mo Di Mi Do Fr Sa So";
            }
        }

        internal static string[] Erstelle_Monatsliste()
        {
            string[] monate = { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };
            return monate;
        }

        internal static string[] Schreibe_Erste_Zeile_Tage(DateTime datum, string starttag)
        {
            var tage = new string[7];

            var ersttag = new DateTime(datum.Year, datum.Month, 1);

            switch (starttag)
            {
                case "Montag":
                    switch (ersttag.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = "   ";
                            tage[5] = "   ";
                            tage[6] = " 1 ";
                            break;
                        case DayOfWeek.Monday:
                            tage[0] = " 1 ";
                            tage[1] = " 2 ";
                            tage[2] = " 3 ";
                            tage[3] = " 4 ";
                            tage[4] = " 5 ";
                            tage[5] = " 6 ";
                            tage[6] = " 7 ";
                            break;
                        case DayOfWeek.Tuesday:
                            tage[0] = "   ";
                            tage[1] = " 1 ";
                            tage[2] = " 2 ";
                            tage[3] = " 3 ";
                            tage[4] = " 4 ";
                            tage[5] = " 5 ";
                            tage[6] = " 6 ";
                            break;
                        case DayOfWeek.Wednesday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = " 1 ";
                            tage[3] = " 2 ";
                            tage[4] = " 3 ";
                            tage[5] = " 4 ";
                            tage[6] = " 5 ";
                            break;
                        case DayOfWeek.Thursday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = " 1 ";
                            tage[4] = " 2 ";
                            tage[5] = " 3 ";
                            tage[6] = " 4 ";
                            break;
                        case DayOfWeek.Friday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = " 1 ";
                            tage[5] = " 2 ";
                            tage[6] = " 3 ";
                            break;
                        case DayOfWeek.Saturday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = "   ";
                            tage[5] = " 1 ";
                            tage[6] = " 2 ";
                            break;
                        default:
                            break;
                    }
                    break;
                case "Freitag":
                    switch (ersttag.DayOfWeek)
                    {
                        case DayOfWeek.Friday:
                            tage[0] = " 1 ";
                            tage[1] = " 2 ";
                            tage[2] = " 3 ";
                            tage[3] = " 4 ";
                            tage[4] = " 5 ";
                            tage[5] = " 6 ";
                            tage[6] = " 7 ";
                            break;
                        case DayOfWeek.Saturday:
                            tage[0] = "   ";
                            tage[1] = " 1 ";
                            tage[2] = " 2 ";
                            tage[3] = " 3 ";
                            tage[4] = " 4 ";
                            tage[5] = " 5 ";
                            tage[6] = " 6 ";
                            break;
                        case DayOfWeek.Sunday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = " 1 ";
                            tage[3] = " 2 ";
                            tage[4] = " 3 ";
                            tage[5] = " 4 ";
                            tage[6] = " 5 ";
                            break;
                        case DayOfWeek.Monday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = " 1 ";
                            tage[4] = " 2 ";
                            tage[5] = " 3 ";
                            tage[6] = " 4 ";
                            break;
                        case DayOfWeek.Tuesday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = " 1 ";
                            tage[5] = " 2 ";
                            tage[6] = " 3 ";
                            break;
                        case DayOfWeek.Wednesday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = "   ";
                            tage[5] = " 1 ";
                            tage[6] = " 2 ";
                            break;
                        case DayOfWeek.Thursday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = "   ";
                            tage[5] = "   ";
                            tage[6] = " 1 ";
                            break;
                        default:
                            break;
                    }
                    break;
                case "Samstag":
                    switch (ersttag.DayOfWeek)
                    {
                        case DayOfWeek.Saturday:
                            tage[0] = " 1 ";
                            tage[1] = " 2 ";
                            tage[2] = " 3 ";
                            tage[3] = " 4 ";
                            tage[4] = " 5 ";
                            tage[5] = " 6 ";
                            tage[6] = " 7 ";
                            break;
                        case DayOfWeek.Sunday:
                            tage[0] = "   ";
                            tage[1] = " 1 ";
                            tage[2] = " 2 ";
                            tage[3] = " 3 ";
                            tage[4] = " 4 ";
                            tage[5] = " 5 ";
                            tage[6] = " 6 ";
                            break;
                        case DayOfWeek.Monday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = " 1 ";
                            tage[3] = " 2 ";
                            tage[4] = " 3 ";
                            tage[5] = " 4 ";
                            tage[6] = " 5 ";
                            break;
                        case DayOfWeek.Tuesday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = " 1 ";
                            tage[4] = " 2 ";
                            tage[5] = " 3 ";
                            tage[6] = " 4 ";
                            break;
                        case DayOfWeek.Wednesday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = " 1 ";
                            tage[5] = " 2 ";
                            tage[6] = " 3 ";
                            break;
                        case DayOfWeek.Thursday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = "   ";
                            tage[5] = " 1 ";
                            tage[6] = " 2 ";
                            break;
                        case DayOfWeek.Friday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = "   ";
                            tage[5] = "   ";
                            tage[6] = " 1 ";
                            break;
                        default:
                            break;
                    }
                    break;
                case "Sonntag":
                    switch (ersttag.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            tage[0] = " 1 ";
                            tage[1] = " 2 ";
                            tage[2] = " 3 ";
                            tage[3] = " 4 ";
                            tage[4] = " 5 ";
                            tage[5] = " 6 ";
                            tage[6] = " 7 ";
                            break;
                        case DayOfWeek.Monday:
                            tage[0] = "   ";
                            tage[1] = " 1 ";
                            tage[2] = " 2 ";
                            tage[3] = " 3 ";
                            tage[4] = " 4 ";
                            tage[5] = " 5 ";
                            tage[6] = " 6 ";
                            break;
                        case DayOfWeek.Tuesday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = " 1 ";
                            tage[3] = " 2 ";
                            tage[4] = " 3 ";
                            tage[5] = " 4 ";
                            tage[6] = " 5 ";
                            break;
                        case DayOfWeek.Wednesday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = " 1 ";
                            tage[4] = " 2 ";
                            tage[5] = " 3 ";
                            tage[6] = " 4 ";
                            break;
                        case DayOfWeek.Thursday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = " 1 ";
                            tage[5] = " 2 ";
                            tage[6] = " 3 ";
                            break;
                        case DayOfWeek.Friday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = "   ";
                            tage[5] = " 1 ";
                            tage[6] = " 2 ";
                            break;
                        case DayOfWeek.Saturday:
                            tage[0] = "   ";
                            tage[1] = "   ";
                            tage[2] = "   ";
                            tage[3] = "   ";
                            tage[4] = "   ";
                            tage[5] = "   ";
                            tage[6] = " 1 ";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
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

        internal static string [] Schreibe_Zweite_Zeile_Tage(string[] tage, DateTime datum)
        {
            try
            {
                int letztertag = Convert.ToInt32(tage[6].Trim());

                for (int i = 0; i < tage.Length; i++)
                {
                    letztertag++;
                    if (letztertag < 10)
                    {
                        tage[i] = " ";
                    }
                    else
                    {
                        tage[i] = "";
                    }
                    if (letztertag <= DateTime.DaysInMonth(datum.Year, datum.Month))
                    {
                        tage[i] += Convert.ToString(letztertag);
                    }
                    else
                    {
                        tage[i] += "  ";
                    }
                    tage[i] += " ";
                }
            }
            catch
            {
                for (int i = 0; i < tage.Length; i++)
                {
                    tage[i] = "   ";
                }
            }

            return tage;
        }
    }
}
