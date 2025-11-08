namespace LeetCode.Medium
{
    internal class _5
    {
        public class Solution
        {
            public string LongestPalindrome(string s)
            {
                if (s.Length <= 1)
                    return s;

                string longest = s[0].ToString();

                for (int i = 0; i < s.Length; i++)
                {
                    var rightIndex = s.Length - 1;
                    while (rightIndex > i)
                    {
                        if (IsPalindrome(s, i, rightIndex))
                        {
                            if (longest.Length < rightIndex - i + 1)
                                longest = s.Substring(i, rightIndex - i + 1);
                        }
                        rightIndex--;
                    }
                }

                return longest;
            }

            public bool IsPalindrome(string s, int left, int right)
            {
                while (left < right)
                {
                    if (s[left] != s[right])
                        return false;
                    left++;
                    right--;
                }
                return true;
            }
        }
    }
}
