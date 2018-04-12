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

        internal static Dictionary<string, int> Congerere_Vocabularium(int[] compositio)
        {
            var vocabularium = new Dictionary<string, int>();

            vocabularium.Add("M", compositio[0]);
            vocabularium.Add("D", compositio[1]);
            vocabularium.Add("C", compositio[2]);
            vocabularium.Add("L", compositio[3]);
            vocabularium.Add("X", compositio[4]);
            vocabularium.Add("V", compositio[5]);
            vocabularium.Add("I", compositio[6]);

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
