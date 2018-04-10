using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fizzBuzz;

namespace FizzBuzzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guten Tag");
            Console.WriteLine("Bitte geben Sie die Obergrenze für das heutige FizzBuzzing an");
            int zahl1 = 0;
            int zahl2 = 0;
            Int32.TryParse(Console.ReadLine(), out zahl1);
            Console.WriteLine("Vielen Dank");
            Console.WriteLine("Geben Sie nun bitte die Untergrenze für das heutige FizzBuzzing an");
            Int32.TryParse(Console.ReadLine(), out zahl2);
            Console.WriteLine("Vielen Dank");
            FizzBuzz.Start_FizzBuzz(zahl2, zahl1).ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
