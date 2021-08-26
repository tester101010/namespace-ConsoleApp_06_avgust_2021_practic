using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_06_avgust_2021_practic.computation
{
    class GenerateRandomNum
    {
        public static int Random(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
