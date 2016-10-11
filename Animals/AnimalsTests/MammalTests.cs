using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Tests
{
    [TestClass()]
    public class MammalTests
    {
        Mammal j = new Mammal();

        [TestMethod()]
        public void MammalTest()
        {
            Assert.IsTrue(j.GivesLiveBirth);
        }

        [TestMethod()]
        public void GiveBirthTest()
        {
            j.GiveBirth();
            Assert.IsTrue(j.HasOffspring);
            Assert.AreEqual(1, j.NumChildren);
        }

        [TestMethod()]
        public void GiveBirthTest1()
        {
            j.GiveBirth(2);
            Assert.IsTrue(j.HasOffspring);
            Assert.AreEqual(2, j.NumChildren);
        }
    }
}