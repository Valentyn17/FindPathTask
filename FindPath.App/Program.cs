using System;
using System.Collections.Generic;
using System.Drawing;

namespace FindPath.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[25, 25]
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0},
                {0, 0, 0, 0, 0, 0, 0, 6, 6, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0},
                {0, 0, 0, 0, 0, 0, 0, 6, 6, 0, 0, 0, 4, 4, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 6, 6, 0, 0, 0, 4, 4, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 7, 7, 0, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0},
                {0, 0, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 7, 7, 0, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 4, 4, 0, 0, 0},
                {4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 4, 4, 0, 0, 0},
                {4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 4, 4, 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            foreach (var point in FindShortestPath(arr))
            {
                Console.WriteLine(point);
            }

            Console.ReadKey();
        }

        public static List<Point> FindShortestPath(int[,] arr)
        {
            int width = arr.GetLength(0);
            int length = arr.GetLength(1);
            Point start = new Point(0, 0);
            Point end = new Point(width - 1, length - 1);

            // Directions for  movement 
            Point[] directions = new Point[]
            {
                new Point(1, 1),   // bottom-right
                new Point(1, -1),  // bottom-left
                new Point(-1, 1),  // top-right
                new Point(0, 1),   // right
                new Point(1, 0),   // down
                new Point(0, -1),  // left
                new Point(-1, 0)   // up
            };

            // BFS initialization
            Queue<(List<Point> Path, HashSet<int> Digits)> queue = new Queue<(List<Point>, HashSet<int>)>();
            bool[,] visited = new bool[width, length];
            queue.Enqueue((new List<Point> { start }, new HashSet<int> { arr[0, 0], arr[width - 1, length - 1] }));
            visited[0, 0] = true;

            // BFS search
            while (queue.Count > 0)
            {
                var (path, digits) = queue.Dequeue();
                Point current = path[path.Count - 1];

                // If we reached the end point, return the path
                if (current == end)
                {
                    Console.WriteLine(path.Count);
                    return path;
                }

                // Explore different directions
                foreach (var dir in directions)
                {
                    Point next = new Point(current.X + dir.X, current.Y + dir.Y);
                    bool isDiagonal = Math.Abs(dir.X) == Math.Abs(dir.Y);

                    if (IsValidMove(arr, current, next, digits, width, length, isDiagonal) && !visited[next.X, next.Y])
                    {
                        var newPath = new List<Point>(path) { next };
                        var newDigits = new HashSet<int>(digits) { arr[next.X, next.Y] };
                        queue.Enqueue((newPath, newDigits));
                        visited[next.X, next.Y] = true;
                    }
                }
            }

            // Return empty list if no path found
            return new List<Point>();
        }

        // Check if the move is valid
        public static bool IsValidMove(int[,] arr, Point current, Point next, HashSet<int> digits, int n, int m, bool isDiagonal)
        {
            if (next.X < 0 || next.X >= n || next.Y < 0 || next.Y >= m) //check for array's bounds
                return false;

            int nextValue = arr[next.X, next.Y];

            // Add the next value to the set of encountered digits
            HashSet<int> newDigits = new HashSet<int>(digits) { nextValue };

            // If more than two unique digits are encountered, the move is not valid
            if (newDigits.Count > 2)
                return false;
            // For diagonal moves, no zeroes are allowed
            if (isDiagonal)
            {
                return nextValue != 0;
            }

            // For regular moves, zero can be a valid move
            return true;
        }
    }
}
