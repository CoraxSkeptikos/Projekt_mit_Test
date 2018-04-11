using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    public class FizzBuzz
    {
        public static List<string> Start_FizzBuzz(int untergrenze, int obergrenze)
        {
            var dict = Wörterbuch_schreiben(untergrenze, obergrenze);
            var liste = Liste_anlegen(dict);
            return liste;
        }

        internal static Dictionary<int, string> Wörterbuch_schreiben(int untergrenze, int obergrenze)
        {
            var dict = new Dictionary<int, string>();
            for (int zahl = untergrenze; zahl <= obergrenze; zahl++)
            {
                if (zahl % 3 == 0 && zahl % 5 == 0)
                {
                    dict.Add(zahl, "FizzBuzz");
                }
                else if (zahl % 3 == 0)
                {
                    dict.Add(zahl, "Fizz");
                }
                else if (zahl % 5 == 0)
                {
                    dict.Add(zahl, "Buzz");
                }
                else
                {
                    dict.Add(zahl, zahl.ToString());
                }
            }
            return dict;
        }

        internal static List<string> Liste_anlegen(Dictionary<int, string> dict)
        {
            var ausgabe = new List<string>();
            foreach (KeyValuePair<int, string> item in dict)
            {
                ausgabe.Add(item.Value);
            }
            return ausgabe;
        }
    }
}
