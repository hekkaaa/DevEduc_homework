using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    class Homework4
    {
        static void Task1()
        {
            Console.WriteLine("Введите число A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------");
            for (int i = 1; i < 1000; i++)
            {
                double res = i % A;
                if (res == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Task2()
        {
            Console.WriteLine("Введите число A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------");

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
            Console.WriteLine(count - 1);

            // РЕШЕНИЕ БЕЗ ЦИКЛА
            //int g = (int)Math.Sqrt(A);
            //Console.WriteLine(g);
        }

        static void Task3()
        {
            Console.WriteLine("Введите число A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------");
            int res = 0;
            for (int i = 1; i < A; i++)
            {
                int formula = (int)A % i;
                if (formula == 0)
                {
                    res = i;
                }
            }
            Console.WriteLine($"Наибольший делитель: {res}");
        }

        static void Task4()
        {
            Console.WriteLine("Введите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            double b = Convert.ToDouble(Console.ReadLine());
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
                Console.WriteLine("Введен обратный диапазон! ERROR!");
            }
            Console.WriteLine("____");
            Console.WriteLine($"Сумма чисел: {res}");
        }

        static void Task5()
        {
            Console.WriteLine("Введите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            double b = Convert.ToDouble(Console.ReadLine());

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
            Console.WriteLine(a + b);
        }

        static void Task6()
        {
            Console.WriteLine("Введите любое целое число");
            int N = Convert.ToInt32(Console.ReadLine());
            double res = Math.Pow(N, 3); // умнжение чила на куб
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
            Console.WriteLine($"Загаданное число = {center}");
        }

        static void Task7()
        {
            Console.WriteLine("Введите целое число от 5 до 8 цифр");
            int a = Convert.ToInt32(Console.ReadLine());
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
                {
                    Console.WriteLine($"Нечетное {(int)formula}");
                    count++;
                }
            }
            Console.WriteLine($"Количество нечетных цифр: {count}");



        }

        static void Task8()
        {

            Console.Write("Введите любое целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            Console.WriteLine(result);
        }

        static void Task9()
        {


            Console.WriteLine("Введите целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");

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

        static void Task10()
        {
            Console.WriteLine("Введите целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------");

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
