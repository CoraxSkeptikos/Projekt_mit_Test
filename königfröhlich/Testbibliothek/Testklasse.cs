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
            Assert.True(FrohClass.Start_Frohtester(1));
            Assert.True(FrohClass.Start_Frohtester(100));
            Assert.True(FrohClass.Start_Frohtester(7));
            Assert.True(FrohClass.Start_Frohtester(97));
            Assert.True(FrohClass.Start_Frohtester(44));
            Assert.True(FrohClass.Start_Frohtester(49));
            Assert.False(FrohClass.Start_Frohtester(11));
            Assert.False(FrohClass.Start_Frohtester(99));
            Assert.False(FrohClass.Start_Frohtester(8));
            Assert.False(FrohClass.Start_Frohtester(25));
            Assert.False(FrohClass.Start_Frohtester(47));
            Assert.False(FrohClass.Start_Frohtester(34));
        }
    }
}
