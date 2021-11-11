using NUnit.Framework;
using System;

namespace DevEduc_all1_6.Tests
{
    class Homework6_Tests
    {

        // MOCK Task 1
        int[,] GetMockTask1(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new int[,] {
                        {- 7, -9, -6, -4, -6, -99, 15, -11 },
                        { -19, 1, 1, 90, 761, 15, 15, -56 },
                        { 3, 9, 6, 4, 6, 29, 15, -88 },
                        { -44, 32, 2, 123, 13, 79, 15, -43 },
                        { -92, 56, -23, 46, -6, -9, -175, -11 }
                    };

                case "2":
                    return new int[,] {
                        { -9, 9, -6, -4, 6, -929, 15, -11 },
                        { 19, -71, -61, -90, -761, -15, 815, -56 },
                        { -3, 97, 66, -4, 6, -29, 15, 88 },
                        { 44, -32, 2, -123, -63, 9, 15, -43 },
                        { 92, -56, -23, 46, -6, -9, 175, 11 }
                    };

                case "3":
                    return new int[,] {
                        { 47, -9, -6, 494, -36, -399, 215, -11 },
                        { 319, 1, 1, 90, 761, 15, 15, -56 },
                        { -3, 9, 66, 54, 66, 29, 15, -78 },
                        { -44, 32, 2, 123, 13, 79, 15, -43 },
                        { -22, 56, -923, 226, -6, -9, -175, -11 }
                    };
                case "4":
                    return new int[,] {
                        { 427, -9, -6, -494, 36, 1, -215, -511 },
                        { -3, 431, 21, 930, 761, 135, 1425,  756 },
                        { 23, 923, 66, 54, 66, 529, 15, -768 },
                        { 44, 32, 2234, 123, 173, 729, 1435, 43 },
                        { 212, -96, 33, -34, -76, 88, -15, -566 }
                    };
                case "5":
                    return new int[,] {
                        { -47, -9, -6, -494, -36, -399, 215, -11 },
                        { -319, 1, -1, -90, -761, 15, 15, -56 },
                        { -43, 9, 66, -54, 66, 29, 15, -78 },
                        { -444, 32, 2, 123, 13, -79, 15, -43 },
                        { -22, -56, -923, -226, -6, -9, -175, -11 }
                    };
                default:
                    return new int[,] { };
            }
        }
        int[,] ReturnMockTask1(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new int[,] {
                        { 7, 9, 6, 4, 6, 99, 15, 11 },
                        { 19, 1, 1, 90, 761, 15, 15, 56 },
                        { 3, 9, 6, 4, 6, 29, 15, 88 },
                        { 44, 32, 2, 123, 13, 79, 15, 43 },
                        { 92, 56, 23, 46, 6, 9, 175, 11 }
                    };

                case "2":
                    return new int[,] {
                        { 9, 9, 6, 4, 6, 929, 15, 11 },
                        { 19, -71, -61, -90, -761, -15, 815, 56 },
                        { 3, 97, 66, -4, 6, -29, 15, 88 },
                        { 44, -32, 2, -123, -63, 9, 15, 43 },
                        { 92, 56, 23, 46, 6, 9, 175, 11 }
                    };

                case "3":
                    return new int[,] {
                        { 47, 9, 6, 494, 36, 399, 215, 11 },
                        { 319, 1, 1, 90, 761, 15, 15, 56 },
                        { 3, 9, 66, 54, 66, 29, 15, 78 },
                        { 44, 32, 2, 123, 13, 79, 15, 43 },
                        { 22, 56, 923, 226, 6, 9, 175, 11 }
                    };
                case "4":
                    return new int[,] {
                        { 427, 9, 6, 494, 36, 1, 215, 511 },
                        { 3, 431, 21, 930, 761, 135, 1425,  756 },
                        { 23, 923, 66, 54, 66, 529, 15, 768 },
                        { 44, 32, 2234, 123, 173, 729, 1435, 43 },
                        { 212, 96, 33, 34, 76, 88, 15, 566 }
                    };
                case "5":
                    return new int[,] {
                        { 47, 9, 6, 494, 36, 399, 215, 11 },
                        { 319, 1, -1, -90, -761, 15, 15, 56 },
                        { 43, 9, 66, -54, 66, 29, 15, 78 },
                        { 444, 32, 2, 123, 13, -79, 15, 43 },
                        { 22, 56, 923, 226, 6, 9, 175, 11 }
                    };
                default:
                    return new int[,] { };
            }
        }

        [TestCase("1", "1")]
        [TestCase("2", "2")]
        [TestCase("3", "3")]
        [TestCase("4", "4")]
        [TestCase("5", "5")]
        public void Task1_Tests(string arrayType, string expectedType)
        {
            int[,] a = GetMockTask1(arrayType);
            int[,] expected = ReturnMockTask1(expectedType);
            Assert.AreEqual(expected, Homework6.Task1(a));
        }

        // MOCK Task 2
        int[,] GetMockTask2(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new int[9, 9];
                case "2":
                    return new int[10, 10];
                case "3":
                    return new int[5, 5];
                case "4":
                    return new int[2, 2];
                case "5":
                    return new int[3, 4];
                default:
                    return new int[,] { };
            }
        }
        int[,] ReturnMockTask2(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new int[,] {
                        { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                        { 2, 4, 6, 8, 10, 12, 14, 16, 18 },
                        { 3, 6, 9, 12, 15, 18, 21, 24, 27 },
                        { 4, 8, 12, 16, 20, 24, 28, 32, 36 },
                        { 5, 10, 15, 20, 25, 30, 35, 40, 45},
                        { 6, 12, 18, 24, 30, 36, 42, 48, 54},
                        { 7, 14, 21, 28, 35, 42, 49, 56, 63},
                        { 8, 16, 24, 32, 40, 48, 56, 64, 72 },
                        { 9, 18, 27, 36, 45, 54, 63, 72, 81 }
                    };
                case "2":
                    return new int[,] {
                         { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                        { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 },
                        { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 },
                        { 4, 8, 12, 16, 20, 24, 28, 32, 36, 40 },
                        { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50},
                        { 6, 12, 18, 24, 30, 36, 42, 48, 54, 60},
                        { 7, 14, 21, 28, 35, 42, 49, 56, 63, 70},
                        { 8, 16, 24, 32, 40, 48, 56, 64, 72, 80},
                        { 9, 18, 27, 36, 45, 54, 63, 72, 81, 90},
                        { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }
                    };
                case "3":
                    return new int[,] {
                        { 1, 2, 3, 4, 5},
                        { 2, 4, 6, 8, 10},
                        { 3, 6, 9, 12, 15},
                        { 4, 8, 12, 16, 20},
                        { 5, 10, 15, 20, 25}

                    };
                case "4":
                    return new int[,] {
                        { 1, 2},
                        { 2, 4}

                    };
                case "5":
                    return new int[,] {
                        { 1, 2, 3, 4},
                        { 2, 4, 6, 8},
                        { 3, 6, 9, 12 }

                    };
                default:
                    return new int[,] { };
            }
        }

        [TestCase("1", "1")]
        [TestCase("2", "2")]
        [TestCase("3", "3")]
        [TestCase("4", "4")]
        [TestCase("5", "5")]
        public void Task2_Tests(string arrayType, string expectedType)
        {
            int[,] a = GetMockTask2(arrayType);
            int[,] expected = ReturnMockTask2(expectedType);
            Assert.AreEqual(expected, Homework6.Task2(a));
        }


        // MOCK Task 3
        int[,] GetMockTask3(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new int[3, 3];
                case "2":
                    return new int[4, 4];
                case "3":
                    return new int[2, 2];
                case "4":
                    return new int[6, 4];
                case "5":
                    return new int[2, 6];
                case "negative":
                    return new int[8, 5];
                default:
                    return new int[,] { };
            }
        }
        int[,] ReturnMockTask3(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new int[,] {
                        { 0, 1, 0},
                        { 1, 0, 1},
                        { 0, 1, 0}
                    };
                case "2":
                    return new int[,] {
                        { 1, 0, 1, 0},
                        { 0, 1, 0, 1},
                        { 1, 0, 1, 0},
                        { 0, 1, 0, 1}
                    };
                case "3":
                    return new int[,] {
                        { 1, 0},
                        { 0, 1},
                    };
                case "4":
                    return new int[,] {
                        { 1, 0, 1, 0},
                        { 0, 1, 0, 1},
                        { 1, 0, 1, 0},
                        { 0, 1, 0, 1},
                        { 1, 0, 1, 0},
                        { 0, 1, 0, 1}
                    };
                case "5":
                    return new int[,] {
                        { 1, 0, 1, 0, 1, 0},
                        { 0, 1, 0, 1, 0, 1}
                    };
                default:
                    return new int[,] { };
            }
        }

        [TestCase("1", "1")]
        [TestCase("2", "2")]
        [TestCase("3", "3")]
        [TestCase("4", "4")]
        [TestCase("5", "5")]
        public void Task3_Tests(string arrayType, string expectedType)
        {
            int[,] a = GetMockTask3(arrayType);
            int[,] expected = ReturnMockTask3(expectedType);
            Assert.AreEqual(expected, Homework6.Task3(a));
        }



        // MOCK Task 4
        int[,] GetMockTask4(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new int[,] {
                        { 0, 1, 1, 0},
                        { 0, 1, 1, 0},
                        { 0, 0, 0, 0},
                        { 0, 0, 1, 0},
                        { 0, 1, 0, 0},
                    };
                case "2":
                    return new int[,] {
                        { 0, 0, 1, 0},
                        { 0, 0, 1, 0},
                        { 0, 0, 0, 0},
                        { 1, 1, 1, 0},
                        { 0, 1, 0, 0},
                    };
                case "3":
                    return new int[,] {
                        { 0, 1, 0, 0, 1},
                        { 0, 1, 0, 0, 1},
                        { 0, 1, 0, 0, 1},
                        { 0, 1, 0, 0, 1},
                    };
                case "4":
                    return new int[,] {
                        { 1, 0, 0, 0},
                        { 0, 1, 0, 0},
                        { 0, 0, 0, 1},
                        { 0, 0, 1, 0},
                        { 0, 1, 0, 0},
                    };
                case "5":
                    return new int[,] {
                        { 0, 0, 1, 0},
                        { 0, 0, 1, 0},
                        { 0, 0, 0, 0},
                        { 0, 0, 1, 0},
                        { 1, 1, 1, 1},
                    };
                default:
                    return new int[,] { };
            }
        }

        [TestCase("1", true)]
        [TestCase("2", true)]
        [TestCase("3", false)]
        [TestCase("4", false)]
        [TestCase("5", true)]

        public void Task4_Tests(string arrayType, bool expected)
        {
            int[,] a = GetMockTask4(arrayType);

            Assert.AreEqual(expected, Homework6.Task4(a));
        }


        // MOCK Task 5
        double[,] GetMockTask5(string arrayType)
        {
            switch (arrayType)
            {

                case "1":
                    return new double[,] {
                        {30, 40, 50, 60, 70, 80 },
                        { 30, 40, 50, 60, 70, 80 },
                        { 30, 40, 50, 60, 70, 80 },
                        { 30, 40, 50, 60, 70, 80 },
                        { 30, 40, 50, 60, 70, 80 },
                        { 30, 40, 50, 60, 70, 80},
                        { 30, 40, 50, 60, 70, 80 },
                        { 30, 40, 50, 60, 70, 80 },
                        { 30, 40, 50, 60, 70, 80 },
                        { 30, 40, 50, 60, 70, 80 }
                    };
                case "2":
                    return new double[,] {
                        {30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 }
                    };
                case "3":
                    return new double[,] {
                        {30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 160, 210, 170, 190, 200, 180 },
                        {30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 160, 210, 170, 190, 200, 180 },
                        {30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 160, 210, 170, 190, 200, 180 },
                        { 30, 40, 50, 60, 70, 80 }
                        
                    };
                case "4":
                    return new double[,] {
                         {30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 160, 210, 170, 190, 200, 180 },
                        { 260, 230, 280, 250, 220, 240 },
                        {30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 160, 210, 170, 190, 200, 180 },
                        { 260, 230, 280, 250, 220, 240 },
                         {30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },

                    };
                case "5":
                    return new double[,] {
                        {30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 160, 210, 170, 190, 200, 180 },
                        { 260, 230, 280, 250, 220, 240 },
                        {440, 410, 450, 430, 400, 420 },
                         {30, 40, 50, 60, 70, 80 },
                        { 90, 100, 110, 120, 130, 140 },
                        { 160, 210, 170, 190, 200, 180 },
                        { 260, 230, 280, 250, 220, 240 },
                        {440, 410, 450, 430, 400, 420 },

                    };
                default:
                    return new double[,] { };
            }
        }
        double[,] ReturnMockTask5(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new double[,] {
                        { 30, 80},
                        { 30, 80},
                        { 30, 80},
                        { 30, 80},
                        { 30, 80},
                        { 30, 80},
                        { 30, 80},
                        { 30, 80},
                        { 30, 80},
                        { 30, 80},
                    };
                case "2":
                    return new double[,] {
                        { 30, 80},
                        { 90, 140},
                        { 30, 80},
                        { 90, 140},
                        { 30, 80},
                        { 90, 140},
                        { 30, 80},
                        { 90, 140},
                        { 30, 80},
                        { 90, 140}
                    };
                case "3":
                    return new double[,] {
                        { 30, 80},
                        { 90, 140},
                        { 160, 210},
                        { 30, 80},
                        { 90, 140},
                        { 160, 210},
                        { 30, 80},
                        { 90, 140},
                        { 160, 210},
                        { 30, 80}
                    };
                case "4":
                    return new double[,] {
                        { 30, 80},
                        { 90, 140},
                        { 160, 210},
                        { 220, 280},
                        { 30, 80},
                        { 90, 140},
                        { 160, 210},
                        { 220, 280},
                        { 30, 80},
                        { 90, 140}
                    };
                case "5":
                    return new double[,] {
                        { 30, 80},
                        { 90, 140},
                        { 160, 210},
                        { 220, 280},
                        { 400, 450},
                        { 30, 80},
                        { 90, 140},
                        { 160, 210},
                        { 220, 280},
                        { 400, 450}
                    };
                default:
                    return new double[,] { };
            }
        }
        double[] SumProfit(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new double[] {
                    330, 330, 330, 330, 330, 330, 330, 330, 330, 330
                    };
                case "2":
                    return new double[] {
                    330, 690, 330, 690, 330, 690, 330, 690, 330, 690
                    };
                case "3":
                    return new double[] {
                    330, 690, 1110,  330, 690, 1110,  330, 690, 1110, 330
                    };
                case "4":
                    return new double[] {
                    330, 690, 1110, 1480, 330, 690, 1110, 1480, 330, 690
                    };
                case "5":
                    return new double[] {
                    330, 690, 1110, 1480, 2550, 330, 690, 1110, 1480, 2550
                    };
                default:
                    return new double[] { };
            }
        }

        [TestCase("1", "1", "1")]
        [TestCase("2", "2", "2")]
        [TestCase("3", "3", "3")]
        [TestCase("4", "4", "4")]
        [TestCase("5", "5", "5")]

        public void Task5_Tests(string arrayType, string expectedType1, string expectedType2)
        {
            double[,] a = GetMockTask5(arrayType);
            double[] expected1 = SumProfit(expectedType1);
            double[,] expected2 = ReturnMockTask5(expectedType2);
            Assert.AreEqual((expected1, expected2), Homework6.Task5(a));
        }


        // MOCK Task 6
        int[,] GetMockTask6(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new int[,] {
                        { 26, 48, 30, 20, 27 },
                        { 25, 49 , 17, 26, 28},
                        { 28,  8, 39, 2, 29 },
                        { 4, 14, -4, -10, 8},
                        { 10, 9, 32, -6, 1 }
                    };
                case "2":
                    return new int[,] {
                        { 6, 8, 130, 20, 27 },
                        { 25, 9 , 1, 26, -2},
                        { -28,  82, 329, 23, 39 },
                        { 4, 1, -4, -10, 8},
                        { 11, 39, 32, -6, 46 }
                    
            };
                case "3":
                    return new int[,] {
                        { 33, 23, 43, 30, 3 },
                        { 0, -2 , 45, -6, 43},
                        { 47, 39, -6, 26, 11 },
                        { 0, -10, -8, 2, 5},
                        { 15, 41, 34, 37, -8 }
                    };
                case "4":
                    return new int[,] {
                        { 8, 37, 23, -2, 9 },
                        { 12, 7, 19, 20, 13 },
                        { -2, 21, 31, 35, 43 },
                        { 37, -3, 13, 30, 28 },
                        { 35, 13, 22, 29, 29 }
                    };
                case "5":
                    return new int[,] {
                        { 31, 0, 18, -2, 13, -2 },
                        { 28, 2, 41, 8, 2, 30 },
                        { -1, -6, 27, 15, 19, 8 },
                        { 35, 21, 42, 8, 29, -8 },
                        { -7, -1, -4, 41, -3, 27 },
                        { 43, 43, -7, 38, -4, 30 }
                    };
                case "negative":
                    return new int[,] {
                        { 31, 0, 18, -2, 13, -2 },
                        { 28, 2, 41, 8, 2, 30 },
                        { -1, -6, 27, 15, 19, 8 },
                        { 35, 21, 42, 8, 29, -8 },
                        { -7, -1, -4, 41, -3, 27 },
                        { 43, 43, -7, 38, -4, 30 },
                        { 43, 43, -7, 38, -4, 30 }
                    };
                default:
                    return new int[,] { };
            }
        }

        [TestCase("1", 1)]
        [TestCase("2", 1)]
        [TestCase("3", 3)]
        [TestCase("4", 0)]
        [TestCase("5", 2)]
        public void Task6_Tests(string arrayType, int expected)
        {
            int[,] a = GetMockTask6(arrayType);
            
            Assert.AreEqual(expected, Homework6.Task6(a));
        }



        // MOCK Task 7
      
        [Test]
        public void Task7_Tests()
        {
            int[,] a = new int[7,7];
            int[,] expected = new int[,] {
                       { 1,      1,      1,      1,      1,      1,      1 },
                       { 0,      1,      1,      1,      1,      1,      0 },
                       { 0,      0,      1,      1,      1,      0,      0 },
                       { 0,      0,      0,      1,      0,      0,      0 },
                       { 0,      0,      1,      1,      1,      0,      0 },
                       { 0,      1,      1,      1,      1,      1,      0 },
                       { 1,      1,      1,      1,      1,      1,      1 }
                    };

            int[,] actual = Homework6.Task7(a);
            Assert.AreEqual(expected, actual);
        }

        // MOCK Task 8
        int[,] GetMockTask1_8(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new int[,] {
                       {13,14,18,2,8 },
                       {9,7,1,3,5},
                       {11,17,19,5,15},
                       {3,12,1,10,2},
                       {2,9,9,4,6 }
                    };
                case "2":
                    return new int[,] {
                       {7,9 },
                       {3,6}
                    };
                case "3":
                    return new int[,] {
                       {3,8,14,5},
                       {9,3,12,1},
                       {18,10,19,6},
                       {16,16,6,19}
                    };
                case "4":
                    return new int[,] {
                       { 19,17,19 },
                       { 15,4,10 },
                       { 17,14,17 }
                    };
                case "5":
                    return new int[,] {
                       { 10,2,2 },
                       { 3,7,5 },
                       { 10,16,3 }
                    };
                case "negative":
                    return new int[,] {
                       { 9,14,1 },
                       { 2,4,14 },
                       { 6,15,12 }
                    };

                default:
                    return new int[,] { };
            }
        }
        int[,] GetMockTask2_8(string arrayType)
        {
            switch (arrayType)
            {
                case "1":
                    return new int[,] {
                       {1,15,12,13,3},
                       {6,13,6,18,8},
                       {13,3,11,4,17},
                       {9,19,10,14,16},
                       {9,1,19,15,10}
                    };
                case "2":
                    return new int[,] {
                       {17,5 },
                       {7,13}
                    };
                case "3":
                    return new int[,] {
                       {7,8,18,18}
                    };
                case "4":
                    return new int[,] {
                       { 19,18,3 },
                       { 12,9,4 },
                       { 19,16,8 }
                    };
                case "5":
                    return new int[,] {
                       { 5,18,11 },
                       { 8,16,16 },
                       { 13,5,15 }
                    };
                case "negative":
                    return new int[,] {
                       { 1,4 },
                       { 19,11 },
                       { 3,2 }
                    };
                default:
                    return new int[,] { };
            }
        }
        int[,] ReturnMockTask8(string expectedType)
        {
            switch (expectedType)
            {
                case "1":
                    return new int[,] {
                       { 421,477,610,641,569 },
                       { 136,291,286,364,198 },
                       { 540,553,778,820,722 },
                       { 196,396,257,429,302},
                       { 263,256,331,370,355 }
                    };
                case "2":
                    return new int[,] {
                       { 182,152 },
                       { 93,93 }
                    };
                case "3":
                    return new int[,] {
                       { 21,24,54,54 },
                       { 63,72,162,162 },
                       { 126,144,324,324 },
                       { 112,128,288,288 }
                    };
                case "4":
                    return new int[,] {
                       { 926,799,277 },
                       { 523,466,141 },
                       { 814,704,243 }
                    };
                case "5":
                    return new int[,] {
                       { 92,222,172 },
                       { 136,191,220 },
                       { 217,451,411 }
                    };
                default:
                    return new int[,] { };
            }
        }

        [TestCase("1", "1", "1")]
        [TestCase("2", "2", "2")]
        [TestCase("3", "3", "3")]
        [TestCase("4", "4", "4")]
        [TestCase("5", "5", "5")]
        public void Task8_Tests(string arrayType1, string arrayType2, string expectedType)
        {
            int[,] a = GetMockTask1_8(arrayType1);
            int[,] b = GetMockTask2_8(arrayType2);
            int[,] expected = ReturnMockTask8(expectedType);

            Assert.AreEqual(expected, Homework6.Task8(a,b));
        }

        // NEGATIVE TESTS

        [TestCase("negative", "negative")]
        public void Task8_NegativeTests(string arrayType1, string arrayType2)
        {
            int[,] a = GetMockTask1_8(arrayType1);
            int[,] b = GetMockTask2_8(arrayType2);

            Assert.Throws<IndexOutOfRangeException>(() => Homework6.Task8(a, b));
        }


        [TestCase("negative")]
        public void Task3_NegativeTests(string arrayType)
        {
            int[,] a = GetMockTask3(arrayType);
            Assert.Throws<IndexOutOfRangeException>(() => Homework6.Task3(a));
        }

        [TestCase("negative")]
        public void Task6_NegativeTests(string arrayType)
        {
            int[,] a = GetMockTask6(arrayType);
            Assert.Throws<IndexOutOfRangeException>(() => Homework6.Task6(a));
        }
        
    }
}


