using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KaverinED.Sprint4.Task1.V17.LIb
{
    public class Class1 : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0) { sum += item; }
            }
            return sum;
        }
    }
}
