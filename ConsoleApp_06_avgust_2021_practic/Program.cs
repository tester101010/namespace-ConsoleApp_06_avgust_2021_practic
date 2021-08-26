using ConsoleApp_06_avgust_2021_practic.Ivanov.Ivanovich;
//using ConsoleApp_06_avgust_2021_practic.Ivanov.Petrovich;
using PetrIvanovich = ConsoleApp_06_avgust_2021_practic.Ivanov.Ivanovich.Petr;
using PetrPetrovich = ConsoleApp_06_avgust_2021_practic.Ivanov.Petrovich.Petr;
using System;

namespace ConsoleApp_06_avgust_2021_practic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ivan.Name());
            Console.WriteLine(PetrIvanovich.Name());
            Console.WriteLine(PetrPetrovich.Name());

            Console.WriteLine(ClassPerson.ClassFIO.FullName() );
            //Console.WriteLine(ClassPerson.);
            //computation.Calculator calc = new computation.Calculator(2,5);
            #region MyRegion
            //int[] array1;
            //Console.WriteLine("сколько ?\n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //array1 = new int[n];
            //Random rnd = new Random();

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = rnd.Next(10);
            //    Console.Write($"{array1[i]} ");
            //}
            //Console.WriteLine("\n сколько ?\n");
            //n = Convert.ToInt32(Console.ReadLine());
            //Array.Resize(ref array1, n);
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    //array1[i] = rnd.Next(10);
            //    Console.Write($"{array1[i]} ");
            //}
            #endregion

            #region   1
            //int x = 56;
            //Console.WriteLine(x);
            //int y = DoubleX(x);
            //Console.WriteLine(y);

            #endregion
            Console.ReadKey();
        }

        //private static int DoubleX(int x1)
        //{
        //    int x = x1 * 2;
        //    return x;
        //}
    }
}


