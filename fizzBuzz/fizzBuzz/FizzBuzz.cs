using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    public class FizzBuzz
    {
        public static Dictionary<int, string> Start_FizzBuzz(int untergrenze, int obergrenze)
        {
            var aufruf = Wörterbuch(untergrenze, obergrenze);
            return aufruf;
        }

        internal static Dictionary<int, string> Wörterbuch(int untergrenze, int obergrenze)
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
    }
}
