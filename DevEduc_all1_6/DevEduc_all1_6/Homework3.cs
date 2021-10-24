using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    class Homework3
    {
        public static double Task1(double a, double b)
        {
            double c;
            if (a > b)
            {
                c = a + b;
                return c;
            }
            else if (a < b)
            {
                c = a - b;
                return c;
            }
            else
            {
                c = a * b;
                return c;
            }
        }

        public static string Task2(double x, double y)
        {
            if (x > 0 && y > 0)
            {   
                return "Результат: 1 четверть";
                
            }
            else if (x < 0 && y > 0)
            {
                return "Результат: 4 четверть";
            }
            else if (x < 0 && y < 0)
            {
                return "Результат: 3 четверть";
            }
            else if (x > 0 && y < 0)
            {
                return "Результат: 2 четверть";
            }
            else
            {
                return 
                    "Вы указали 0 в одном из координат. По этому определить четверть затруднительно.";
            }
        }
        public static string Task3( double a, double b, double c )
        {
            if ((a > b && a > c) && (b > c))
            {
                return $"Результат: {a}, {b}, {c}";
            }
            else if (a > b && a < c)
            {
                return $"Результат: {c}, {a}, {b}";
            }
            else if (a > b && b < c)
            {
                return $"Результат: {a}, {c}, {b}";
            }
            else if ((a < b && a < c) && (b > c))
            {
                return $"Результат: {b}, {c}, {a}";
            }
            else if ((a < b && a < c) && (b < c))
            {
                return $"Результат: {c}, {b}, {a}";
            }
            else if (a < b && a > c)
            {
                return $"Результат: {b}, {a}, {c}";
            }
            else if (a == b || a == c || b == c)
            {
                return "Есть равные числа! Нет возможности их приритета!";
            }
            else
            {
                return "Error";
            }
        }
        public static string Task4(double a, double b, double c)
        {
            // Поиск дискриминанта.
            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0)
            {
                return "Корней уровнения нет";
            }
            else if (D == 0)
            {
                double x = (-b + Math.Sqrt(D)) / 2 * a;
                return $"Корень уровнения: {x}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                return $"2 корня уровнения: {x1} и {x2}";
            }
        }

        public static string Task5(int x)
        {
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
                            return "Одиннадцать";

                        case 2:
                            return "Двенадцать";

                        case 3:
                            return "Тринадцать";

                        case 4:
                            return "Четырнадцать";

                        case 5:
                            return "Пятнадцать";

                        case 6:
                            return "Шестнадцать";

                        case 7:
                            return "Семнадцать";

                        case 8:
                            return "Восемнадцать";

                        case 9:
                            return "Девятнадцать";

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
                    return "Введено не целое, либо не двузначное число.";
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
                return $"--------\nОтвет: {resNum1} {resNum2}";
            }
            return ""; // Заглушка.
        }

        public static string Task6(double a, double b, double c)
        {
            // формула взята:
            // https://colibrus.ru/suschestvuyuschie-treugolniki/

            if (a * b + b * c > a * c && a * c + b * c > a * b && a * b + a * c > b * c)
            {
                return "Треугольник есть";
            }
            else
            {
                return "Треугольника нет";
            }
        }
    }
}
