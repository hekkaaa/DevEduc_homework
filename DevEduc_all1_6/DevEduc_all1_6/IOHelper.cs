using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    class IOHelper
    {   
        public static int InputInt(string message)
        {
            Console.Write(message + ": ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double InputDouble(string message)
        {
            Console.Write(message + ": ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static string InputString(string message)
        {
            Console.Write(message + ": ");
            return Console.ReadLine();
        }
       

    }
}
