namespace LeetCode.Medium
{
    internal class _3
    {
        public class Solution
        {
            //private static void Main(string[] args)
            //{
            //    var solution = new Solution();
            //    var result = solution.LengthOfLongestSubstring("abcabcbb");
            //    Console.WriteLine(result);
            //}

            public int LengthOfLongestSubstring(string s)
            {
                var longestStr = "";
                var l = 0;

                var left = 0;
                var right = 0;

                while (right < s.Length)
                {
                    if (!longestStr.Contains(s[right]))
                    {
                        longestStr += s[right];
                        if(longestStr.Length > l)
                        {
                            l = longestStr.Length;
                        }
                        right++;
                    }
                    else
                    {
                        longestStr = longestStr.Substring(1);
                        left++;
                    }
                }

                return l;
            }
        }
    }
}
