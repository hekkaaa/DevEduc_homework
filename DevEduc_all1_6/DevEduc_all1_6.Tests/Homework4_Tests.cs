using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DevEduc_all1_6.Tests
{
    class Homework4_Tests
    {   
        // MOCK Task 1
        List<int> ReturnMockTask1(int expectedType)
        {
            switch (expectedType)
            {
                case 1:
                    return new List<int>() { 6, 12, 18, 24, 30, 36, 
                        42, 48, 54, 60, 66, 72, 78, 84, 90, 96, 102, 
                        108, 114, 120, 126, 132, 138, 144, 150, 156,
                        162, 168, 174, 180, 186, 192, 198, 204, 210, 
                        216, 222, 228, 234, 240, 246, 252, 258, 264, 
                        270, 276, 282, 288, 294, 300, 306, 312, 318, 
                        324, 330, 336, 342, 348, 354, 360, 366, 372, 
                        378, 384, 390, 396, 402, 408, 414, 420, 426, 
                        432, 438, 444, 450, 456, 462, 468, 474, 480, 
                        486, 492, 498, 504, 510, 516, 522, 528, 534, 
                        540, 546, 552, 558, 564, 570, 576, 582, 588,
                        594, 600, 606, 612, 618, 624, 630, 636, 642, 
                        648, 654, 660, 666, 672, 678, 684, 690, 696, 
                        702, 708, 714, 720, 726, 732, 738, 744, 750, 
                        756, 762, 768, 774, 780, 786, 792, 798, 804, 
                        810, 816, 822, 828, 834, 840, 846, 852, 858, 
                        864, 870, 876, 882, 888, 894,
                        900, 906, 912, 918, 924, 930, 936, 
                        942, 948, 954, 960, 966, 972, 978, 984, 990, 996 };
                case 2:
                    return new List<int>() { 50, 100, 150, 200, 250, 300, 350, 400,
                        450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000 };
                case 3:
                    return new List<int>() { 150, 300, 450, 600, 750, 900 };
                case 4:
                    return new List<int>() { 800 };
                case 5:
                    return new List<int>() { 232, 464, 696, 928 };
                default:
                    return new List<int>() { };
            }
        }

        [TestCase(6, 1)]
        [TestCase(50, 2)]
        [TestCase(150, 3)]
        [TestCase(800, 4)]
        [TestCase(232, 5)]
        public void Task1_Tests(double a, int expectedType)
        {
            List<int> expected = ReturnMockTask1(expectedType);
            Assert.AreEqual(expected, Homework4.Task1(a));
        }


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
        [TestCase(625, 8)]
        [TestCase(12, 2)]
        public void Task6_Tests(int a, int expected)
        {
            Assert.AreEqual(expected, Homework4.Task6(a));
        }

        [TestCase(233441, 3)]
        [TestCase(565888, 2)]
        [TestCase(11325799, 7)]
        [TestCase(32468848, 1)]
        [TestCase(98765431, 5)]
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


        List<int> ReturnMockTask9(int expectedType)
        {
            switch (expectedType)
            {
                case 1:
                    return new List<int>() { 2, 4, 6 };
                case 2:
                    return new List<int>() { 2, 4, 6, 8, 12, 14, 16};
                case 3:
                    return new List<int>() { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34, 36, 38, 40 };
                case 4:
                    return new List<int>() { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28 };
                case 5:
                    return new List<int>() { 2, 4, 6, 8, 12, 14
                        , 16, 18, 20, 21, 22, 24, 26, 28, 34, 36,
                        38, 40, 41, 42, 43, 44, 46, 48, 56, 58,
                        60, 61, 62, 63, 64, 65, 66, 68, 78, 80,
                        81, 82, 83, 84, 85, 86, 87, 88, 102, 104,
                        106, 108, 114, 116, 118, 120, 122, 124,
                        126, 128, 136, 138, 140, 141, 142, 144,
                        146, 148, 158, 160, 161, 162, 163, 164,
                        166, 168, 180, 181, 182, 183, 184, 185,
                        186, 188, 200, 201, 202, 204, 206, 208, 
                        210, 212, 214, 216, 218, 220, 221, 222,
                        223, 224, 226, 228, 232, };
                default:
                    return new List<int>() { };
            }
        }

        [TestCase(6, 1)]
        [TestCase(16, 2)]
        [TestCase(40, 3)]
        [TestCase(28, 4)]
        [TestCase(232, 5)]
        public void Task9_Tests(int a, int expectedType)
        {
            List<int> expected = ReturnMockTask9(expectedType);
            Assert.AreEqual(expected, Homework4.Task9(a));
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



        // NEGATIVE TESTS

        [TestCase(-10)]
        [TestCase(0)]
        [TestCase(1100)]
        public void Task3_NegativeTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework4.Task1(a));
        }

        [TestCase(-12)]
        [TestCase(0)]
        public void Task6_NegativeTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework4.Task6(a));
        }

        [TestCase(213)]
        [TestCase(123456789)]
        public void Task7_NegativeTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework4.Task7(a));
        }

        [TestCase(-10)]
        public void Task9_NegativeTests(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework4.Task9(a));
        }
    }
}
