using NUnit.Framework;

namespace DevEduc_all1_6.Tests
{
    class Homework4_Tests
    {
        [TestCase(6, 2)]
        [TestCase(4, 1)]
        [TestCase(27, 5)]
        [TestCase(78, 8)]
        [TestCase(123, 11)]
        public void Task2_Tests(double a, int expected)
        {
            Assert.AreEqual(expected, Homework4.Task2(a));
        }

        [TestCase(6, 3)]
        [TestCase(44, 22)]
        [TestCase(400, 200)]
        [TestCase(8, 4)]
        [TestCase(-12, -6)]
        public void Task3_Tests(double a, int expected)
        {
            Assert.AreEqual(expected, Homework4.Task3(a));
        }

        [TestCase(1, 70, 385)]
        [TestCase(4.5, 6, 0)]
        [TestCase(400, 200, 8729)]
        [TestCase(-21, 4, -42)]
        [TestCase(-7, -13, -7)]
        public void Task4_Tests(double a, double b, int expected)
        {
            Assert.AreEqual(expected, Homework4.Task4(a,b));
        }

        [TestCase(50, 130, 10)]
        [TestCase(33, 10, 1)]
        [TestCase(222, 54, 6)]
        [TestCase(6, 4, 2)]
        [TestCase(261, 45, 9)]
        public void Task5_Tests(int a, int b, int expected)
        {
            Assert.AreEqual(expected, Homework4.Task5(a, b));
        }

        [TestCase(5, 1)]
        [TestCase(8, 2)]
        [TestCase(1728, 12)]
        [TestCase(625, 5)]
        [TestCase(12, 2)]
        public void Task6_Tests(int a,int expected)
        {
            Assert.AreEqual(expected, Homework4.Task6(a));
        }

        [TestCase(233441, 3)]
        [TestCase(565888, 2)]
        [TestCase(11325799, 7)]
        [TestCase(32468848, 1)]
        [TestCase(987654321, 5)]
        public void Task7_Tests(int a, int expected)
        {
            Assert.AreEqual(expected, Homework4.Task7(a));
        }

        [TestCase(233441, 144332)]
        [TestCase(223, 322)]
        [TestCase(280, 82)]
        [TestCase(12, 21)]
        [TestCase(4572, 2754)]
        public void Task8_Tests(int a, int expected)
        {
            Assert.AreEqual(expected, Homework4.Task8(a));
        }

        [TestCase(213, 144332, "ДА")]
        [TestCase(223, 789, "НЕТ")]
        [TestCase(280, 82, "ДА")]
        [TestCase(12, 21, "ДА")]
        [TestCase(11, 67, "НЕТ")]
        public void Task10_Tests(int a, int b, string expected)
        {
            Assert.AreEqual(expected, Homework4.Task10(a, b));
        }
    }
}
