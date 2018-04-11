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
            var aufruf = Frohtester(testzahl);
            return aufruf;
        }

        internal static bool Frohtester(int testzahl)
        {
            while (testzahl != 4 && testzahl != 1)
            {
                string zahlenstring = testzahl.ToString();
                List<int> ziffern = new List<int>();
                testzahl = 0;

                foreach (char ziffer in zahlenstring)
                {
                    ziffern.Add((int)Char.GetNumericValue(ziffer));
                }

                foreach (int i in ziffern)
                {
                    testzahl = testzahl + i * i;
                }
            }

            bool wert;

            if (testzahl == 1)
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
