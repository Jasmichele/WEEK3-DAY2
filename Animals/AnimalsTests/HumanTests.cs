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
    public class HumanTests
    {
        Human jas = new Human();

        [TestMethod()]
        public void HumanTest()
        {
            Assert.AreEqual(2, jas.NumLegs);
            jas.Species = "Homosapien";
            Assert.AreEqual("Homosapien", jas.Species);
            jas.HasTail = false;
            jas.HasOpposableThumb = true;
            jas.MaritalStatus = 's';
        }

        [TestMethod()]
        public void GetMarriedTest()
        {
            jas.MaritalStatus = 'S';
            jas.GetMarried();
            jas.MaritalStatus = 'M';
        }

        [TestMethod()]
        public void GetMarriedTest1()
        {
            jas.MaritalStatus = 'S';
            Assert.AreEqual(null, jas.FirstName);
            Assert.AreEqual(null, jas.LastName);
        
            jas.GetMarried("Jasmine", "White");
            Assert.AreEqual('M', jas.MaritalStatus);
            Assert.AreEqual("White", jas.LastName);
            Assert.AreEqual("Jasmine", jas.FirstName);
        }

        [TestMethod()]
        public void GetSingleTest()
        {
            jas.MaritalStatus = 'M';
            jas.GetSingle();
            Assert.AreEqual('S', jas.MaritalStatus);
        }

        [TestMethod()]
        public void GetSingleTest1()
        {
            jas.MaritalStatus = 'M';
            Assert.AreEqual(null, jas.FirstName);
            Assert.AreEqual(null, jas.LastName);
            jas.GetSingle("Jas", "Michele");
            Assert.AreEqual('S', jas.MaritalStatus);
        }
    }
}