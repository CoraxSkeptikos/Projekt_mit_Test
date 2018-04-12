using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanisch
{
    class Translator
    {
        internal static string Primum(int numerus_barbarus)
        {
            int mille = numerus_barbarus / 1000;
            numerus_barbarus -= mille;
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
