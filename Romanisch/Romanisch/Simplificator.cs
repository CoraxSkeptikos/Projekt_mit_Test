using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanisch
{
    class Simplificator
    {
        internal static string Unicum(string numerus_romanus)
        {
            numerus_romanus = numerus_romanus.Replace("DCCCCLXXXXVIIII", "IM");
            numerus_romanus = numerus_romanus.Replace("DCCCCLXXXXV", "VM");
            numerus_romanus = numerus_romanus.Replace("DCCCCLXXXX", "XM");
            numerus_romanus = numerus_romanus.Replace("DCCCCL", "LM");
            numerus_romanus = numerus_romanus.Replace("DCCCC", "CM");
            numerus_romanus = numerus_romanus.Replace("CCCCLXXXXVIIII", "ID");
            numerus_romanus = numerus_romanus.Replace("CCCCLXXXXV", "VD");
            numerus_romanus = numerus_romanus.Replace("CCCCLXXXX", "XD");
            numerus_romanus = numerus_romanus.Replace("CCCCL", "LD");
            numerus_romanus = numerus_romanus.Replace("CCCC", "CD");
            numerus_romanus = numerus_romanus.Replace("LXXXXVIIII", "IC");
            numerus_romanus = numerus_romanus.Replace("LXXXXV", "VC");
            numerus_romanus = numerus_romanus.Replace("LXXXX", "XC");
            numerus_romanus = numerus_romanus.Replace("XXXXVIIII", "IL");
            numerus_romanus = numerus_romanus.Replace("XXXXV", "VL");
            numerus_romanus = numerus_romanus.Replace("XXXX", "XL");
            numerus_romanus = numerus_romanus.Replace("VIIII", "IX");
            numerus_romanus = numerus_romanus.Replace("IIII", "IV");

            return numerus_romanus;
        }
    }
}
