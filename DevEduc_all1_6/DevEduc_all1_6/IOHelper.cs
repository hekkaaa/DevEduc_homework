using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    class IOHelper
    {   
         // Значения поумолчанию реализованы как "костыль" для реализации перегрузки.
         public static (double, double) InputTwoDoubleNumber()
        {
            Console.WriteLine("Введите число A");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double b = Convert.ToDouble(Console.ReadLine());
            return (a, b);

        }

        public static (int, int, int) InputTreeIntNumber()
        {
            Console.WriteLine("Введите число A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число С");
            int c = Convert.ToInt32(Console.ReadLine());
            return (a, b, c);
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
