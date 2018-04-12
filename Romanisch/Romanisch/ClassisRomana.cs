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

            var quingeni = Translator.Divide(numerus_barbarus, 500);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 500);

            var centum = Translator.Divide(numerus_barbarus, 100);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 100);

            var quinquaginta = Translator.Divide(numerus_barbarus, 50);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 50);

            var decem = Translator.Divide(numerus_barbarus, 10);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 10);

            var quinque = Translator.Divide(numerus_barbarus, 5);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 5);

            var numerus_romanus = Translator.Adde_Mili(mille);
            numerus_romanus = Translator.Adde_Quingeno(numerus_romanus, quingeni);
            numerus_romanus = Translator.Adde_Centi(numerus_romanus, centum);
            numerus_romanus = Translator.Adde_Quinquaginto(numerus_romanus, quinquaginta);
            numerus_romanus = Translator.Adde_Deco(numerus_romanus, decem);
            numerus_romanus = Translator.Adde_Quinquo(numerus_romanus, quinque);
            numerus_romanus = Translator.Adde_Una(numerus_romanus, numerus_barbarus);

            return numerus_romanus;
        }
    }
}
