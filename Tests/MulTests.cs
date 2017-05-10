using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MulTests
    {
        [TestMethod]
        public void TestMul()
        {
            int result = Operations.Mul(3, 4);
            Assert.AreEqual(result, 12);
        }
    }
}
