using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_06_avgust_2021_practic
{
    internal class ClassPerson
    {
        internal static class ClassFIO
        {
            private static string FirstName()
            {
                return "MyName";
            }

            private static string LastName()
            {
                return "MyLasstName";
            }

            private static string MiddleName()
            {
                return "MyMiddleName";
            }

            public static string FullName()
            {
                return $"{FirstName()} {MiddleName()} {LastName()}";
            }
        }

        class ClassBody
        {
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
}
