using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using net1;
namespace testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RandomNumberGenerator rng = new RandomNumberGenerator(1);
            int x = rng.nextInt(1, 29);
            Assert.IsTrue(x >= 1);
        }
    }
}
