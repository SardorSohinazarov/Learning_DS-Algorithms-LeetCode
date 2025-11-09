namespace LeetCode.Easy
{
    internal class _500
    {
        public class Solution
        {
            public string[] FindWords(string[] words)
            {
                var firstRow = new HashSet<char>("qwertyuiopQWERTYUIOP");
                var secondRow = new HashSet<char>("asdfghjklASDFGHJKL");
                var thirdRow = new HashSet<char>("zxcvbnmZXCVBNM");

                var result = new List<string>();

                foreach (var ord in words)
                {
                    if (IsInRow(ord, firstRow) || IsInRow(ord, secondRow) || IsInRow(ord, thirdRow))
                        result.Add(ord);
                }

                return result.ToArray();
            }

            bool IsInRow(string word, HashSet<char> row)
            {
                foreach (var ch in word)
                {
                    if (!row.Contains(ch))
                        return false;
                }
                return true;
            }
        }
    }
}
