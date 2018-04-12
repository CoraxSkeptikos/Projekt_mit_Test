﻿using System;
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
    }
}
