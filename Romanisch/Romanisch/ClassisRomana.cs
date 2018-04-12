using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanisch
{
    public class ClassisRomana
    {
        public static string Initium(int numerus_barbarus)
        {
            var mille = Translator.Divide_Mili(numerus_barbarus);
            numerus_barbarus = Translator.Subtrahe(numerus_barbarus, mille);
            var numerus_romanus = Translator.Adde_Milli(mille);
            return numerus_romanus;
            
        }
    }
}
