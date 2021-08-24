using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_06_avgust_2021_practic
{
    class ClassFIO
    {
        private static string FirstName()
        {
            return "MyName";
        }

        public static string LastName()
        {
            return "MyLasstName";
        }

        public static string MiddleName()
        {
            return "MyMiddleName";
        }

        public static string FullName()
        {
            return $"{FirstName()} {MiddleName()} {LastName()}";
        }

        public static int ArmsAmount()
        {
            return 2;
        }

        public static int LegsAmount()
        {
            return 2;
        }
    }
}
