using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void TestAdd()
        {
            int result = Operations.Add(5, 6);
            Assert.AreEqual(result, 11);
        }
    }
}
