using NUnit.Framework;

namespace DevEduc_all1_6.Tests
{
    class Homework5_Tests
    {
        [TestCase(new int[]{7, 9, 6, 4, 6, 9, 15, 11, 3, 9, 1, 7, 18, 7, 9, 1, 1, 8, 1, 15}, 5, 15)]
        [TestCase(new int[] { 2, 3, 2, 8, 6, 1, 2, 8, 10, 5, 4, 4 }, 9, 3)]
        [TestCase(new int[] { 19, 6, 11, 13, 17, 17, 15, 14, 4, 13, 8, 11, 1, 12, 11, 4, 9, 11, 4, 19 }, 7, 13)]
        [TestCase(new int[] { 5, 3, 1, 6, 6, 12, 14, 3, 11, 8, 12, 16, 16, 15, 16, 1, 10, 16, 7, 11 }, 11, 9)]
        [TestCase(new int[] { 14, 19, 16, 12, 14, 16, 9, 3, 6, 10, 12, 15, 10, 16, 15, 19, 8, 18, 12, 7 }, 13, 7)]

        public void Task1_Tests(int[] a, int expected1, int expected2)
        {
            Assert.AreEqual((expected1, expected2), Homework5.Task1(a));
        }
    }
}
