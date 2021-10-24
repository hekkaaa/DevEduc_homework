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

        public static double Task4(int a , int b , int c)
        {       // Задание 4 
            double x = (double)(c - b) / a;
            return x; 
        }

        public static (int, int) Task5(int x1, int y1, int x2, int y2)
        {
            // Задание *1

            // Вичисляем по Формуле углового коэффициента прямой k = (Y2 — Y1) / (X2 — X1)
            int a = y2 - y1;
            int b = x2 - x1;

            return (a, b);
        }

        public static (double, double, double, bool) Task6(int a, int b, int c)
        {
            // Задание *2

            //пример значений где получится положительный дискриминант.
            //int a = 3;
            //int b = 10;
            //int c = 7;

            bool flag = true;
            double x1 = 0;
            double x2 = 0;

            // Вычисление Дискриминанта
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                // Вычисление корней
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
            }
            else
            {
                flag = false;
               
            }
            return (D, x1, x2, flag);
        }
    }
}
