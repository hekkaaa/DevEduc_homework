using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    class Homework4
    {
        public static void Task1(double A)
        {
            for (int i = 1; i < 1000; i++)
            {
                double res = i % A;
                if (res == 0)
                {   // Тут колхоз получается. Array определить не могу подлине, а List еще нельзя.
                    Console.WriteLine(i);
                }
            }
        }

        public static int Task2(double A)
        {
            double n = 0;
            int count = 1;

            while (n <= A)
            {
                n = count * count;

                if (n < A)
                {
                    count++;
                }
            }
            // -1 из-за лишней итерации цифры равной или близкой введеной А. 
            count--;
            return count;

            // РЕШЕНИЕ БЕЗ ЦИКЛА
            //int g = (int)Math.Sqrt(A);
            //Console.WriteLine(g);
        }

        public static int Task3(double A)
        {
            int res = 0;
            for (int i = 1; i < A; i++)
            {
                int formula = (int)A % i;
                if (formula == 0)
                {
                    res = i;
                }
            }
            return res;
        }

        public static int Task4(double a, double b)
        {
            int res = 0;
            if (b < 0)
            {
                for (int i = (int)a; i >= b; i--)
                {
                    int formula = i % 7;
                    if (formula == 0)
                    {
                        res += i;
                    }
                }
            }
            else if (b > 0)
            {
                for (int i = (int)a; i <= b; i++)
                {
                    int formula = i % 7;
                    if (formula == 0)
                    {
                        res += i;
                    }
                }
            }
            else
            {
                return -0; // ERROR
            }
            return res;
        }

        public static double Task5(double a, double b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = (int)a % (int)b;
                }
                else
                {
                    b = (int)b % (int)a;
                }
            }
            double c = a + b;
            return c;
        }

        public static int Task6(int N)
        {
            double res = Math.Pow(N, 3); // умножение чила на куб
            int leftLimit = 0; // Левый предел
            int rightLimit = (int)res; // правый предел
            int center = 0; // число в центре

            while (center != N)
            {
                center = (leftLimit + rightLimit) / 2;
                if (center > N)
                {
                    rightLimit = center;
                }
                else
                {
                    leftLimit = center;
                }
            }
            return center; 
        }

        public static void Task7(int a)
        {
            int len = 0;
            int num = a; // присваиваем для дальнейшего использования в цикле.

            // подсчет длинны числа.
            while (a > 0)
            {
                len++;
                a /= 10;
            }

            double f = 0.1; // переменная f для деления в формуле.
            int count = 0; //счетчик для нечетных чисел

            // Главный цикл.
            for (int i = len - 1; i >= 0; i--)
            {
                f *= 10;
                double formula = (num / f) % 10; // формула для отделения цифр по 1 шт.
                if ((int)formula % 2 != 0)
                {   // тут нужен LIST.
                    Console.WriteLine($"Нечетное {(int)formula}");
                    count++;
                }
            }
            Console.WriteLine($"Количество нечетных цифр: {count}");



        }

        public static int Task8(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            return result;
        }

        public static void Task9(int a)
        {
            int len = 0;
            int num = a; // присваиваем для дальнейшего использования в цикле.
            double f = 1; // переменная f для деления в формуле.
            // подсчет длинны числа.
            while (a > 0)
            {
                len++;
                a /= 10;
                f *= 10; // Прибавляем кол-во 0 после 1 для дальнейшего деления.
            }

            int chetnoe = 0;
            int nechetnoe = 0;

            // Главный цикл.
            for (int i = len - 1; i >= 0; i--)
            {
                f /= 10; // уменьшаем кол-во 0 после 1.
                double formula = (num / f) % 10; // формула для отделения цифр по 1 шт.
                if ((int)formula % 2 != 0)
                {

                    nechetnoe += (int)formula;
                }
                else
                {
                    chetnoe += (int)formula;

                    if (chetnoe > nechetnoe)
                    {
                        Console.WriteLine($"Результат суммы четных больше нечетных: {chetnoe}");
                    }
                }
            }
        }

        public static void Task10(int a, int b)
        {
            int len_a = 0;
            int num_a = a; // присваиваем для дальнейшего использования в цикле.
            int x = b;

            // подсчет длинны числа.
            while (a > 0)
            {
                len_a++;
                a /= 10;
            }

            double f = 0.1; // переменная f для деления в формуле.


            // Главный цикл.
            for (int i = len_a - 1; i >= 0; i--)
            {
                f *= 10;
                double formula_a = (num_a / f) % 10; // формула для отделения цифр по 1 шт.

                // Начало второго цикла внутри.
                int len_b = 0;
                int num_b = x;
                double f1 = 0.1;
                b = x;// переприсваивание т.к прошлая затирается в цикле.

                while (b > 0)
                {
                    len_b++;
                    b /= 10;
                }

                for (int ii = len_b - 1; ii >= 0; ii--)
                {
                    f1 *= 10;
                    double formula_b = (num_b / f1) % 10; // формула для отделения цифр по 1 шт.

                    if ((int)formula_a == (int)formula_b)
                    {
                        Console.WriteLine($"Совпадения: ДА");
                    }
                }

            }
            Console.WriteLine($"Совпадения: НЕТ");
        }
    }
}
