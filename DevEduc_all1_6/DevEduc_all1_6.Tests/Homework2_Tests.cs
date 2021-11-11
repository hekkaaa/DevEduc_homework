using NUnit.Framework;
using System;

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

        [TestCase(778, 877)]
        [TestCase(147, 741)]
        [TestCase(773, 377)]
        [TestCase(755, 557)]
        [TestCase(870, 78)]
        public void Task4_Tests(int a, int expected)
        {
            Assert.AreEqual((a, expected), Homework2.Task4(a));
        }


        [Test]
        public void Task5_Tests()
        {
            Assert.AreEqual((156, true), Homework2.Task5());
        }


        // NEGATIVE TESTS

        [TestCase(3444)]
        public void Task3_NegativeTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework2.Task3(a));
        }

        [TestCase(2342)]
        public void Task4_NegativeTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework2.Task4(a));
        }
    }
}
