using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int actual = Calculation.GetQuantityForProduct(1, 1, 1, 1, -4);
            Assert.AreEqual(-1, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int actual = Calculation.GetQuantityForProduct(3, 1, 15, 20, 45);
            Assert.AreEqual(114148, actual);

        }
    }
}
