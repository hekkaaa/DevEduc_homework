using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    class Homework6
    {
        public static int[,] Massive(int line, int сolumns, int rangeStart, int rangeEnd)
        {
            // line - строка. сolumns - столбец 
            // rangeStart - старт диапазона рандома. rangeEnd - конец

            // рандом
            Random rnd = new Random();

            // Создание и наполнение массива.
            int[,] mas = new int[line, сolumns];

            Console.WriteLine("Двумерный массив: ");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(rangeStart, rangeEnd);
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }
            return mas;
        }

        public static int[,] Task1(int[,] massive)
        {
            // Задание 1

            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    if (i == 0 || i == massive.GetLength(0) - 1)
                    {
                        massive[i, j] = massive[i, j] < 0 ? massive[i, j] = -massive[i, j] : massive[i, j];
                    }
                    else if ((i > 0 || i < massive.GetLength(0) - 1) && j == 0 || j == massive.GetLength(1) - 1)
                    {
                        massive[i, j] = massive[i, j] < 0 ? massive[i, j] = -massive[i, j] : massive[i, j];
                    }
                }
            }
            return massive;
        }

        public static int[,] Task2(int [,] mas)
        {
            // Задание 2

            int factor = 0; // множитель.

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                factor++;
                int number = 0; // обнуляем число прибавления каждый цикл.
                number += factor;

                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = mas[i, j] + number;
                    number += factor; // добавляем к тому что есть множитель для увеличения цифры.
                }
            }
            return mas;
        }

        public static int[,] Task3(int[,] mas)
        {   // Задание 3

            bool black = true; // черная клетка да/нет
            for (int i = mas.GetLength(0) - 1; i >= 0; i--)
            {
                // тернарник для определение четности или не четности доски
                // добавяет смещение белого и черного.
                black = mas.GetLength(0) % 2 == 0 ? black = !black : black;

                for (int j = mas.GetLength(1) - 1; j >= 0; j--)
                {
                    if (black)
                    {
                        mas[i, j] = 0;
                        black = false;
                    }
                    else
                    {
                        mas[i, j] = 1;
                        black = true;
                    }
                }
            }
            return mas;
        }

        public static void Task4(int[,] massive)
        {
            Console.WriteLine();
            Console.Write("Результат: ");
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < massive.GetLength(1); j++)
                {

                    if (j > 0 && j < massive.GetLength(1) - 1)
                    {

                        if (massive[i, j] == 1 && (massive[i, j] == massive[i, j - 1] || massive[i, j] == massive[i, j + 1]))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{massive[i, j]}\t");
                            Console.ResetColor();

                            //break; // Для условия остановки цикла по ТЗ
                        }
                        else
                        {
                            Console.Write($"{massive[i, j]}\t");
                        }
                    }
                    else
                    {
                        Console.Write($"{massive[i, j]}\t");
                    }

                }
                //break; // Для условия остановки цикла по ТЗ
            }
        }

        public static void Task5()
        {   // Задание 5

            // Создание таблицы 10 магазинов.
            double[,] massive = new double[10, 6];
            Random rnd = new Random();
            Console.Write("Массив: ");
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i, j] = rnd.NextDouble() * rnd.Next(100, 645);
                    Console.Write($"{massive[i, j]:f2}\t");
                }
            }

            // Решение задачи.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nРезультаты решения задачи:");
            Console.ResetColor(); // сбрасываем в стандартный

            for (int i = 0; i < massive.GetLength(0); i++)
            {
                double minCash = massive[i, 0]; // минимальный доход за месяц
                double maxCash = massive[i, 0]; // максимальынй доход за месяц
                double totalCash = 0; // Общий доход.

                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    // суммарный доход по магазинам
                    totalCash += massive[i, j];
                    // Захотелось сделать тернарный для красоты кода.
                    minCash = massive[i, j] < minCash ? minCash = massive[i, j] : minCash;
                    maxCash = massive[i, j] > maxCash ? maxCash = massive[i, j] : maxCash;
                }

                Console.WriteLine($"Магазин {i + 1} - " +
                    $"Суммарный доход: {totalCash:f2}\t " +
                    $"Средний доход: {totalCash / massive.GetLength(1):f2}\t " +
                    $"Доход - Min:{minCash:f2} |  Max:{maxCash:f2}");
            }
        }

        public static int Task6(int[,] massive)
        {
            int count = 0;
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    int summa = 0;

                    if (i != 0 && j != massive.GetLength(0) - 1 && j != 0 && i != massive.GetLength(1) - 1)
                    {
                        summa = massive[i, j - 1] + massive[i, j + 1] + massive[i - 1, j] + massive[i + 1, j];
                        Console.Write($"{massive[i, j]}({summa})\t");

                        if (massive[i, j] > summa) count++;
                    }
                }
            }
            return count;
        }

        public static int[,] Task7(int[,] mas)
        {   // Задание 7

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i <= mas.GetLength(0) - j - 1 && i <= j || i >= j && i >= mas.GetLength(0) - j - 1)
                    {
                        mas[i, j] = 1;
                    }
                    else
                    {
                        mas[i, j] = 0;
                    }
                }
            }
            return mas;
        }

        public static (int[,],bool) Task8(int[,] a, int[,] b)
        {   // Задание 8
            bool flag_error = false;
            // Создаем матрицу для складывания результата.
            int[,] c = new int[a.GetLength(0), b.GetLength(1)];

            if (a.GetLength(0) != b.GetLength(1))
            {
                flag_error = true;
                return (c ,flag_error);
            }
            else
            {
                // Старт алгоритма.
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < b.GetLength(1); j++)
                    {
                        for (int k = 0; k < b.GetLength(0); k++)
                        {
                            c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                return (c, flag_error);
            }

        }
    }
}
