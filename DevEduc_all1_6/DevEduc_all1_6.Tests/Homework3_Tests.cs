using NUnit.Framework;
using System;

namespace DevEduc_all1_6.Tests
{
    class Homework3_Tests
    {
        [TestCase(6, 4, 10)]
        [TestCase(4, 10, -6)]
        [TestCase(6, 6, 36)]
        [TestCase(-4, 60, -64)]
        [TestCase(12, -5, 7)]
        public void Task1_Tests(double a, double b, double expected)
        {
            Assert.AreEqual(expected, Homework3.Task1(a, b));
        }

        [TestCase(4, 1, 1)]
        [TestCase(4.1, -6, 2)]
        [TestCase(-6, -4.2, 3)]
        [TestCase(-1.2, 2, 4)]
        [TestCase(1, 0, 0)]
        public void Task2_Tests(double a, double b, int expected)
        {
            Assert.AreEqual(expected, Homework3.Task2(a, b));
        }

        [TestCase(45, 2, 13, "Результат: 45, 13, 2")]
        [TestCase(4, -6, 2, "Результат: 4, 2, -6")]
        [TestCase(-6, -4, 3, "Результат: 3, -4, -6")]
        [TestCase(-1, 22, 4, "Результат: 22, 4, -1")]
        [TestCase(672, -1, 321, "Результат: 672, 321, -1")] 
        [TestCase(2, 2, 45, "Есть равные числа! Нет возможности их приритета!")]
        public void Task3_Tests(double a, double b, double c, string expected)
        {
            Assert.AreEqual(expected, Homework3.Task3(a, b, c));
        }

        [TestCase(1, 2, 3, "Корней уравнения нет")]
        [TestCase(-2, 3, 4, "2 корня уравнения: -3,4031242374328485 и 9,403124237432849")]
        [TestCase(44, 3, -1, "2 корня уравнения: 233,23235119217978 и -365,2323511921798")]
        [TestCase(6, 12, 6, "Корень уравнения: -36")]
        [TestCase(672, -1, 321, "Корней уравнения нет")]
        public void Task4_Tests(double a, double b, double c, string expected)
        {
            Assert.AreEqual(expected, Homework3.Task4(a, b, c));
        }

        [TestCase(12, "двенадцать")]
        [TestCase(44, "сорок четыре")]
        [TestCase(32, "тридцать два")]
        [TestCase(13, "тринадцать")]
        [TestCase(78, "семдесят восемь")]
        public void Task5_Tests(int a, string expected)
        {
            Assert.AreEqual(expected, Homework3.Task5(a));
        }
       

        [TestCase(1, 2, 3, "Треугольника нет")]
        [TestCase(-3, 7, 4, "Треугольника нет")]
        [TestCase(4, 5, 4, "Треугольник есть")]
        [TestCase(14, 9, 10, "Треугольник есть")]
        [TestCase(7, 8, 18, "Треугольник есть")]
        public void Task6_Tests(double a, double b, double c, string expected)
        {
            Assert.AreEqual(expected, Homework3.Task6(a, b, c));
        }


        //  NEGATIVE TESTS 

        [TestCase(3444)]
        [TestCase(3)]
        public void Task3_NegativeTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework3.Task5(a));
        }
    }
}
