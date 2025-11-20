namespace LeetCode.Easy
{
    internal class _171
    {
        public int TitleToNumber(string columnTitle)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var length = columnTitle.Length;

            int result = 0;

            for (int i = 0; i < length; i++)
            {
                var charValue = alphabet.IndexOf(columnTitle[i]) + 1;
                result += charValue * (int)Math.Pow(26, length - i - 1);
            }

            return result;
        }
    }
}
