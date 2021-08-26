﻿using System;

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

            MethodCalculateNum1OrNum2(x1, x3);

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
    }
}


