using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KugaevskijSD.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KugaevskijSD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "1Plushkin";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет... 1Plushkin", res);
        }
    }
}
