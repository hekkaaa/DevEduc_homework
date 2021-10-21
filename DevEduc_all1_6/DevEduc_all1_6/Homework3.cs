using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    class Homework3
    {
        static void Task1()
        {
            Console.WriteLine("Введите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"Результат: {a + b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"Результат: {a - b}");
            }
            else
            {
                Console.WriteLine($"Результат: {a * b}");
            }
        }

        static void Task2()
        {
            Console.WriteLine("Введите число X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Результат: 1 четверть");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Результат: 4 четверть");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Результат: 3 четверть");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Результат: 2 четверть");
            }
            else
            {
                Console.WriteLine(
                "Вы указали 0 в одном из координат. По этому определить четверть затруднительно.");
            }
        }
        static void Task3()
        {
            Console.WriteLine("Введите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C: ");
            double c = Convert.ToDouble(Console.ReadLine());


            if ((a > b && a > c) && (b > c))
            {
                Console.WriteLine($"Результат: {a}, {b}, {c}");
            }
            else if (a > b && a < c)
            {
                Console.WriteLine($"Результат: {c}, {a}, {b}");
            }
            else if (a > b && b < c)
            {
                Console.WriteLine($"Результат: {a}, {c}, {b}");
            }
            else if ((a < b && a < c) && (b > c))
            {
                Console.WriteLine($"Результат: {b}, {c}, {a}");
            }
            else if ((a < b && a < c) && (b < c))
            {
                Console.WriteLine($"Результат: {c}, {b}, {a}");
            }
            else if (a < b && a > c)
            {
                Console.WriteLine($"Результат: {b}, {a}, {c}");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Есть равные числа! Нет возможности их приритета!");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        static void Task4()
        {
            Console.WriteLine("Введите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Поиск дискриминанта.
            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0)
            {
                Console.WriteLine("Корней уровнения нет");
            }
            else if (D == 0)
            {
                double x = (-b + Math.Sqrt(D)) / 2 * a;
                Console.WriteLine($"Корень уровнения: {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine($"2 корня уровнения: {x1} и {x2}");

            }
        }

        static void Task5()
        {
            Console.WriteLine("Введите целое двухзначеное число.");
            int x = Convert.ToInt32(Console.ReadLine());
            // Получаем два отдельных числа.
            int num1 = x / 10;
            int num2 = x % 10;

            // Приходится присваивать значеняи по имолчанию.
            string resNum1 = "";
            bool flag = false;

            switch (num1)
            {
                case 1:
                    switch (num2)
                    {
                        case 1:
                            Console.WriteLine("Одиннадцать");
                            break;
                        case 2:
                            Console.WriteLine("Двенадцать");
                            break;
                        case 3:
                            Console.WriteLine("Тринадцать");
                            break;
                        case 4:
                            Console.WriteLine("Четырнадцать");
                            break;
                        case 5:
                            Console.WriteLine("Пятнадцать");
                            break;
                        case 6:
                            Console.WriteLine("Шестнадцать");
                            break;
                        case 7:
                            Console.WriteLine("Семнадцать");
                            break;
                        case 8:
                            Console.WriteLine("Восемнадцать");
                            break;
                        case 9:
                            Console.WriteLine("Девятнадцать");
                            break;
                    }
                    break;
                case 2:
                    resNum1 = "двадцать";
                    flag = true;
                    break;
                case 3:
                    resNum1 = "тридцать";
                    flag = true;
                    break;
                case 4:
                    resNum1 = "сорок";
                    flag = true;
                    break;
                case 5:
                    resNum1 = "пятьдесят";
                    flag = true;
                    break;
                case 6:
                    resNum1 = "шесдесят";
                    flag = true;
                    break;
                case 7:
                    resNum1 = "семдесят";
                    flag = true;
                    break;
                case 8:
                    resNum1 = "восемьдесят";
                    flag = true;
                    break;
                case 9:
                    resNum1 = "девяносто";
                    flag = true;
                    break;
                default:
                    Console.WriteLine("Введено не целое, либо не двузначное число.");
                    break;
            }

            string resNum2 = "";
            switch (num2)
            {
                case 1:
                    resNum2 = "один";
                    break;
                case 2:
                    resNum2 = "два";
                    break;
                case 3:
                    resNum2 = "три";
                    break;
                case 4:
                    resNum2 = "четыре";
                    break;
                case 5:
                    resNum2 = "пять";
                    break;
                case 6:
                    resNum2 = "шесть";
                    break;
                case 7:
                    resNum2 = "семь";
                    break;
                case 8:
                    resNum2 = "восемь";
                    break;
                case 9:
                    resNum2 = "девять";
                    break;
            }
            if (flag)
            {
                Console.WriteLine($"--------\nОтвет: {resNum1} {resNum2}");
            }
        }

        static void Task6()
        {
            Console.WriteLine("Введите число A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // формула взята:
            // https://colibrus.ru/suschestvuyuschie-treugolniki/

            if (a * b + b * c > a * c && a * c + b * c > a * b && a * b + a * c > b * c)
            {
                Console.WriteLine("Треугольник есть");
            }
            else
            {
                Console.WriteLine("Треугольника нет");
            }
        }
    }
}
