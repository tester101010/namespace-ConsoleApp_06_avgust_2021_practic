using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Less10.Enum
{
    //public static bool  isMan = true;
    /// <summary>
    /// This is class Leesson 10 Enum
    /// </summary>
    public static class ClassStep1   
    {

        public static string MethodStep1(bool gender, string name)
        {
            if (gender == true)
            {
                Console.WriteLine("gender == true");
            }
            else
            {
                Console.WriteLine("gender != true");
            }
            return "ClassLibrary.Less10.Enum.MethodStep1";
        }
    }


}
