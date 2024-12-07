namespace LeetCode.Easy._344
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            var count = s.Count();
            for (int i = 0; i < count / 2; i++)
            {
                char temp = s[i];
                s[i] = s[count - i - 1];
                s[count - i - 1] = temp;
            }
        }
    }
}
