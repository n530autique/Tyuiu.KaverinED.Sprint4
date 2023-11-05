using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KaverinED.Sprint4.Task3.V17.Lib
{
    public class Class1 : ISprint4Task0V17
    {
        public int GetSumEvenArrEl(int[] array)
        {
            return 0;
        }

        public int GetSumEvenArrEl(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i <= 5; i++)
            {
                sum += array[3, i];
            }
            return sum;
        }
    }
}
