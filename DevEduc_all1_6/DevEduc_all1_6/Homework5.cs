using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{   
    class Homework5
    {
        static Random rnd = new Random();
        static void Task1()
        {   // Задание 1
            rnd.Next(1, 2);
            // Создание и наполнение массива.
            // Оно будет повторятся в подобных заданиях отдельно СПЕЦИАЛЬНО.
            int[] mas = new int[10];
            Console.Write("Массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 100);

                Console.Write($"{mas[i]} "); // Выводим информацию о массиве.
            }
            Console.WriteLine();
            // *****


            // Посчет четных и нечетных чисел.
            int countEven = 0;
            int countOdd = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                int res = mas[i] % 2;
                if (res == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }

            Console.WriteLine($"Четных: {countEven}\nНечетных: {countOdd}");
        }

        static void Task2()
        {   // Задание 2

            // Создание и наполнение массива.
            // Оно будет повторятся в подобных заданиях отдельно СПЕЦИАЛЬНО.
            int[] mas = new int[40];
            Console.Write("Массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 100);

                Console.Write($"{mas[i]} "); // Выводим информацию о массиве.
            }
            Console.WriteLine();
            // *****

            for (int i = 2; i < mas.Length; i += 2)
            {
                int oldResult = mas[i];
                mas[i] = mas[i - 1] + mas[i - 2];

                Console.WriteLine($"Index:{i} | Old_Result:{oldResult} / New_Result:{mas[i]}");
            }
        }

        static void Task3()
        {   // Задание 3
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };

            int[] z = new int[a.Length + b.Length]; // устанавливаем длинну
            a.CopyTo(z, 0);
            b.CopyTo(z, a.Length); // копируем с 5 индекса.
            // PROFIT!
        }

        static void Task4()
        {   // Задание 4

            // Создание и наполнение массива.
            // Оно будет повторятся в подобных заданиях отдельно СПЕЦИАЛЬНО.
            int randomIndex = rnd.Next(5, 20);
            int[] mas = new int[randomIndex]; // рандомная длина массива в пределах 20.
            Console.Write("Массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 100);

                Console.Write($"{mas[i]} "); // Выводим информацию о массиве.
            }
            Console.WriteLine();
            // *****

            int center = mas.Length / 2; // получаем "условную" середину массив
            int[] resultMassive = new int[mas.Length]; // новый массив. 
            int count = 0; // счетчик.

            // вторая половинка массива mas переходит в 1 часть.
            for (int i = center; i < mas.Length; i++)
            {
                resultMassive[count] = mas[i];
                count++;
            }

            // первая половинка mas переходит во 2 часть нового массива.
            // значение count не меняется.
            for (int i = 0; i < center; i++)
            {
                resultMassive[count] = mas[i];
                count++;
            }

            Console.Write("Новый массив: ");
            for (int i = 0; i < resultMassive.Length; i++)
            {
                Console.Write($"{resultMassive[i]} ");
            }
        }

        static void Task5()
        {
            int N = 3; // количество смещений. Укажите нужное количество
            int count = 1; // счетчик.

            int[] mas = { 1, 2, 3, 4, 5, 6 };
            int t = mas[mas.Length - 1];
            for (int i = mas.Length - 1; i > 0; i--)
            {
                mas[i] = mas[i - 1];
            }
            mas[0] = t;

            // Вывод информации в консоль
            Console.Write("Со смещением на 1 позинию: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }


            // Цикл для смещения
            while (count <= N)
            {
                t = mas[mas.Length - 1];
                for (int i = mas.Length - 1; i > 0; i--)
                {
                    mas[i] = mas[i - 1];
                }
                mas[0] = t;
                count++;
            }

            Console.WriteLine(); // ENTER
            Console.Write($"После смещений на N позиций: ");
            // Вывод информации в консоль
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
        }

        static void Task6()
        { // Задание 6
            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < mas.Length; i += 2)
            {
                int tmp = mas[i];
                mas[i] = mas[i + 1];
                mas[i + 1] = tmp;

            }

            Console.Write("Новый массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }


        }

        static void Task7()
        { // Задача 7

            // В задаче указано что отрицательные значения будут ВКЛЮЧИТЕЛЬНО
            int[] mas = { 5, 15, -2, 3, -1, 8, -10, 0, 1, 10, 4, -6, 1 };

            int min = 0; // для поиска минимального значения.
            int res = 0; // для суммы чисел после 0
            for (int i = 0; i < mas.Length; i++)
            {   // ищем минимальное.
                if (mas[i] < min)
                {
                    min = mas[i];
                }
                else if (mas[i] == 0)
                {
                    // цикл для поиска 
                    int count = i; // счетчик для внутреннего цикла
                    while (count < mas.Length)
                    {
                        res += mas[count];
                        count++;
                    }
                }

            }
            Console.WriteLine($"Сумма результата после 0 = {res}");
            Console.WriteLine($"Минимально значение: {min}");
        }

        static void Task8()
        {
            // Задание 8
            // Создание и наполнение массива.
            // Оно будет повторятся в подобных заданиях отдельно СПЕЦИАЛЬНО.
            int[] mas = new int[10];
            Console.Write("Массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 100);

                Console.Write($"{mas[i]} "); // Выводим информацию о массиве.
            }
            Console.WriteLine();
            Console.Write("После:  ");
            // *****

            for (int i = 1; i < mas.Length; i++)
            {
                int j = i;

                while ((j > 0) && (mas[j - 1] > mas[i]))
                {
                    var temp = mas[i];
                    mas[i] = mas[j - 1];
                    mas[j - 1] = temp;
                    j--;
                    i--;
                }
            }

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }

        }

        static void Task9()
        {
            // Задание 8
            // Создание и наполнение массива.
            // Оно будет повторятся в подобных заданиях отдельно СПЕЦИАЛЬНО.
            int[] mas = new int[10];
            Console.Write("Массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-10, 100);

                Console.Write($"{mas[i]} "); // Выводим информацию о массиве.
            }
            Console.WriteLine();
            Console.Write("После:  ");
            // *****

            for (int i = 0; i < mas.Length; i++)
            {
                int min_pos = i; // Минимальная позиция.
                int min_value = mas[i]; // минимальное значение.

                // Ищем минимальный индекс минимального значения.
                for (int j = i + 1; j < mas.Length; j++)
                {
                    // Если значение следующей индекса меньше текущего i то нашли минимальный.
                    if (mas[j] < min_value)
                    {
                        min_pos = j;
                        min_value = mas[j];
                    }
                }
                mas[min_pos] = mas[i]; // назначаем найденой позиции минимального значения - значение текущего i 
                mas[i] = min_value; // а текущему i даем значение(литерал) найденого самого маленького из диапазона i - max.length
            }

            // Вывод информации в консоль
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
        }
    }
}
