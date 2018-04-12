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

        internal static int Subtrahe(int numerus_barbarus, int subtrahend)
        {
            numerus_barbarus -= subtrahend;
            return numerus_barbarus;
        }

        internal static string Adde_Milli(int mille)
        {
            string numerus_romanus = "";
            while (mille > 0)
            {
                numerus_romanus += "M";
                mille--;
            }
            return numerus_romanus;
        }
    }
}
