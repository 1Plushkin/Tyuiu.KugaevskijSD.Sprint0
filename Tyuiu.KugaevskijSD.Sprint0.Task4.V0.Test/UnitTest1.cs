using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KugaevskijSD.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KugaevskijSD.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, Class1.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, Class1.Subtraction(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(25, Class1.Multiplication(5, 5));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, Class1.Division(9, 3));
        }
    }
}