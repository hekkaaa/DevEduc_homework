using NUnit.Framework;

namespace DevEduc_all1_6.Tests
{
    class Homework2_Tests
    {

        [Test]
        
        public void Task1_Tests()
        {
            Assert.AreEqual((876,8,7,6), Homework2.Task1());
        }

        [TestCase(4, 6, true)]
        [TestCase(40, 10, false)]
        [TestCase(12, -8, true)]
        [TestCase(7, 60, false)]
        [TestCase(-22, 14, true)]
        public void Task2_Tests(double a, double b, bool expected)
        {
            Assert.AreEqual(expected, Homework2.Task2(a, b));
        }


        [TestCase(144, false)]
        [TestCase(147, false)]
        [TestCase(773, true)]
        [TestCase(755, false)]
        [TestCase(742, true)]

        public void Task3_Tests(int a, bool expected)
        {
            Assert.AreEqual((a, expected), Homework2.Task3(a));
        }
    }
}
