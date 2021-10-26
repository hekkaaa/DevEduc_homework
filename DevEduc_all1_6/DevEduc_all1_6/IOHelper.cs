using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    class IOHelper
    {
        static Random rnd = new Random();
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
       
        public static int[] ArrayRandomInt (int length, int minRnd, int maxRnd)
        // length - длинна массива. minRnd\maxRnd - минимально значение и макксимальное в Random
        {
            // Создание и наполнение массива.
            // Оно будет повторятся в подобных заданиях отдельно СПЕЦИАЛЬНО.
            int[] mas = new int[length];
            Console.Write("Массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(minRnd, maxRnd);

                Console.Write($"{mas[i]} "); // Выводим информацию о массиве.
            }
            Console.WriteLine();
            return mas;

        }

        // Двумерный рандомный массив.
        public static int[,] array2DRandomInt(int line, int сolumns, int rangeStart, int rangeEnd)
        {
            // line - строка. сolumns - столбец 
            // rangeStart - старт диапазона рандома. rangeEnd - конец

            int[,] mas = new int[line, сolumns];

            Console.WriteLine("Стартовый Двумерный массив: ");
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

        // Пустой Двумерный рандомный массив.
        public static int[,] Array2dEmptyInt(int line, int сolumns)
        {
            // line - строка. сolumns - столбец 
            int[,] mas = new int[line, сolumns];
            return mas;
        }

        // Выводит в консоль массив в одну строчку.
        public static void WriteArray(int[] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write($"{massive[i]} ");
            }
        }

        // Выводит в консоль двумерный массив.
        public static void Write2DArray(int[,] massive) { 
        // Вывод информации о массиве
        Console.WriteLine("\nРезультат: ");
            for (int i = 0; i<massive.GetLength(0); i++)
            {
                for (int j = 0; j<massive.GetLength(1); j++)
                {
                    Console.Write($"{massive[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        // *** Оставлю на всякий случай. В ДЗ не используется.
        //private static void TestRandomArray(int minLenght, int maxLenght, int minRnd, int maxRnd)
        //{
        //    // Создание и наполнение массива рандомной длинны.
        //    int randomIndex = rnd.Next(minLenght, maxLenght);
        //    int[] mas = new int[randomIndex]; // рандомная длина массива в пределах maxLenght.
        //    Console.Write("Массив: ");
        //    for (int i = 0; i < mas.Length; i++)
        //    {
        //        mas[i] = rnd.Next(minRnd, maxRnd);

        //        Console.Write($"{mas[i]} "); // Выводим информацию о массиве.
        //    }
        //    Console.WriteLine();
        //    // *****
        //}



    }
}
