using NUnit.Framework;

namespace DevEduc_all1_6.Tests
{
    public class Homework1_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Task1_Tests()
        {
            Assert.AreEqual($"привет, 3!\n3 + 5 = 8\nпока, 5...",Homework1.Task1());
        }

        [TestCase(5, 4,-281)]
        [TestCase(6, 10, 2507.5)]
        [TestCase(24, 12, -1738)]
        [TestCase(7, 2, -10.2)]
        [TestCase(4, -2, -6)]
        public void Task2_Tests(int a, int b, double expected)
        {
            Assert.AreEqual(expected, Homework1.Task2(a,b));
        }

        [TestCase("Meow", "Urrrr", "Urrrr", "Meow")]
        [TestCase("Афины", "Карфаген", "Карфаген", "Афины")]
        [TestCase("Машина", "Самолет", "Самолет", "Машина")]
        [TestCase("Карты", "Деньги", "Деньги", "Карты")]
        [TestCase("Космос", "Лаборант", "Лаборант", "Космос")]
        public void Task3_Tests(string a, string b, string expected1, string expected2)
        {
            Assert.AreEqual((expected1, expected2), Homework1.Task3(a, b));
        }


        [TestCase(4, 3, 2, -0.25)]
        [TestCase(8, 6, 10, 0.5)]
        [TestCase(-2, 14, 30, -8)]
        [TestCase(12, 7, -1, -0.6666666666666666)]
        [TestCase(9, -2, 21, 2.5555555555555554)]
        public void Task4_Tests(int a, int b,int c, double expected)
        {
            Assert.AreEqual(expected, Homework1.Task4(a, b, c));
        }

        [TestCase(40, 23, 2, 33, 10, -38)]
        [TestCase(82, 16, 120, 4, -12, 38)]
        [TestCase(-6, 13, 54, -9, -22, 60)]
        [TestCase(12, 11, -5, 2, -9, -17)]
        [TestCase(91, -14, 27, 45, 59, -64)]
        public void Task5_Tests(int x1, int y1, int x2, int y2, int expected1,int expected2)
        {
            Assert.AreEqual((expected1, expected2), Homework1.Task5(x1, y1, x2, y2));
        }


        [TestCase(3, 10, 7, 16, -9, -21, true)]
        [TestCase(4, 2, 1, -12, 0, 0, false)]
        [TestCase(-10, -6, 24, 996, -187.797338380595, 127.79733838059499, true)]
        [TestCase(12, 11, -4, 313, 40.15083607772479, -172.15083607772479, true)]
        [TestCase(6, 4, 2, -32, 0, 0, false)]
        public void Task6_Tests(int a, int b, int c, double expected1, double expected2, double expected3, bool expected4)
        {
            Assert.AreEqual((expected1, expected2, expected3, expected4), Homework1.Task6(a, b, c));
        }
    }
}

