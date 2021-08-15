using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_06_avgust_2021_practic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  таблица умножения 5 * 5 , вариант 1

            //таблица умножения 5 * 5 без массивов , вариант 1
            Console.WriteLine("таблица умножения 5 * 5 без массивов , вариант 1");

            int x1_1, x1_2, x1_3, x1_4, x1_5;
            int x2_1, x2_2, x2_3, x2_4, x2_5;
            int x3_1, x3_2, x3_3, x3_4, x3_5;
            int x4_1, x4_2, x4_3, x4_4, x4_5;
            int x5_1, x5_2, x5_3, x5_4, x5_5;

            x1_1 = 1 * 1; x1_2 = 1 * 2; x1_3 = 1 * 3; x1_4 = 1 * 4; x1_5 = 1 * 5;
            x2_1 = 2 * 1; x2_2 = 2 * 2; x2_3 = 2 * 3; x2_4 = 2 * 4; x2_5 = 2 * 5;
            x3_1 = 3 * 1; x3_2 = 3 * 2; x3_3 = 3 * 3; x3_4 = 3 * 4; x3_5 = 3 * 5;
            x4_1 = 4 * 1; x4_2 = 4 * 2; x4_3 = 4 * 3; x4_4 = 4 * 4; x4_5 = 4 * 5;
            x5_1 = 5 * 1; x5_2 = 5 * 2; x5_3 = 5 * 3; x5_4 = 5 * 4; x5_5 = 5 * 5;

            Console.WriteLine($"\tcol 1\tcol 2\tcol 3\tcol 4\tcol 5\n");

            Console.WriteLine($"line 1   {x1_1}\t{x1_2}\t{x1_3}\t{x1_4}\t{x1_5}");
            Console.WriteLine($"line 1   {x2_1}\t{x2_2}\t{x2_3}\t{x2_4}\t{x2_5}");
            Console.WriteLine($"line 1   {x3_1}\t{x3_2}\t{x3_3}\t{x3_4}\t{x3_5}");
            Console.WriteLine($"line 1   {x4_1}\t{x4_2}\t{x4_3}\t{x4_4}\t{x4_5}");
            Console.WriteLine($"line 1   {x5_1}\t{x5_2}\t{x5_3}\t{x5_4}\t{x5_5}");
            #endregion

            Console.ReadKey();
        }
    }
}
