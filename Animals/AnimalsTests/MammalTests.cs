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
        [TestMethod()]
        public void MammalTest()
        {
            Mammal j = new Mammal();
            Assert.IsTrue(j.GivesLiveBirth);
            j.NumChildren = 2;
            
        }

        [TestMethod()]
        public void GiveBirthTest()
        {
            Mammal j = new Mammal();
            j.NumChildren = 2;
            j.HasOffspring = true;
            Assert.IsTrue(j.HasOffspring);
            Assert.AreEqual(2, j.NumChildren);
        }

        [TestMethod()]
        public void GiveBirthTest1()
        {
            Mammal j = new Mammal();
            j.NumChildren = 2;
            j.HasOffspring = true;
            Assert.IsTrue(j.HasOffspring);
            Assert.AreEqual(2, j.NumChildren);
          
        }
    }
}