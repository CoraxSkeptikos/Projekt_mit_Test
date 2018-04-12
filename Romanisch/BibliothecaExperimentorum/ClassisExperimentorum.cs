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
            Assert.AreEqual("MMDCCCCXIIII", ClassisRomana.Initium(2914));
            Assert.AreEqual("MDCLXV", ClassisRomana.Initium(1665));
            Assert.AreEqual("MDCXXXVIII", ClassisRomana.Initium(1638));
            Assert.AreEqual("MMCCCXXXVI", ClassisRomana.Initium(2336));
            Assert.AreEqual("MMDCCXXXIIII", ClassisRomana.Initium(2734));
            Assert.AreEqual("MCCLIIII", ClassisRomana.Initium(1254));
            Assert.AreEqual("MMCCCVI", ClassisRomana.Initium(2306));
            Assert.AreEqual("MLXXV", ClassisRomana.Initium(1075));
            Assert.AreEqual("DCCCCXXXXIII", ClassisRomana.Initium(943));
            Assert.AreEqual("CXV", ClassisRomana.Initium(115));

        }
    }
}
