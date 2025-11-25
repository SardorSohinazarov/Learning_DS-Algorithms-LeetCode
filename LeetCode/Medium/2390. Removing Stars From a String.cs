namespace LeetCode.Medium
{
    internal class _2390
    {
        public class Solution
        {
            public string RemoveStars(string s)
            {
                Stack<char> stack = new Stack<char>();

                foreach (char c in s)
                {
                    if (c == '*')
                    {
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }

                return string.Join("" ,stack.ToArray().Reverse());
            }
        }
    }
}
