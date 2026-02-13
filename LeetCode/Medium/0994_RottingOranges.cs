
namespace LeetCode.Medium
{
    internal class _0994_RottingOranges
    {
        public class Solution
        {
            //private static void Main(string[] args)
            //{
            //    var solution = new Solution();
            //    var grid = new int[][]
            //    {
            //        new int[] { 2, 1, 1 },
            //        new int[] { 1, 1, 0 },
            //        new int[] { 0, 1, 1 }
            //    };
            //    var result = solution.OrangesRotting(grid);
            //    Console.WriteLine(result); // Output: 4
            //}

            public int OrangesRotting(int[][] grid)
            {
                var count = 0;
                Queue<(int x, int y)> queue = new Queue<(int x, int y)>();

                return BFS(grid, queue, count);
            }

            private int BFS(int[][] grid, Queue<(int x, int y)> queue, int count)
            {
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] == 2)
                        {
                            queue.Enqueue((i, j));
                        }
                    }
                }

                while (queue.Count > 0)
                {
                    int size = queue.Count;
                    for (int i = 0; i < size; i++)
                    {
                        var current = queue.Dequeue();
                        int x = current.x;
                        int y = current.y;
                        if (x - 1 >= 0 && grid[x - 1][y] == 1)
                        {
                            grid[x - 1][y] = 2;
                            queue.Enqueue((x - 1, y));
                        }
                        if (x + 1 < grid.Length && grid[x + 1][y] == 1)
                        {
                            grid[x + 1][y] = 2;
                            queue.Enqueue((x + 1, y));
                        }
                        if (y - 1 >= 0 && grid[x][y - 1] == 1)
                        {
                            grid[x][y - 1] = 2;
                            queue.Enqueue((x, y - 1));
                        }
                        if (y + 1 < grid[0].Length && grid[x][y + 1] == 1)
                        {
                            grid[x][y + 1] = 2;
                            queue.Enqueue((x, y + 1));
                        }
                    }
                    count++;
                }
                foreach (var row in grid)
                {
                    foreach (var cell in row)
                    {
                        if (cell == 1)
                        {
                            return -1;
                        }
                    }
                }
                return count == 0 ? count : count - 1;
            }
        }
    }
}
