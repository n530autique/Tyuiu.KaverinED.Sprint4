using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KaverinED.Sprint4.Task2.V16.Lib
{
    public class Class1 : ISprint4Task2V16
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                if (item % 2 == 1) { sum += item; }
            }
            return sum;
        }
    }
}
