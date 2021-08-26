using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_06_avgust_2021_practic.computation
{/// <summary>
/// Клас выполняющий методы вычисления: сложение, вычетание , умножение и деление двух чисел
/// </summary>
    internal class Calculator
    {
        /// <summary>
        /// сложение двух чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Add(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// вычетание двух чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Sub(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// умножение двух чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// деление двух чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Divide(double x, double y)
        {
            return x / y;
        }

        public static int StringLength(string str)
        {
            return str.Length;
        }

        public static int Random(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
