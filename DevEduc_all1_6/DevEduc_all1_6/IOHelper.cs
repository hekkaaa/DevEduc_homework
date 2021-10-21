using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    class IOHelper
    {
         public static (double, double) InputDoubleNumber()
        {
            Console.WriteLine("Введите число A");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b = Convert.ToDouble(Console.ReadLine());
            return (a, b);

        }

        public static (string, string) InputStringValue()
        {
            Console.WriteLine("Введите слово\\символ 1:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите слово\\символ 2:");
            string b = Console.ReadLine();

            return (a, b);
        }

    }
}
