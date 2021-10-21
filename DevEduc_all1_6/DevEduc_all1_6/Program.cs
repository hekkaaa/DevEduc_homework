using System;

namespace DevEduc_all1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework1

            // Task1
            Console.WriteLine($"Привет, {Homework1.Task1().Item1}");
            Console.WriteLine($"{Homework1.Task1().Item1} + {Homework1.Task1().Item2} = {Homework1.Task1().Item1 + Homework1.Task1().Item2}");
            Console.Write($"Пока, {Homework1.Task1().Item2}");
            Console.ReadKey();
            Console.Clear();

            // Task2
            var res = IOHelper.InputTwoDoubleNumber();
            Console.Write($"Ответ: {Homework1.Task2(res.Item1, res.Item2)}");
            Console.ReadKey();
            Console.Clear();

            // Task3
            (string, string) res1 = IOHelper.InputStringValue();
            Console.WriteLine($"Результат ДО - s1: {res1.Item1} | s2: {res1.Item2}");
            (string, string) res1_1 = Homework1.Task3(res1.Item1, res1.Item2);
            Console.Write($"Результат ПОСЛЕ - s1: {res1_1.Item1} | s2: {res1_1.Item2}");
            Console.ReadKey();
            Console.Clear();

            // Task4
            var res4 = IOHelper.InputTreeIntNumber();
            Console.WriteLine($"X Равен: {Homework1.Task4(res4.Item1, res4.Item2, res4.Item3)}");
            Console.ReadKey();
            Console.Clear();

            // Task5 
            Console.WriteLine("Введите целое число x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            (int, int) res5 = Homework1.Task5(x1, y1, x2, y2);
            Console.WriteLine($"y = {res5.Item1}*x + {res5.Item2}");
            Console.ReadKey();
            Console.Clear();

            // Task6

            var res6 = IOHelper.InputTreeIntNumber();
            var res6_1 = Homework1.Task6(res6.Item1, res6.Item2, res6.Item3);
            if (res6_1.Item4 == true)
            {
                Console.WriteLine($"Дискриминант: {res6_1.Item1}");
                Console.WriteLine($"Корень x1: {res6_1.Item2}");
                Console.WriteLine($"Корень x2: {res6_1.Item3}");
            }
            else
            {
                Console.WriteLine("Дискриминант меньше 0. Введите другие числа.");
            }

        }
    }
}
