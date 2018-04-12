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
            var expletium = Translator.Primum(numerus_barbarus);
            return expletium;
            
        }
    }
}
