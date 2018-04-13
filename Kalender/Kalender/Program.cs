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
            while (true)
            {
                if (Console.ReadLine().Contains("cal"))
                {
                    var datum = Definiere_Datum();
                    Schreibe_Kalender(datum);
                }
            }
        }
        internal static void Schreibe_Kalender(DateTime datum)
        {
            foreach (var item in Kalenderhintergrund.Starte_Kalender(datum))
            {
                Console.WriteLine(item);
            }
        }

        internal static DateTime Definiere_Datum()
        {
            DateTime datum = DateTime.Now;
            return datum;
        }
    }
}
