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
        [TestMethod()]
        public void CanineTest()
        {
            Canine dog = new Canine();
            Assert.AreEqual(4, dog.NumLegs);
            Assert.IsTrue(dog.HasFur);
            Assert.IsTrue(dog.HasTail);
            Assert.IsTrue(dog.HasTail);
        } 

        [TestMethod()]
        public void AdoptedTest()
        {
            Canine dog = new Canine();
            Human sarah = new Human();
            dog.Owner = sarah;
            Assert.AreEqual(sarah, dog.Owner);

        }

        [TestMethod()]
        public void AdoptedTest1()
        {
            Canine dog = new Canine();
            dog.DogName = "dog";
            Human sarah = new Human();
            dog.Owner = sarah;
            Assert.AreEqual(sarah, dog.Owner);
            Assert.AreEqual("dog", dog.DogName);

        }
    }
}