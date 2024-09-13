using FindPath.App;
using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace FindPath.Tests
{
    public class Tests
    {
        [Test]
        public void FindShortestPath_EmptyArray_ReturnsDirectPath()
        {
            int[,] arr = new int[4, 4]
            {
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0}
            };

            var expectedResult = new List<Point>()
            {
                new Point(0,0),
                new Point(0,1),
                new Point(1,1),
                new Point(1,2),
                new Point(2,2),
                new Point(2,3),
                new Point(3,3)
            };

            var actualResult = Program.FindShortestPath(arr);

            Assert.IsNotNull(actualResult);
            Assert.That(actualResult.Count, Is.EqualTo(expectedResult.Count));

            //This part is not correct because it can be different path with the same count of points
            /*for(int i = 0; i < expectedResult.Count; i++)
            {
                Assert.That(actualResult[i], Is.EqualTo(expectedResult[i]));
            }*/ 
        }

        [Test]
        public void FindShortestPath_UniformArray_ReturnsDirectPath()
        {
            int[,] arr = new int[4, 4]
            {
                {1,1,1,1},
                {1,1,1,1},
                {1,1,1,1},
                {1,1,1,1}
            };

            var expectedResult = new List<Point>()
            {
                new Point(0,0),
                new Point(1,1),
                new Point(2,2),
                new Point(3,3)
            };

            var actualResult = Program.FindShortestPath(arr);

            Assert.IsNotNull(actualResult);
            Assert.That(actualResult.Count, Is.EqualTo(expectedResult.Count));

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.That(actualResult[i], Is.EqualTo(expectedResult[i]));
            }
        }

        [Test]
        public void FindShortestPath_DifficultArray1_ReturnsDirectPath()
        {
            int[,] arr = new int[4, 4]
            {
                {0, 1, 2, 3},
                {4, 0, 1, 5},
                {1, 4, 5, 1},
                {1, 1, 1, 1}
            };

            var expectedResult = new List<Point>()
            {
                new Point(0,0),
                new Point(0,1),
                new Point(1,2),
                new Point(2,3),
                new Point(3,3)
            };

            var actualResult = Program.FindShortestPath(arr);

            Assert.IsNotNull(actualResult);
            Assert.That(actualResult.Count, Is.EqualTo(expectedResult.Count));

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.That(actualResult[i], Is.EqualTo(expectedResult[i]));
            }
        }

        [Test]
        public void FindShortestPath_DifficultArray2_ReturnsDirectPath()
        {
            int[,] arr = new int[4, 4]
            {
                {0, 1, 2, 3},
                {4, 5, 1, 5},
                {4, 1, 5, 2},
                {2, 3, 1, 1}
            };

            var expectedResult = new List<Point>()
            {
                new Point(0,0),
                new Point(0,1),
                new Point(1,2),
                new Point(2,1),
                new Point(3,2),
                new Point(3,3)
            };

            var actualResult = Program.FindShortestPath(arr);

            Assert.IsNotNull(actualResult);
            Assert.That(actualResult.Count, Is.EqualTo(expectedResult.Count));

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.That(actualResult[i], Is.EqualTo(expectedResult[i]));
            }
        }

        [Test]
        public void FindShortestPath_ArrayWithoutSolution_ReturnsEmptyPath()
        {
            int[,] arr = new int[4, 4]
            {
                {0, 1, 2, 3},
                {4, 5, 3, 5},
                {4, 1, 5, 2},
                {2, 3, 1, 1}
            };

            var expectedResult = new List<Point>();

            var actualResult = Program.FindShortestPath(arr);

            Assert.IsNotNull(actualResult);
            Assert.That(actualResult.Count, Is.EqualTo(expectedResult.Count));

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.That(actualResult[i], Is.EqualTo(expectedResult[i]));
            }
        }

        //This test is not correct. Shortest path is {(0,0), (1,1), (2,2), (3,3))
        /*[Test]
        public void FindShortestPath_MixedArray_ReturnsShortestPath()
        {
            int[,] arr = new int[4, 4]
            {
                {1,1,0,1},
                {1,1,0,1},
                {0,0,4,1},
                {1,1,1,1}
            };

            var expectedResult = new List<Point>()
            {
                new Point(0,0),
                new Point(1,1),
                new Point(1,2),
                new Point(1,3),
                new Point(2,3),
                new Point(3,3)
            };

            var actualResult = Program.FindShortestPath(arr);

            Assert.IsNotNull(actualResult);
            Assert.That(actualResult.Count, Is.EqualTo(expectedResult.Count));

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.That(actualResult[i], Is.EqualTo(expectedResult[i]));
            }
        }*/
    }
}