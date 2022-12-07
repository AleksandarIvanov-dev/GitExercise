using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var math = new GitUnitTestDemo.Math(5,2);
            var math1 = new GitUnitTestDemo.Math(1234, 0);

            Assert.AreEqual(7, math.Add());
            Assert.AreEqual(3, math.Subtract());
            Assert.AreEqual(10, math.Multiply());
            Assert.AreEqual(2.5,math.Divide());
            Assert.AreEqual(Single.PositiveInfinity, math1.Divide());
            Assert.AreEqual(10,math1.SumDigits());
            Assert.AreEqual("101", math.Binary());

        }
    }
}
