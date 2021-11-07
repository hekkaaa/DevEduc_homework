using NUnit.Framework;

namespace DevEduc_all1_6.Tests
{
    class Homework5_Tests
    {
        [TestCase(new int[] { 7, 9, 6, 4, 6, 9, 15, 11, 3, 9, 1, 7, 18, 7, 9, 1, 1, 8, 1, 15 }, 5, 15)]
        [TestCase(new int[] { 2, 3, 2, 8, 6, 1, 2, 8, 10, 5, 4, 4 }, 9, 3)]
        [TestCase(new int[] { 19, 6, 11, 13, 17, 17, 15, 14, 4, 13, 8, 11, 1, 12, 11, 4, 9, 11, 4, 19 }, 7, 13)]
        [TestCase(new int[] { 5, 3, 1, 6, 6, 12, 14, 3, 11, 8, 12, 16, 16, 15, 16, 1, 10, 16, 7, 11 }, 11, 9)]
        [TestCase(new int[] { 14, 19, 16, 12, 14, 16, 9, 3, 6, 10, 12, 15, 10, 16, 15, 19, 8, 18, 12, 7 }, 13, 7)]
        public void Task1_Tests(int[] a, int expected1, int expected2)
        {
            Assert.AreEqual((expected1, expected2), Homework5.Task1(a));
        }


        [TestCase(new int[] { 44, 51, 15 , 81, 99, 51, 23, 65, 13, 90, 13, 23, 34, 21, 56, 17, 57, 44 }, 
            new int[] { 44, 51, 95, 81, 99, 180, 23, 65, 88, 90, 13, 103, 34, 21, 55, 17, 57, 74 })]
        [TestCase(new int[] { 10, 55, 78, 17, 90, 70, 28, 70, 20, 72, 61, 99, 88, 14, 84, 61, 94, 40, 6, 10, 14, 36, 9, 25, 32, 39, 9, 54, 62, 63, 68, 79, 57, 81, 41, 39, 67, 95, 77, 11 },
            new int[] { 10, 55, 65, 17, 90, 107, 28, 70, 98, 72, 61, 133, 88, 14, 102, 61, 94, 155, 6, 10, 16, 36, 9, 45, 32, 39, 71, 54, 62, 116, 68, 79, 147, 81, 41, 122, 67, 95, 162, 11 })]
        [TestCase(new int[] { 19, 70, 88, 18, 80, 40, 69, 78, 7, 53, 3, 73, 42, 98, 5 },
            new int[] { 19, 70, 89, 18, 80, 98, 69, 78, 147, 53, 3, 56, 42, 98, 140 })]
        [TestCase(new int[] { 99, 1, 10, 51, 77, 11, 28, 42, 22 },
            new int[] { 99, 1, 100, 51, 77, 128, 28, 42, 70 })]
        [TestCase(new int[] { 93, 24, 91, 77, 6, 82, 95, 22, 1, 73, 75, 90, 98 },
            new int[] { 93, 24, 117, 77, 6, 83, 95, 22, 117, 73, 75, 148, 98 })]
        public void Task2_Tests(int[] a, int[] expected)
        {
            Assert.AreEqual(expected, Homework5.Task2(a));
        }


        [TestCase(new int[] { 44, 51, 15, 81, 99, 51 },
            new int[] { 42, 98, 140 },
            new int[] { 44, 51, 15, 81, 99, 51, 42, 98, 140 })]

        [TestCase(new int[] { 10, 55, 78, 17 },
            new int[] { 3, 73, 42, 98, 5 },
            new int[] { 10, 55, 78, 17, 3, 73, 42, 98, 5 })]

        [TestCase(new int[] { 6, 82, 95, 22, 1 },
            new int[] { 93, 24, 91, 77, 6, 82 },
            new int[] { 6, 82, 95, 22, 1, 93, 24, 91, 77, 6, 82 })]

        [TestCase(new int[] { 10, 55, 78, 17 },
            new int[] { 117, 73, 75, 148, 98 },
            new int[] { 10, 55, 78, 17, 117, 73, 75, 148, 98 })]

        [TestCase(new int[] { 77, 128, 28 },
            new int[] { 42, 98, 140 },
            new int[] { 77, 128, 28, 42, 98, 140 })]
        public void Task3_Tests(int[] a, int[] b, int[] expected)
        {
            Assert.AreEqual(expected, Homework5.Task3(a, b));
        }

        

