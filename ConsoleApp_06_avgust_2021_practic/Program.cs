﻿using ConsoleApp_06_avgust_2021_practic.Ivanov.Ivanovich;
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
            double x1;
            double x2 = 6;
            double x3 = 3;

            MethodConvertStringToDouble(out x1, x2, out x3);

            #region Region persons
            //Console.WriteLine(Ivan.Name());
            //Console.WriteLine(PetrIvanovich.Name());
            //Console.WriteLine(PetrPetrovich.Name());

            //Console.WriteLine(ClassPerson.ClassFIO.FullName());
            #endregion
            //Console.WriteLine(ClassPerson.);

            //computation.Calculator.Add(x3,x2);
            MethodCalculateNum1OrNum2(x1, x3);

            //Console.WriteLine(computation.StringCalc.
            //    StringLength("jnjkldghdfghdfghdfhdfnjkh"));

            //Console.WriteLine(computation.GenerateRandomNum.Random(5, 55));

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

        private static void MethodConvertStringToDouble(out double x1, double x2, out double x3)
        {
            Console.WriteLine(" Программа сложения вычитания умножения " +
            "и деления первого числа и второго. \n");
            x1 = ConvertStringToDouble(x2);
            x3 = ConvertStringToDouble(x2);
        }

        private static void MethodCalculateNum1OrNum2(double x1, double x3)
        {
            Console.WriteLine($"сложение {x1} и {x3} = " +
                computation.Calculator.Add(x1, x3));

            Console.WriteLine($"вычетание {x3} из {x1} = " +
                computation.Calculator.Sub(x1, x3));

            Console.WriteLine($"умножение {x1} на {x3} =  " +
                computation.Calculator.Multiply(x1, x3));

            Console.WriteLine($"деление  {x1} на {x3} = " +
                computation.Calculator.Divide(x1, x3));
        }

        private static double ConvertStringToDouble(double x1)
        {
            double X = x1;
            Console.WriteLine(" Введите число ");
            string s1 = Console.ReadLine();
            Console.WriteLine($" Введенное число -> {s1}\n");
            x1 = Convert.ToDouble(s1);
            return x1;
        }

        //private static int DoubleX(int x1)
        //{
        //    int x = x1 * 2;
        //    return x;
        //}
    }
}


