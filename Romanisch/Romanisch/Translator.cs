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

        internal static string Adde_Mili(int mille)
        {
            string numerus_romanus = "";
            while (mille > 0)
            {
                numerus_romanus += "M";
                mille--;
            }
            return numerus_romanus;
        }

        internal static string Adde_Quingeno(string numerus_romanus, int quingeni)
        {
            while (quingeni > 0)
            {
                numerus_romanus += "D";
                quingeni--;
            }
            return numerus_romanus;
        }

        internal static string Adde_Centi(string numerus_romanus, int centum)
        {
            while (centum > 0)
            {
                numerus_romanus += "C";
                centum--;
            }
            return numerus_romanus;
        }

        internal static string Adde_Quinquaginto(string numerus_romanus, int quinquaginta)
        {
            while (quinquaginta > 0)
            {
                numerus_romanus += "L";
                quinquaginta--;
            }
            return numerus_romanus;
        }

        internal static string Adde_Deco(string numerus_romanus, int decem)
        {
            while (decem > 0)
            {
                numerus_romanus += "X";
                decem--;
            }
            return numerus_romanus;
        }

        internal static string Adde_Quinquo(string numerus_romanus, int quinque)
        {
            while (quinque > 0)
            {
                numerus_romanus += "V";
                quinque--;
            }
            return numerus_romanus;
        }

        internal static string Adde_Una(string numerus_romanus, int una)
        {
            while (una > 0)
            {
                numerus_romanus += "I";
                una--;
            }
            return numerus_romanus;
        }
    }
}
