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


        [TestCase(4, 3, 2, "4*-0,25+3=2")]
        [TestCase(8, 6, 10, "8*0,5+6=10")]
        [TestCase(-2, 14, 30, "-2*-8+14=30")]
        [TestCase(12, 7, -1, "12*-0,6666666666666666+7=-1")]
        [TestCase(9, -2, 21, "9*2,5555555555555554+-2=21")]

        public void Task4_Tests(int a, int b,int c, string expected)
        {
            Assert.AreEqual(expected, Homework1.Task4(a, b, c));
        }
    }
}