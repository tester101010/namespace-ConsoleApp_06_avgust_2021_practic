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
            int[] array1;
            Console.WriteLine("сколько ?\n");
            int n = Convert.ToInt32(Console.ReadLine());
            array1 = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(10);
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine("\n сколько ?\n");
            n = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref array1, n);
            for (int i = 0; i < array1.Length; i++)
            {
                //array1[i] = rnd.Next(10);
                Console.Write($"{array1[i]} ");
            }
            #region   1
            //int x = 56;
            //Console.WriteLine(x);
            //Double(x);
            //Console.WriteLine(x);

            #endregion
            Console.ReadKey();
        }

        //private static int Double(int x1)
        //{
        //    int x = x1 *2;
        //    return  x;
        //}
    }
}
