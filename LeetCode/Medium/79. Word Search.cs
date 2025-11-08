namespace LeetCode.Medium._79;

internal class _79
{
    public class Solution
    {
        //public static void Main()
        //{
        //    char[][] board = new char[3][]
        //    {
        //        new char[] {'A','B','C','E'},
        //        new char[] {'S','F','C','S'},
        //        new char[] {'A','D','E','E'}
        //    };
        //    string word = "ABCCED";
        //    Console.WriteLine(Exist(board, word));
        //}

        public static bool Exist(char[][] board, string word)
        {
            int rows = board.Length;
            int cols = board[0].Length;

            bool[,] visited = new bool[rows, cols];

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        if (Exist3(board, word, i, j, 0, visited))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static bool Exist3(char[][] board, string word, int row, int col, int index, bool[,] visited)
        {
            if (index == word.Length) return true;
            if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length) return false;
            if (visited[row, col] || board[row][col] != word[index]) return false;

            visited[row, col] = true;

            var found = Exist3(board, word, row + 1, col, index + 1, visited)
                || Exist3(board, word, row - 1, col, index + 1, visited)
                || Exist3(board, word, row, col + 1, index + 1, visited)
                || Exist3(board, word, row, col - 1, index + 1, visited);

            visited[row, col] = false;

            return found;
        }
    }
}
