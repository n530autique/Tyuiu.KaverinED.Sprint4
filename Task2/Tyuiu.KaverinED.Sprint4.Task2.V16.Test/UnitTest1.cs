using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint4.Task2.V16.Lib;

namespace Tyuiu.KaverinED.Sprint4.Task2.V16.Test
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
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
