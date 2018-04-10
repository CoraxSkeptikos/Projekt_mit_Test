using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using königfröhlich;
using NUnit.Framework;

namespace Testbibliothek
{
    [TestFixture]
    public class Testklasse
    {
        [Test, Category ("Akzeptanztest")]
        public void föhliche_Zahlen()
        {
            var ergebnis = FrohClass.Start_Frohtester(1);
            Assert.AreEqual(true);
        }
    }
}
