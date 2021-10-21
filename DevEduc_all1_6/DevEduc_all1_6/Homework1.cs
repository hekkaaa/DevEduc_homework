using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    class Homework1
    {

         public static (int,double) Task1()
        {
            // Задание 1

            int a = 3;
            double b = 5.0;
            return (a,b);
        }

        public static double Task2(double a, double b)
        {
            // Задание 2

            double c = (5 * a + Math.Pow(b, 4)) / (b - a);
            return c;
        }
        public static (string, string) Task3(string s1, string s2)
        {
            // Задание 3

            string s3 = s1;
            s1 = s2;
            s2 = s3;
            return (s1, s2);     
        }

        static void Task4()
        {
            Console.WriteLine("Введите целое число A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число C:");
            int c = Convert.ToInt32(Console.ReadLine());
            double x = (double)(c - b) / a;

            Console.WriteLine($"X Равен: {x}");
        }

        static void Task5()
        {
            // Задание *1

            Console.WriteLine("Введите целое число x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            // Вичисляем по Формуле углового коэффициента прямой k = (Y2 — Y1) / (X2 — X1)
            int a = y2 - y1;
            int b = x2 - x1;
            Console.WriteLine($"y = {a}*x + {b}");
        }

        static void Task6()
        {
            // Задание *2

            //пример значений где получится положительный дискриминант.
            //int a = 3;
            //int b = 10;
            //int c = 7;

            Console.WriteLine("Введите целое число a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число c:");
            int c = Convert.ToInt32(Console.ReadLine());

            // Вычисление Дискриминанта
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                // Вычисление корней
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine($"Дискриминант: {D}");
                Console.WriteLine($"Корень x1: {x1}");
                Console.WriteLine($"Корень x2: {x2}");
            }
            else
            {
                Console.WriteLine("Дискриминант меньше 0. Введите другие числа.");
            }
        }
    }
}
