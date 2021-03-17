using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using net1;
namespace testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfGeneratorWorks()
        {
            RandomNumberGenerator rng = new RandomNumberGenerator(1);
            int x = rng.nextInt(1, 29);
            Assert.IsTrue(x >= 1);
        }

        [TestMethod]
        public void TestOneItem()
        {
            Backpack backpack = new Backpack(100);

            backpack.addNewItem(new item(10, 10));
            var x = backpack.GetItems();
            Assert.AreEqual(x.Count, 1);
        }

        [TestMethod]
        public void TestNoItem()
        {
            Backpack backpack = new Backpack(100);
            backpack.addNewItem(new item(101, 10));
            var x = backpack.GetItems();
            Assert.AreEqual(x.Count, 0);
        }

        [TestMethod]
        public void TestIfOrderIsImportant()
        {
            Backpack backpack1 = new Backpack(20);
            Backpack backpack2 = new Backpack(20);

            for (int i=1;i<=10;i++)
            {
                backpack1.addNewItem(new item(i, i));
                backpack2.addNewItem(new item(11-i, 11-i));
            }

            int value1 = backpack1.getValue();
            int value2 = backpack2.getValue();

            Assert.AreNotEqual(value1, value2);
        }
    }
}
