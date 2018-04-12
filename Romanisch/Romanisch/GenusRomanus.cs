using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanisch
{
    public class GenusRomanus
    {
        public static string Initium(int numerus_barbarus)
        {
            int[] compositio = new int[7];
            compositio[0] = Translator.Divide(numerus_barbarus, 1000);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 1000);

            compositio[1] = Translator.Divide(numerus_barbarus, 500);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 500);

            compositio[2] = Translator.Divide(numerus_barbarus, 100);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 100);

            compositio[3] = Translator.Divide(numerus_barbarus, 50);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 50);

            compositio[4] = Translator.Divide(numerus_barbarus, 10);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 10);

            compositio[5] = Translator.Divide(numerus_barbarus, 5);
            compositio[6] = Translator.Modulo(numerus_barbarus, 5);


            var vocabularium = Translator.Congerere_Vocabularium(compositio);
            var numerus_romanus = Translator.Congerere_Numerus_Romanus(vocabularium);

            numerus_romanus = Simplificator.Unicum(numerus_romanus);

            return numerus_romanus;
        }
    }
}
