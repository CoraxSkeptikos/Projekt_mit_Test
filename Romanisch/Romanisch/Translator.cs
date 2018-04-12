using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanisch
{
    class Translator
    {
        internal static int Divide_Mili(int numerus_barbarus)
        {
            int mille = numerus_barbarus / 1000;
            return mille;
        }

        internal static int Modulo_Mili(int numerus_barbarus)
        {
            numerus_barbarus %= 1000;
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



        internal static int Divide_Quingeno(int numerus_barbarus)
        {
            int quingeni = numerus_barbarus / 500;
            return quingeni;
        }

        internal static int Modulo_Quingeni(int numerus_barbarus)
        {
            numerus_barbarus %= 500;
            return numerus_barbarus;
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
    }
}
