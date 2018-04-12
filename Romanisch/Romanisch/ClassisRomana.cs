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
            numerus_barbarus = Translator.Modulo_Mili(numerus_barbarus);
            var numerus_romanus = Translator.Adde_Mili(mille);

            var quingeni = Translator.Divide_Quingeno(numerus_barbarus);
            numerus_barbarus = Translator.Modulo_Quingeni(numerus_barbarus);
            numerus_romanus = Translator.Adde_Quingeno(numerus_romanus, quingeni);

            return numerus_romanus;
        }
    }
}
