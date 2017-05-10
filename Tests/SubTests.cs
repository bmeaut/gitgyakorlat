using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SubTests
    {
        [TestMethod]
        public void TestSub()
        {
            int result = Operations.Sub(9, 4);
            Assert.AreEqual(result, 5);
        }
    }
}
