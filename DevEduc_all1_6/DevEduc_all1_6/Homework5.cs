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
        public static (int,int) Task1(int[] mas)
        {   // Задание 1
          
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
            return (countEven, countOdd);
        }

        public static void Task2(int[] mas)
        {   // Задание 2

            for (int i = 2; i < mas.Length; i += 2)
            {
                int oldResult = mas[i];
                mas[i] = mas[i - 1] + mas[i - 2];

                Console.WriteLine($"Index:{i} | Old_Result:{oldResult} / New_Result:{mas[i]}");
            }
        }

        public static int[] Task3( int[] a, int[] b)
        {   // Задание 3       

            int[] z = new int[a.Length + b.Length]; // устанавливаем длинну
            a.CopyTo(z, 0);
            b.CopyTo(z, a.Length); // копируем с 5 индекса.
            // PROFIT!
            return z;
        }

        public static int[] Task4(int[] mas)
        {   // Задание 4

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
            return resultMassive;
            
           
        }

        public static (int[],int[]) Task5(int N)
        {
            int count = 1; // счетчик.
            // N - длина сдвига

            int[] mas = { 1, 2, 3, 4, 5, 6 };
            int lastNum = mas[mas.Length - 1]; // Берем последнюю цифру в списке.
            for (int i = mas.Length - 1; i > 0; i--)
            {
                mas[i] = mas[i - 1];
            }
            mas[0] = lastNum;

            // Копирование массива для корректного вывода через return вдух массивов.
            int[] newmas = new int[mas.Length];
            mas.CopyTo(newmas, 0);

            // Цикл для смещения
            while (count <= N)
            {
                lastNum = newmas[newmas.Length - 1];
                for (int i = newmas.Length - 1; i > 0; i--)
                {
                    newmas[i] = newmas[i - 1];
                }
                newmas[0] = lastNum;
                count++;
            }
            return (mas, newmas);
        }

        public static int[] Task6()
        { // Задание 6
            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < mas.Length; i += 2)
            {
                int tmp = mas[i];
                mas[i] = mas[i + 1];
                mas[i + 1] = tmp;
            }
            return mas;
        }

        public static (int,int) Task7()
        { // Задача 7

            // В задаче указано что отрицательные значения будут ВКЛЮЧИТЕЛЬНО
            int[] mas = { 5, 15, -2, 3, -1, 8, -10, 0, 1, 10, 4, -6, 1, 20 };
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
            return (res, min);  
        }

        public static int[] Task8(int[] mas)
        {
            // Задание 8

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
            return mas;
        }

        public static int[] Task9(int[] mas)
        {
            // Задание 9

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

            return mas;
        }
    }
}
