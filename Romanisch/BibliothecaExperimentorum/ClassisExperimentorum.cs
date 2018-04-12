﻿using System;
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
            Assert.AreEqual("M", ClassisRomana.Initium(1000));
            Assert.AreEqual("MM", ClassisRomana.Initium(2000));
            Assert.AreEqual("MMM", ClassisRomana.Initium(3745));
            Assert.AreEqual("", ClassisRomana.Initium(100));
        }
    }
}
