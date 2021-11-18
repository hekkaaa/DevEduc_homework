using System;
using System.Collections.Generic;

namespace DevEduc_all1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ////******************************************
            //// AHTUNG!!! Начиная с Homework2 идет нейминг переменных по следующей логике:
            //// <name>_2(номер homework)_1(номер Task)_3(номер если подобных переменных нужно более 1шт)
            //// СДЕЛАНО Т.К РАЗОМ ВСЕ НЕ ЗАРАБОТАЕТ. УВЫ НА МЕТОДЫ НЕ РАЗБИТЬ.
            ////******************************************


            //    //Homework1

            //    // Task1
            //    Console.WriteLine(Homework1.Task1());
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task2
            //    double input2 = IOHelper.InputDouble("Введите число A");
            //    double input2_1 = IOHelper.InputDouble("Введите число Б");
            //    Console.Write($"Ответ: {Homework1.Task2(input2, input2_1)}");
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task3
            //    string input3 = IOHelper.InputString("Введите слово\\символ 1:");
            //    string input3_1 = IOHelper.InputString("Введите слово\\символ 2:");
            //    Console.WriteLine($"Результат ДО - s1: {input3} | s2: {input3_1}");
            //    (string, string) res3 = Homework1.Task3(input3, input3_1);
            //    Console.Write($"Результат ПОСЛЕ - s1: {res3.Item1} | s2: {res3.Item2}");
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task4
            //    int input4 = IOHelper.InputInt("Введите число A");
            //    int input4_1 = IOHelper.InputInt("Введите число Б");
            //    int input4_2 = IOHelper.InputInt("Введите число С");

            //    Console.WriteLine($"X Равен: {Homework1.Task4(input4, input4_1, input4_2)}");
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task5 

            //    int x1 = IOHelper.InputInt("Введите целое число x1");
            //    int y1 = IOHelper.InputInt("Введите целое число y1");
            //    int x2 = IOHelper.InputInt("Введите целое число x2");
            //    int y2 = IOHelper.InputInt("Введите целое число y2");

            //    (int, int) res5 = Homework1.Task5(x1, y1, x2, y2);
            //    Console.WriteLine($"y = {res5.Item1}*x + {res5.Item2}");
            //    Console.ReadKey();
            //    Console.Clear();


            //    // Task6

            //    int input6 = IOHelper.InputInt("Введите число A");
            //    int input6_1 = IOHelper.InputInt("Введите число Б");
            //    int input6_2 = IOHelper.InputInt("Введите число С");
            //    var res6 = Homework1.Task6(input6, input6_1, input6_2);
            //    if (res6.Item4 == true)
            //    {
            //        Console.WriteLine($"Дискриминант: {res6.Item1}");
            //        Console.WriteLine($"Корень x1: {res6.Item2}");
            //        Console.WriteLine($"Корень x2: {res6.Item3}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Дискриминант меньше 0. Введите другие числа.");
            //    }
            //    Console.ReadKey();
            //    Console.Clear();

            //    //******************************************
            //    // Homework 2

            //    // Task 1
            //    var res_2_1 = Homework2.Task1();
            //    Console.WriteLine($"{res_2_1.Item1} = {res_2_1.Item2 + res_2_1.Item3 + res_2_1.Item4} ({res_2_1.Item4}+{res_2_1.Item3}+{res_2_1.Item2})");
            //    Console.ReadKey();
            //    Console.Clear();

            //    //Task 2

            //    double input_2 = IOHelper.InputDouble("Введите целое число координат x");
            //    double input_2_2 = IOHelper.InputDouble("Введите целое число координат y");
            //    bool res_2_2 = Homework2.Task2(input_2, input_2_2);
            //    Console.WriteLine(res_2_2);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 3

            //    int input_2_3 = IOHelper.InputInt("Введите целое трехзначное число");
            //    var res_2_3 = Homework2.Task3(input_2_3);
            //    Console.WriteLine($"{res_2_3.Item1} ({res_2_3.Item2})");
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 4

            //    int input_2_4 = IOHelper.InputInt("Введите целое трехзначное число");
            //    var res_4 = Homework2.Task4(input_2_4);
            //    Console.WriteLine($"{res_4.Item1} -> {res_4.Item2}");
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 5
            //    // В задании условия запроса от пользователя нет. По этому хардкод.
            //    var res_2_5 = Homework2.Task5();
            //    Console.WriteLine($"{res_2_5.Item1} ({res_2_5.Item2})");
            //    Console.ReadKey();
            //    Console.Clear();


            //    //******************************************
            //    // Homework 3

            //    // Task 1
            //    double input_4_1_1 = IOHelper.InputDouble("Введите число A");
            //    double input_4_1_2 = IOHelper.InputDouble("Введите число B");
            //    double res_3_1 = Homework3.Task1(input_4_1_1, input_4_1_2);
            //    Console.WriteLine($"Результат: {res_3_1}");
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 2

            //    double input_3_2_1 = IOHelper.InputDouble("Введите число X");
            //    double input_3_2_2 = IOHelper.InputDouble("Введите число Y");
            //    int res_3_2 = Homework3.Task2(input_3_2_1, input_3_2_2);

            //    if (res_3_2 == 1) Console.WriteLine($"Результат: {res_3_2} четверть");
            //    else if (res_3_2 == 2) Console.WriteLine($"Результат: {res_3_2} четверть");
            //    else if (res_3_2 == 3) Console.WriteLine($"Результат: {res_3_2} четверть");
            //    else if (res_3_2 == 4) Console.WriteLine($"Результат: {res_3_2} четверть");
            //    else { Console.WriteLine("Вы указали 0 в одном из координат. По этому определить четверть затруднительно."); }

            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 3

            //    double input_3_3_1 = IOHelper.InputDouble("Введите число A: ");
            //    double input_3_3_2 = IOHelper.InputDouble("Введите число B: ");
            //    double input_3_3_3 = IOHelper.InputDouble("Введите число C: ");
            //    string res_3_3 = Homework3.Task3(input_3_3_1, input_3_3_2, input_3_3_3);
            //    Console.WriteLine(res_3_3);
            //    Console.ReadKey();
            //    Console.Clear();


            //    // Task 4

            //    double input_3_4_1 = IOHelper.InputDouble("Введите число A: ");
            //    double input_3_4_2 = IOHelper.InputDouble("Введите число B: ");
            //    double input_3_4_3 = IOHelper.InputDouble("Введите число C: ");
            //    string res_3_4 = Homework3.Task4(input_3_4_1, input_3_4_2, input_3_4_3);
            //    Console.WriteLine(res_3_4);
            //    Console.ReadKey();
            //    Console.Clear();


            //    // Task 5

            //    int input_3_5 = IOHelper.InputInt("Введите целое двухзначеное число. ");
            //    string res_3_5 = Homework3.Task5(input_3_5);
            //    Console.WriteLine($"--------\nОтвет: {res_3_5}"); ;
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 6

            //    double input_3_6_1 = IOHelper.InputDouble("Введите число A: ");
            //    double input_3_6_2 = IOHelper.InputDouble("Введите число B: ");
            //    double input_3_6_3 = IOHelper.InputDouble("Введите число C: ");
            //    string res_3_6 = Homework3.Task6(input_3_6_1, input_3_6_2, input_3_6_3);
            //    Console.WriteLine(res_3_6);
            //    Console.ReadKey();
            //    Console.Clear();


            //    //******************************************
            //    // Homework 4

            //    // Task 1

            //    List<int> res_4_1 = Homework4.Task1(IOHelper.InputDouble("Введите число A"));
            //    Console.WriteLine("---------------");
            //    IOHelper.WriteIntList(res_4_1);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 2 
            //    double input_4_2 = IOHelper.InputDouble("Введите число A");
            //    Console.WriteLine("-----------");
            //    int res_4_2 = Homework4.Task2(input_4_2);
            //    Console.WriteLine(res_4_2);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 3 
            //    double input_4_3 = IOHelper.InputDouble("Введите число A");
            //    Console.WriteLine("-----------");
            //    int res_4_3 = Homework4.Task3(input_4_3);
            //    Console.WriteLine($"Наибольший делитель: {res_4_3}");
            //    Console.ReadKey();
            //    Console.Clear();

            //    //Task 4
            //    double input_4_4 = IOHelper.InputDouble("Введите число A: ");
            //    double input_4_4_1 = IOHelper.InputDouble("Введите число B: ");
            //    int res_4_4 = Homework4.Task4(input_4_4, input_4_4_1);

            //    Console.WriteLine("____");
            //    Console.WriteLine($"Сумма чисел: {res_4_4}");

            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 5
            //    int input_4_5 = IOHelper.InputInt("Введите число A");
            //    int input_4_5_1 = IOHelper.InputInt("Введите число B");
            //    int res_4_5 = Homework4.Task5(input_4_5, input_4_5_1);
            //    Console.WriteLine($"Наибольший делитель: {res_4_5}");
            //    Console.ReadKey();
            //    Console.Clear();

            //Task 6
            int input_4_6 = IOHelper.InputInt("Введите любое целое число: ");
            int res_4_6 = Homework4.Task6(input_4_6);
            Console.WriteLine($"Загаданное число = {res_4_6}");
            Console.ReadKey();
            Console.Clear();

            //    // Task 7 
            //    int input_4_7 = IOHelper.InputInt("Введите целое число от 5 до 8 цифр");
            //    int res_4_7 = Homework4.Task7(input_4_7);
            //    Console.WriteLine($"Нечетных чисел: {res_4_7}");
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 8
            //    int input_4_8 = IOHelper.InputInt("Введите любое целое число: ");
            //    int res_4_8 = Homework4.Task8(input_4_8);
            //    Console.WriteLine(res_4_8);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 9
            //    int input_4_9 = IOHelper.InputInt("Введите целое число");
            //    Console.WriteLine("----------");
            //    List<int> res_4_9 = Homework4.Task9(input_4_9);
            //    IOHelper.WriteIntList(res_4_9);

            //    Console.ReadKey();
            //    Console.Clear();


            //    // Task 10
            //    int input_4_10 = IOHelper.InputInt("Введите целое число: ");
            //    int input_4_10_1 = IOHelper.InputInt("Введите еще целое число: ");
            //    Console.WriteLine("----------");
            //    string res_4_10 = Homework4.Task10(input_4_10, input_4_10_1);
            //    Console.WriteLine(res_4_10);
            //    Console.ReadKey();
            //    Console.Clear();

            //    //******************************************
            //    // Homework 5

            //    // Task1 
            //    int[] input_5_1 = IOHelper.ArrayRandomInt(20, 1, 20);
            //    var res_5_1 = Homework5.Task1(input_5_1);
            //    Console.WriteLine($"Четных: {res_5_1.Item1}\nНечетных: {res_5_1.Item2}");
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 2
            //    int[] input_5_2 = IOHelper.ArrayRandomInt(40, 1, 100);
            //    int[] res_5_2 = Homework5.Task2(input_5_2);
            //    IOHelper.WriteArray(res_5_2);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 3
            //    int[] input_5_3 = IOHelper.ArrayRandomInt(6, 1, 10);
            //    int[] input_5_3_1 = IOHelper.ArrayRandomInt(6, 1, 20);
            //    int[] res_5_3 = Homework5.Task3(input_5_3, input_5_3_1);
            //    Console.WriteLine("\nНовый массив: ");
            //    IOHelper.WriteArray(res_5_3);
            //    Console.WriteLine();
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 4
            //    int[] input_5_4 = IOHelper.ArrayRandomInt(12, 1, 100);
            //    int[] res_5_4 = Homework5.Task4(input_5_4);
            //    Console.Write("Новый массив: ");
            //    IOHelper.WriteArray(res_5_4);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 5
            //    var res_5_5 = Homework5.Task5(2);
            //    Console.Write("Со смещением на 1 позинию: ");
            //    IOHelper.WriteArray(res_5_5.Item1);
            //    // В задании стоит: А после этого сделать циклический сдвиг вправо на N элементов.
            //    // Т.е мы двигаем уже сдвинутый на 1 позицию ранее массив.
            //    Console.Write($"\nПосле смещений на N позиций: ");
            //    IOHelper.WriteArray(res_5_5.Item2);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 6
            //    int[] res_5_6 = Homework5.Task6(IOHelper.ArrayRandomInt(13, 1, 40));
            //    Console.Write("Новый массив: ");
            //    IOHelper.WriteArray(res_5_6);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 7
            //    var res_5_7 = Homework5.Task7(IOHelper.ArrayRandomInt(10, -10, 20));
            //    Console.WriteLine($"Сумма результата после 0 = {res_5_7.Item2}");
            //    Console.WriteLine($"Минимально значение: {res_5_7.Item1}");
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 8
            //    int[] input_5_8 = IOHelper.ArrayRandomInt(10, 1, 100);
            //    int[] res_5_8 = Homework5.Task8(input_5_8);
            //    Console.Write("\nРезультат: ");
            //    IOHelper.WriteArray(res_5_8);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 9
            //    int[] input_5_9 = IOHelper.ArrayRandomInt(10, 1, 100);
            //    int[] res_5_9 = Homework5.Task9(input_5_9);
            //    Console.Write("\nРезультат: ");
            //    IOHelper.WriteArray(res_5_9);
            //    Console.ReadKey();
            //    Console.Clear();

            //    //******************************************
            //    // Homework 6

            //    // Task 1
            //    int[,] res_6_1 = Homework6.Task1(IOHelper.array2DRandomInt(5, 8, -99, 40));
            //    IOHelper.Write2DArray(res_6_1);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 2
            //    int[,] res_6_2 = Homework6.Task2(IOHelper.Array2dEmptyInt(9, 9));
            //    IOHelper.Write2DArray(res_6_2);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 3
            //    // Если указать не симметричный размер 8 на 9 например, работать не будет нормально.
            //    int[,] res_6_3 = Homework6.Task3(IOHelper.Array2dEmptyInt(10, 9));
            //    IOHelper.Write2DArray(res_6_3);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 4
            //    bool res_6_4 = Homework6.Task4(IOHelper.array2DRandomInt(6, 6, 0, 2));
            //    if (res_6_4)
            //    {
            //        Console.WriteLine("\nНайдены рядом сидящие посетители");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nВсе нормы соблюдены");
            //    }
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 5
            //    var res_6_5 = Homework6.Task5(IOHelper.Array2dEmptyDoble(10, 6));

            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("\n\nРезультаты решения задачи:");
            //    Console.ResetColor(); // сбрасываем в стандартный

            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine($"Магазин {i + 1} - " +
            //        $"Суммарный доход: {res_6_5.Item1[i]:f2}\t " +
            //        $"Средний доход: {res_6_5.Item1[i] / 6:f2}\t " +
            //        $"Доход - Min:{res_6_5.Item2[i, 0]:f2} |  Max:{res_6_5.Item2[i, 1]:f2}");
            //    }
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 6
            //    int res_6_6 = Homework6.Task6(IOHelper.array2DRandomInt(9, 8, -10, 50));
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine($"\nРезультат: {res_6_6}");
            //    Console.ResetColor(); // сбрасываем в стандартный
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 7
            //    int[,] res_6_7 = Homework6.Task7(IOHelper.Array2dEmptyInt(7, 7));
            //    IOHelper.Write2DArray(res_6_7);
            //    Console.ReadKey();
            //    Console.Clear();

            //    // Task 8
            //    int[,] input_6_8 = IOHelper.array2DRandomInt(5, 5, 1, 20);
            //    int[,] input_6__1 = IOHelper.array2DRandomInt(5, 5, 1, 20);
            //    var res_6_8 = Homework6.Task8(input_6_8, input_6__1);
            //    IOHelper.Write2DArray(res_6_8);

            //    Console.ReadKey();
            //    Console.Clear();
        }
    }
}
