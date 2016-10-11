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
    public class CanineTests
    {
        Canine dog = new Canine();

        [TestMethod()]
        public void CanineTest()
        {
            Assert.AreEqual(4, dog.NumLegs);
            Assert.IsTrue(dog.HasFur);
            Assert.IsTrue(dog.HasTail);
            Assert.IsTrue(dog.HasTail);
        } 

        [TestMethod()]
        public void AdoptedTest()
        {
            Human sarah = new Human();
            Assert.IsNull(dog.Owner);
            dog.Adopted(sarah);
            Assert.AreEqual(sarah, dog.Owner);
        }

        [TestMethod()]
        public void AdoptedTest1()
        {
            Human sarah = new Human();
            dog.Adopted(sarah, "Pete");
            Assert.AreEqual(sarah, dog.Owner);
            Assert.AreEqual("Pete", dog.DogName);
        }
    }
}