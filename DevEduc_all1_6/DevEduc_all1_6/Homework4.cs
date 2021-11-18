using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    public class Homework4
    {
        public static List<int> Task1(double a)
        {   
            if(a < 1 || a > 1000)
            {
                throw new ArgumentOutOfRangeException();
            }

            List<int> list = new List<int>();   
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static int Task2(double a)
        {
            double n = 0;
            int count = 1;

            while (n < a)
            {
                n = count * count;

                if (n < a)
                {
                    count++;
                }
            }
            // -1 из-за лишней итерации цифры равной или близкой введеной А. 
            count--;
            return count;

            // РЕШЕНИЕ БЕЗ ЦИКЛА
            //int g = (int)Math.Sqrt(A);
            //Console.WriteLine(g);
        }

        public static int Task3(double a)
        {
            int res = (int)a / 2;
            return res;
        }

        public static int Task4(double a, double b)
        {
            int res = 0;
            if (a > b)
            {
                double tmp = b;
                b = a;
                a = tmp;
            }

            for (int i = (int)a; i <= b; i++)
            {
                int formula = i % 7;

                if (formula == 0)
                {
                    res += i;
                }
            }
            return res;
        }

        public static int Task5(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            int c = a + b;
            return c;
        }

        public static int Task6(int n)
        {
            // Задание 6
            int leftLimit = 0; // Левый предел
            int rightLimit = n; // правый предел
            int center = 1; // число в центре

            if(n < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            // leftLimit != center && leftLimit < rightLimit - 1 // leftLimit != center 
            while (leftLimit != center || leftLimit < rightLimit - 1 )
            {   
                center = (leftLimit + rightLimit) / 2;
           
                if (Math.Pow(center, 3) == n)
                {
                    break;
                }
                else if (Math.Pow(center, 3) > n)
                {
                    rightLimit = center;
                }
                else
                {
                    leftLimit = center;
                }
            }
            return center; 
        }

        public static int Task7(int a)
        {
            int count = 0; //счетчик для нечетных чисел

            if (a.ToString().Length < 5 || a.ToString().Length > 8)
            {
                throw new ArgumentOutOfRangeException();
            }

            while (a > 0)
            {
                int result = 0;
                result += a % 10;
                a /= 10;

                if (result % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int Task8(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            return result;
        }

        public static List<int> Task9(int a)
        {   
            if(a < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            // Главный цикл.
            List<int> list = new List<int>();

            for (int i = 1; i <= a; i++)
            {
                int circle = i; // копируем для дальнейшего использования.
                int number_even = 0; // для четного
                int number_odd = 0; // для нечетного

                while (circle > 0)
                {
                    int number = circle % 10; // берем по 1 цифре из числа.

                    if (number % 2 == 0)
                    {
                        number_even += number;
                    }
                    else
                    {
                        number_odd += number;
                    }

                    circle /= 10; // Узнаем есть ли еще цифры в остатке.
                }
                
                if (number_even > number_odd) list.Add(i);

            }
            return list;
        }

        public static string Task10(int a, int b)
        {
            bool flag_end = false; // флаг для остановки

            while (flag_end != true)
            {
                if (a == 0)
                {
                    flag_end = true; 
                    return "НЕТ";
                }

                int number1 = a % 10;
                a = a / 10;
                int b_copy = b; // Копия для переиспользования.

                while (b > 0)
                {
                    int number2 = b_copy % 10;
                    b_copy = b_copy / 10;

                    if (number1 == number2)
                    {
                        
                        flag_end = true;
                        return "ДА";
                    }
                    if (b_copy == 0) break;
                }
            }
            return "PASS"; // Заглушка.
        }
    }
}
