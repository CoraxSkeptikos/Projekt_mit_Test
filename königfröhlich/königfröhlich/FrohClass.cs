using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace königfröhlich
{
    public class FrohClass
    {
        public static bool Start_Frohtester(int testzahl)
        {
            var ergebnis = Frohtester(testzahl);

            var ausgabe = Auswertung(ergebnis);
            return ausgabe;
        }

        internal static int Frohtester(int testzahl)
        {
            while (testzahl != 4 && testzahl != 1)
            {
                var ziffern = Liste_anlegen(testzahl);

                testzahl = Berechnung(ziffern);        
            }

            return testzahl;
        }

        internal static List<int> Liste_anlegen (int testzahl)
        {
            string zahlenstring = testzahl.ToString();
            List<int> ziffern = new List<int>();

            foreach (char ziffer in zahlenstring)
            {
                ziffern.Add((int)Char.GetNumericValue(ziffer));
            }

            return ziffern;
        }

        internal static int Berechnung (List<int> ziffern)
        {
            int testzahl = 0;
            foreach (int i in ziffern)
            {
                testzahl = testzahl + i * i;
            }
            return testzahl;
        }

        internal static bool Auswertung (int ergebnis)
        {
            bool wert;

            if (ergebnis == 1)
            {
                wert = true;
            }
            else
            {
                wert = false;
            }

            return wert;
        }
    }
}
