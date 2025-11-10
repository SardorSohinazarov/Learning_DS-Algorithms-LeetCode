namespace LeetCode.Medium
{
    internal class _8
    {
        public class Solution
        {
            public int MyAtoi(string s)
            {
                s = s.Trim();
                bool isNegative = false;

                double number = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    var @char = (int)s[i];

                    if (@char < 48 || @char > 57)
                    {
                        if (i == 0 && @char == 45)
                        {
                            isNegative = true;
                            continue;
                        }
                        else if (i == 0 && @char == 43)
                        {
                            isNegative = false;
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                    number = number * 10 + (@char - 48);
                }

                return (isNegative ? (int)Math.Max((double)-2147483648, -number) : (int)Math.Min((double)2147483647, number));
            }
        }
    }
}
