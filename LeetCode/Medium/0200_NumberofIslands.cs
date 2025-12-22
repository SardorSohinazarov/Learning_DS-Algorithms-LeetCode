
namespace LeetCode.Medium
{
    internal class _0200_NumberofIslands
    {
        public class Solution
        {
            int rows, cols;
            public int NumIslands(char[][] grid)
            {
                rows = grid.Length;
                cols = grid[0].Length;
                int count = 0;
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[0].Length; j++)
                    {
                        if (grid[i][j] == '1')
                        {
                            count++;
                            dfs(grid, i, j);
                        }
                    }
                }

                return count;
            }

            private void dfs(char[][] grid, int i, int j)
            {
                if (i < 0 || j < 0 || i >= rows || j >= cols || grid[i][j] == '0')
                    return;

                grid[i][j] = '0';

                dfs(grid, i + 1, j);
                dfs(grid, i - 1, j);
                dfs(grid, i, j + 1);
                dfs(grid, i, j - 1);
            }

            private static void Main(string[] args)
            {
                char[][] grid = new char[][]
                {
                    new char[] {'1','1','0','0','0'},
                    new char[] {'1','1','0','0','0'},
                    new char[] {'0','0','1','0','0'},
                    new char[] {'0','0','0','1','1'}
                };
                Solution solution = new Solution();
                Console.WriteLine(solution.NumIslands(grid));
            }
        }
    }
}
