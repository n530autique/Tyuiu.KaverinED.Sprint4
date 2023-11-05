using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint4.Task1.V17.LIb;

namespace Tyuiu.KaverinED.Sprint4.Task0.V14.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int res = ds.Calculate(array);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}
