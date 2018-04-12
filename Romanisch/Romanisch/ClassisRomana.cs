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
            int[] spacium = new int[7];
            spacium[0] = Translator.Divide(numerus_barbarus, 1000);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 1000);

            spacium[1] = Translator.Divide(numerus_barbarus, 500);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 500);

            spacium[2] = Translator.Divide(numerus_barbarus, 100);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 100);

            spacium[3] = Translator.Divide(numerus_barbarus, 50);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 50);

            spacium[4] = Translator.Divide(numerus_barbarus, 10);
            numerus_barbarus = Translator.Modulo(numerus_barbarus, 10);

            spacium[5] = Translator.Divide(numerus_barbarus, 5);
            spacium[6] = Translator.Modulo(numerus_barbarus, 5);


            var vocabularium = Translator.Congerere_Vocabularium(spacium);
            var numerus_romanus = Translator.Congerere_Numerus_Romanus(vocabularium);

            numerus_romanus = Simplificator.Unicum(numerus_romanus);

            return numerus_romanus;
        }
    }
}
