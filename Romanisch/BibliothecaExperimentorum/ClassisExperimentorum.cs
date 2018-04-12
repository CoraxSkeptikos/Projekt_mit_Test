using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Romanisch;
using NUnit.Framework;

namespace BibliothecaExperimentorum
{
    [TestFixture]
    public class ClassisExperimentorum
    {

        [Test, Category ("1")]
        public void Experimentum_Primum()
        {
            Assert.AreEqual("MMCXIII", ClassisRomana.Initium(2113));
            Assert.AreEqual("MMDXXVII", ClassisRomana.Initium(2527));
            Assert.AreEqual("DLIII", ClassisRomana.Initium(553));
            Assert.AreEqual("CIX", ClassisRomana.Initium(109));
            Assert.AreEqual("MMCMVLII", ClassisRomana.Initium(2947));
            Assert.AreEqual("VL", ClassisRomana.Initium(45));
            Assert.AreEqual("MVDII", ClassisRomana.Initium(1497));
            Assert.AreEqual("MMXDII", ClassisRomana.Initium(2492));
            Assert.AreEqual("LDXXI", ClassisRomana.Initium(471));
            Assert.AreEqual("CXLIII", ClassisRomana.Initium(143));
        }
    }
}
