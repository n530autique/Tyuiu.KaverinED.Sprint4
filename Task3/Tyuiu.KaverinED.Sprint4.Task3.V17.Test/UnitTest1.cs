using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint4.Task3.V17.Lib;

namespace Tyuiu.KaverinED.Sprint4.Task3.V17.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            Class1 ds = new Class1();
            int[,] array = 
            {
                { 6, 4, 2, 2, 1 },
                { 3, 6, 5, 4, 1 },
                { 5, 2, 3, 1, 6 },
                { 8, 8, 4, 5, 3 },
                { 7, 4, 5, 1, 6 }
            };
            int wait = 28;
            int res = ds.GetSumEvenArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}