        [TestCase(new int[] { 30, 80, 65, 97, 50, 37, 75, 93, 57, 63, 75, 85 },
            new int[] { 75, 93, 57, 63, 75, 85, 30, 80, 65, 97, 50, 37 })]
        [TestCase(new int[] { 6, 82, 95, 22, 1, 93, 24, 91, 77, 6, 82 },
            new int[] { 93, 24, 91, 77, 6, 82, 6, 82, 95, 22, 1 })]
        [TestCase(new int[] { 30, 80, 65, 97, 50, 37, 75, 93, 57, 63, 75, 85 },
            new int[] { 75, 93, 57, 63, 75, 85, 30, 80, 65, 97, 50, 37 })]
        [TestCase(new int[] { 30, 80, 65, 97, 3, 57, 63, 75, 85 },
            new int[] { 3, 57, 63, 75, 85, 30, 80, 65, 97, })]
        [TestCase(new int[] { 50, 37, 75, 1, 93, 24 },
            new int[] { 1, 93, 24, 50, 37, 75 })]
        [TestCase(new int[] { 99, 1, 100, 51, 77, 128, 28, 42, 70 },
            new int[] { 77, 128, 28, 42, 70, 99, 1, 100, 51 })]
        public void Task4_Tests(int[] a, int[] expected)
        {
            Assert.AreEqual(expected, Homework5.Task4(a));
        }

        [TestCase(4, 
            new int[] { 6, 1, 2, 3, 4, 5 },
            new int[] { 2, 3, 4, 5, 6, 1 })]
        [TestCase(2,
            new int[] { 6, 1, 2, 3, 4, 5 },
            new int[] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(3,
            new int[] { 6, 1, 2, 3, 4, 5 },
            new int[] { 3, 4, 5, 6, 1, 2 })]
        [TestCase(5,
            new int[] { 6, 1, 2, 3, 4, 5 },
            new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(10,
            new int[] { 6, 1, 2, 3, 4, 5 },
            new int[] { 2, 3, 4, 5, 6, 1 })]
        public void Task5_Tests(int a, int[] expected1, int[] expected2)
        {
            Assert.AreEqual((expected1, expected2), Homework5.Task5(a));
        }

     
        [TestCase(
            new int[] { 21, 37, 2, 38, 4, 35 },
            new int[] { 21, 2, 38, 4, 37, 35 })]
        [TestCase(
            new int[] { 2, 2, 3, 2, 3, 3 },
            new int[] { 2, 3, 2, 3, 3, 2 })]
        [TestCase(
            new int[] { -2, 3, 6 , 7, 10, 1 },
            new int[] { 3, -2, 7, 6, 1, 10 })]
        [TestCase(
            new int[] { 24, 27, 21, 29, 39, 8 },
            new int[] { 27, 21, 29, 39, 24, 8 })]
        [TestCase(
            new int[] { 6, 25, 39, 33, 32, 4 },
            new int[] { 25, 39, 33, 6, 32, 4 })]
        public void Task6_Tests(int[] a, int[] expected)
        {
            Assert.AreEqual(expected, Homework5.Task6(a));
        }


        [TestCase(
            new int[] { 21, -37, 0, 38, 4, 35 }, -37, 77)]
        [TestCase(
            new int[] { 2, 2, 0, 2, -3, -3 }, -3, -4)]
        [TestCase(
            new int[] { -2, 3, 6, 7, 10, 1 }, -2, 0)]
        [TestCase(
            new int[] { -24, 27, 21, 29, 0, 8 }, -24, 8)]
        [TestCase(
            new int[] { 4, 25, 39, 33, 0, 6 }, 0, 6 )]
        public void Task7_Tests(int[] a, int expected1 , int expected2)
        {
            Assert.AreEqual((expected1, expected2), Homework5.Task7(a));
        }


        [TestCase(
           new int[] { 21, 37, 2, 38, 4, 35 },
           new int[] { 2, 4, 21, 35, 37, 38 })]
        [TestCase(
            new int[] { 24, 27, 21, 29, 39, 8 },
            new int[] { 8, 21, 24, 27, 29, 39 })]
        [TestCase(
            new int[] { -2, 3, 6, 7, 10, 1 },
            new int[] { -2, 1, 3, 6, 7, 10 })]
        [TestCase(
            new int[] { 77, 128, 28 },
            new int[] { 28, 77, 128 })]
        [TestCase(
            new int[] { 6, 1, 2, 3, 4, 5 },
            new int[] { 1, 2, 3, 4, 5, 6 })]
        public void Task8_Tests(int[] a, int[] expected)
        {
            Assert.AreEqual(expected, Homework5.Task8(a));
        }


        [TestCase(
           new int[] { 21, 37, 2, 38, 4, 35 },
           new int[] { 2, 4, 21, 35, 37, 38 })]
        [TestCase(
            new int[] { 24, 27, 21, 29, 39, 8 },
            new int[] { 8, 21, 24, 27, 29, 39 })]
        [TestCase(
            new int[] { -2, 3, 6, 7, 10, 1 },
            new int[] { -2, 1, 3, 6, 7, 10 })]
        [TestCase(
            new int[] { 77, 128, 28 },
            new int[] { 28, 77, 128 })]
        [TestCase(
            new int[] { 6, 1, 2, 3, 4, 5 },
            new int[] { 1, 2, 3, 4, 5, 6 })]
        public void Task9_Tests(int[] a, int[] expected)
        {
            Assert.AreEqual(expected, Homework5.Task9(a));
        }
    }
}

