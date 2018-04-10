using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fizzBuzz;
using NUnit.Framework;

namespace Testbibliothek
{
    [TestFixture]
    public class Testklasse
    {
        [Test, Category ("Akzeptanztest")]
        public void Zahlen_zwischen_Untergrenze_Obergrenze()
        {
            var ergebnis = FizzBuzz.Start_FizzBuzz(1, 15);
            Assert.AreEqual(new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" }, ergebnis.ToArray());
        }
    }
}
