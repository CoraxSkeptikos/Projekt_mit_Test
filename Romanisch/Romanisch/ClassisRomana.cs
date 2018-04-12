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
            var mille = Translator.Divide(numerus_barbarus, 1000);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 1000);
            var numerus_romanus = Translator.Adde_Mili(mille);

            var quingeni = Translator.Divide(numerus_barbarus, 500);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 500);
            numerus_romanus = Translator.Adde_Quingeno(numerus_romanus, quingeni);

            return numerus_romanus;
        }
    }
}
