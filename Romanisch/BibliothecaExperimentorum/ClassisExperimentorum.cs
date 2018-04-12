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
            Assert.AreEqual("MMDCCCCX", ClassisRomana.Initium(2914));
            Assert.AreEqual("MDCLX", ClassisRomana.Initium(1665));
            Assert.AreEqual("MDCXXX", ClassisRomana.Initium(1638));
            Assert.AreEqual("MMCCCXXX", ClassisRomana.Initium(2336));
            Assert.AreEqual("MMDCCXXX", ClassisRomana.Initium(2734));
            Assert.AreEqual("MCCL", ClassisRomana.Initium(1254));
            Assert.AreEqual("MMCCC", ClassisRomana.Initium(2306));
            Assert.AreEqual("MLXX", ClassisRomana.Initium(1075));
            Assert.AreEqual("DCCCCXXXX", ClassisRomana.Initium(943));
            Assert.AreEqual("CX", ClassisRomana.Initium(115));

        }
    }
}
