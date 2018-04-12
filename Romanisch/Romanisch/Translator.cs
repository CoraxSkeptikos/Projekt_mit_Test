using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanisch
{
    class Translator
    {
        internal static int Divide(int numerus_barbarus, int divisor)
        {
            int quotient = numerus_barbarus / divisor;
            return quotient;
        }

        internal static int Modulo(int numerus_barbarus, int divisor)
        {
            numerus_barbarus %= divisor;
            return numerus_barbarus;
        }

        internal static Dictionary<string, int> Congerere_Vocabularium(int[] spacium)
        {
            var vocabularium = new Dictionary<string, int>();

            vocabularium.Add("M", spacium[0]);
            vocabularium.Add("D", spacium[1]);
            vocabularium.Add("C", spacium[2]);
            vocabularium.Add("L", spacium[3]);
            vocabularium.Add("X", spacium[4]);
            vocabularium.Add("V", spacium[5]);
            vocabularium.Add("I", spacium[6]);

            return vocabularium;
        }

        internal static string Congerere_Numerus_Romanus(Dictionary<string, int> vocabularium)
        {
            string numerus_romanus = "";
            foreach (KeyValuePair<string, int> res in vocabularium)
            {
                int iteratio = res.Value;
                while (iteratio > 0)
                {
                    numerus_romanus += res.Key;
                    iteratio--;
                }
            }

            return numerus_romanus;
        }

    }
}
