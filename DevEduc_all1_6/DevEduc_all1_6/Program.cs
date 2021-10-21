using System;

namespace DevEduc_all1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework1

            // Task1
            //Console.WriteLine($"Привет, {Homework1.Task1().Item1}");
            //Console.WriteLine($"{Homework1.Task1().Item1} + {Homework1.Task1().Item2} = {Homework1.Task1().Item1 + Homework1.Task1().Item2}");
            //Console.Write($"Пока, {Homework1.Task1().Item2}");

            // Task2
            //var res = IOHelper.InputDoubleNumber();
            //Console.Write($"Ответ: {Homework1.Task2(res.Item1,res.Item2)}");

            // Task3
            
            (string, string) res1 = IOHelper.InputStringValue(); // тут проще var использовать.
            Console.WriteLine($"Результат ДО - s1: {res1.Item1} | s2: {res1.Item2}");
            (string, string) res12 = Homework1.Task3(res1.Item1, res1.Item2);
            Console.Write($"Результат ПОСЛЕ - s1: {res12.Item1} | s2: {res12.Item2}");
        }
    }
}
