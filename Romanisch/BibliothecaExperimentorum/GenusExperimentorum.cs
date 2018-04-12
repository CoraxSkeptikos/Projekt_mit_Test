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
    public class GenusExperimentorum
    {

        [Test, Category ("1")]
        public void Experimentum_Primum()
        {
            Assert.AreEqual("MMCXIII", GenusRomanus.Initium(2113));
            Assert.AreEqual("MMDXXVII", GenusRomanus.Initium(2527));
            Assert.AreEqual("DLIII", GenusRomanus.Initium(553));
            Assert.AreEqual("CIX", GenusRomanus.Initium(109));
            Assert.AreEqual("MMCMVLII", GenusRomanus.Initium(2947));
            Assert.AreEqual("VL", GenusRomanus.Initium(45));
            Assert.AreEqual("MVDII", GenusRomanus.Initium(1497));
            Assert.AreEqual("MMXDII", GenusRomanus.Initium(2492));
            Assert.AreEqual("LDXXI", GenusRomanus.Initium(471));
            Assert.AreEqual("CXLIII", GenusRomanus.Initium(143));
        }
    }
}
