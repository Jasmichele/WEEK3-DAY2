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
        [TestMethod()]
        public void HumanTest()
        {
            Human jas = new Human();
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
            Human jas = new Human();
            Assert.AreEqual(null, jas.FirstName);
            Assert.AreEqual(null, jas.LastName);
            jas.MaritalStatus = 'M';
            jas.LastName = "White";
            jas.FirstName = "Jas";
            Assert.AreEqual("White", jas.LastName);
            Assert.AreEqual("Jas", jas.FirstName);
        }

        [TestMethod()]
        public void GetMarriedTest1()
        {
            Human jas = new Human();
            Assert.AreEqual(null, jas.FirstName);
            Assert.AreEqual(null, jas.LastName);
            jas.MaritalStatus = 'S';
            jas.FirstName = "Jasmine";
            jas.LastName = "Michele";
            jas.MaritalStatus = 'M';
            Assert.AreEqual("Michele", jas.LastName);
            Assert.AreEqual("Jasmine", jas.FirstName);
        }

        [TestMethod()]
        public void GetSingleTest()
        {

            Human jas = new Human();
            Assert.AreEqual(null, jas.FirstName);
            Assert.AreEqual(null, jas.LastName);
            jas.MaritalStatus = 'S';
            jas.LastName = "Michele";
            jas.FirstName = "Jas";
            Assert.AreEqual("Michele", jas.LastName);
            Assert.AreEqual("Jas", jas.FirstName);
        }

        [TestMethod()]
        public void GetSingleTest1()
        {
            Human jas = new Human();
            Assert.AreEqual(null, jas.FirstName);
            Assert.AreEqual(null, jas.LastName);
            jas.MaritalStatus = 'M';
            jas.FirstName = "Jasmine";
            jas.LastName = "White";
            jas.MaritalStatus = 'S';
            Assert.AreEqual("White", jas.LastName);
            Assert.AreEqual("Jasmine", jas.FirstName);
        }
    }
}