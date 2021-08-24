using ConsoleApp_06_avgust_2021_practic.Ivanov.Ivanovich;
using ConsoleApp_06_avgust_2021_practic.Ivanov.Petrovich;
using PetrIvanovich = ConsoleApp_06_avgust_2021_practic.Ivanov.Ivanovich.Petr;
using PetrPetrovich = ConsoleApp_06_avgust_2021_practic.Ivanov.Petrovich.Petr;
//using Ivanov.Ivanovich;
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
            Console.WriteLine(Ivanov.Ivanovich.Ivan.Name());
           // Console.WriteLine(Ivanov.Ivanovich.Petr.Name());
            Console.WriteLine(PetrIvanovich.Name());
           // Console.WriteLine(Ivanov.Petrovich.Petr.Name());
            Console.WriteLine(PetrPetrovich.Name());

            Console.WriteLine(ClassFIO.FullName() ); 
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

//namespace Ivanov.Ivanovich
//{
//    static class Ivan
//    {
//        public static string Name()
//        {
//            return "Ivan Ivany4 Ivanov";
//        }
//    }
//    static class Petr
//    {
//        public static string Name()
//        {
//            return "Petr Ivany4 Ivanov";
//        }
//    }
//}

//namespace Ivanov.Petrovich
//{
//    static class Petr
//    {
//        public static string Name()
//        {
//            return "Petr Petrovich Ivanov";
//        }
//    }
//}
