﻿using System;

namespace DevEduc_all1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //******************************************
            // AHTUNG!!! Начиная с Homework2 идет нейминг переменных по следующей логике:
            // <name>_2(номер homework)_1(номер Task)_3(номер если подобных переменных нужно более 1шт)
            // СДЕЛАНО Т.К РАЗОМ ВСЕ НЕ ЗАРАБОТАЕТ. УВЫ НА МЕТОДЫ НЕ РАЗБИТЬ.
            //******************************************


            //// Homework1

            //// Task1
            //Console.WriteLine($"Привет, {Homework1.Task1().Item1}");
            //Console.WriteLine($"{Homework1.Task1().Item1} + {Homework1.Task1().Item2} = {Homework1.Task1().Item1 + Homework1.Task1().Item2}");
            //Console.Write($"Пока, {Homework1.Task1().Item2}");
            //Console.ReadKey();
            //Console.Clear();

            //// Task2
            //double input2 = IOHelper.InputDouble("Введите число A");
            //double input2_1 = IOHelper.InputDouble("Введите число Б");
            //Console.Write($"Ответ: {Homework1.Task2(input2, input2_1)}");
            //Console.ReadKey();
            //Console.Clear();

            //// Task3
            //string input3 = IOHelper.InputString("Введите слово\\символ 1:");
            //string input3_1 = IOHelper.InputString("Введите слово\\символ 2:");
            //Console.WriteLine($"Результат ДО - s1: {input3} | s2: {input3_1}");
            //(string, string) res3 = Homework1.Task3(input3, input3_1);
            //Console.Write($"Результат ПОСЛЕ - s1: {res3.Item1} | s2: {res3.Item2}");
            //Console.ReadKey();
            //Console.Clear();

            //// Task4
            //int input4 = IOHelper.InputInt("Введите число A");
            //int input4_1 = IOHelper.InputInt("Введите число Б");
            //int input4_2 = IOHelper.InputInt("Введите число С");

            //Console.WriteLine($"X Равен: {Homework1.Task4(input4, input4_1, input4_2)}");
            //Console.ReadKey();
            //Console.Clear();

            //// Task5 

            //int x1 = IOHelper.InputInt("Введите целое число x1:");
            //int y1 = IOHelper.InputInt("Введите целое число y1:");
            //int x2 = IOHelper.InputInt("Введите целое число x2:");
            //int y2 = IOHelper.InputInt("Введите целое число y2:");

            //(int, int) res5 = Homework1.Task5(x1, y1, x2, y2);
            //Console.WriteLine($"y = {res5.Item1}*x + {res5.Item2}");
            //Console.ReadKey();
            //Console.Clear();

            //// Task6

            //int input6 = IOHelper.InputInt("Введите число A");
            //int input6_1 = IOHelper.InputInt("Введите число Б");
            //int input6_2 = IOHelper.InputInt("Введите число С");
            //var res6 = Homework1.Task6(input6, input6_1, input6_2);
            //if (res6.Item4 == true)
            //{
            //    Console.WriteLine($"Дискриминант: {res6.Item1}");
            //    Console.WriteLine($"Корень x1: {res6.Item2}");
            //    Console.WriteLine($"Корень x2: {res6.Item3}");
            //}
            //else
            //{
            //    Console.WriteLine("Дискриминант меньше 0. Введите другие числа.");
            //}
            //Console.ReadKey();
            //Console.Clear();

            ////******************************************
            //// Homework 2

            //// Task 1
            //var res_2_1 = Homework2.Task1();
            //Console.WriteLine($"{res_2_1.Item1} = {res_2_1.Item2 + res_2_1.Item3 + res_2_1.Item4} ({res_2_1.Item4}+{res_2_1.Item3}+{res_2_1.Item2})");
            //Console.ReadKey();
            //Console.Clear();

            ////Task 2

            //double input_2 = IOHelper.InputDouble("Введите целое число координат x");
            //double input_2_2 = IOHelper.InputDouble("Введите целое число координат y");
            //bool res_2_2 = Homework2.Task2(input_2, input_2_2);
            //Console.WriteLine(res_2_2);
            //Console.ReadKey();
            //Console.Clear();

            //// Task 3

            //int input_2_3 = IOHelper.InputInt("Введите целое трехзначное число");
            //var res_2_3 = Homework2.Task3(input_2_3);
            //Console.WriteLine($"{res_2_3.Item1} ({res_2_3.Item2})");
            //Console.ReadKey();
            //Console.Clear();

            //// Task 4

            //int input_2_4 = IOHelper.InputInt("Введите целое трехзначное число");
            //var res_4 = Homework2.Task4(input_2_4);
            //Console.WriteLine($"{res_4.Item1} -> {res_4.Item2}");
            //Console.ReadKey();
            //Console.Clear();

            //// Task 5
            //// В задании условия запроса от пользователя нет. По этому хардкод.
            //var res_2_5 = Homework2.Task5();
            //Console.WriteLine($"{res_2_5.Item1} ({res_2_5.Item2})");
            //Console.ReadKey();
            //Console.Clear();


            ////******************************************
            //// Homework 3

            //// Task 1
            //double input_4_1_1 = IOHelper.InputDouble("Введите число A: ");
            //double input_4_1_2 = IOHelper.InputDouble("Введите число B: ");
            //double res_3_1 = Homework3.Task1(input_4_1_1, input_4_1_2);
            //Console.WriteLine($"Результат: {res_3_1}");
            //Console.ReadKey();
            //Console.Clear();

            //// Task 2

            //double input_3_2_1 = IOHelper.InputDouble("Введите число X: ");
            //double input_3_2_2 = IOHelper.InputDouble("Введите число Y: ");
            //string res_3_2 = Homework3.Task2(input_3_2_1, input_3_2_2);
            //Console.WriteLine(res_3_2);
            //Console.ReadKey();
            //Console.Clear();

            //// Task 3

            //double input_3_3_1 = IOHelper.InputDouble("Введите число A: ");
            //double input_3_3_2 = IOHelper.InputDouble("Введите число B: ");
            //double input_3_3_3 = IOHelper.InputDouble("Введите число C: ");
            //string res_3_3 = Homework3.Task3(input_3_3_1, input_3_3_2, input_3_3_3);
            //Console.WriteLine(res_3_3);
            //Console.ReadKey();
            //Console.Clear();


            //// Task 4

            //double input_3_4_1 = IOHelper.InputDouble("Введите число A: ");
            //double input_3_4_2 = IOHelper.InputDouble("Введите число B: ");
            //double input_3_4_3= IOHelper.InputDouble("Введите число C: ");
            //string res_3_4 = Homework3.Task4(input_3_4_1, input_3_4_2, input_3_4_3);
            //Console.WriteLine(res_3_4);
            //Console.ReadKey();
            //Console.Clear();


            //// Task 5

            //int input_3_5 = IOHelper.InputInt("Введите целое двухзначеное число. ");
            //string res_3_5 = Homework3.Task5(input_3_5);
            //Console.WriteLine(res_3_5);
            //Console.ReadKey();
            //Console.Clear();

            //// Task 6

            //double input_3_6_1 = IOHelper.InputDouble("Введите число A: ");
            //double input_3_6_2 = IOHelper.InputDouble("Введите число B: ");
            //double input_3_6_3 = IOHelper.InputDouble("Введите число C: ");
            //string res_3_6 = Homework3.Task6(input_3_6_1, input_3_6_2, input_3_6_3);
            //Console.WriteLine(res_3_6);
            //Console.ReadKey();
            //Console.Clear();


            ////******************************************
            //// Homework 4
            
        }
    }
}
