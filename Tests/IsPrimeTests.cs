using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class IsPrimeTests
    {
        [TestMethod]
        public void TestIsPrimeWithPrime()
        {
            bool result = Operations.IsPrime(5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsPrimeWithNonPrime()
        {
            bool result = Operations.IsPrime(6);
            Assert.IsFalse(result);
        }

    }
}
