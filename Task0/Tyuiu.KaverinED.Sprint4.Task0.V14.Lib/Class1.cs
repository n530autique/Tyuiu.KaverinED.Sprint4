using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KaverinED.Sprint4.Task0.Lib
{
    public class Class1 : ISprint4Task0V14
    {
        public int GetSumOddArrEl(int[] array)
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
