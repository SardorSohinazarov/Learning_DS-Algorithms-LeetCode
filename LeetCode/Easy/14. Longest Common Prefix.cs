namespace LeetCode.Easy
{
    public class _14
    {
        public class Solution
        {
            public static void Main()
            {
                string[] strs = ["dog", "racecar", "car"];
                Console.WriteLine(LongestCommonPrefix(strs));
            }

            public static string LongestCommonPrefix(string[] strs)
            {
                var prefix = Min(strs);
                var count = prefix.Length;

                for (int i = 0; i <= count - 1; i++)
                {
                    prefix = prefix.Substring(0, count - i);
                    if (prefix == string.Empty)
                        return prefix;

                    bool isPrefix = true;
                    foreach (var str in strs) 
                    {
                        if (!str.StartsWith(prefix))
                        {
                            isPrefix = false;
                            break;
                        }
                    }

                    if (isPrefix)
                        return prefix;
                }
                
                return prefix;
            }

            private static string Min(string[] strs)
            {
                var minLength = strs.Select(str => str.Length)
                           .Min();

                foreach (var str in strs)
                {
                    if (str.Length == minLength)
                    {
                        return str;
                    }
                }

                return string.Empty;
            }
        }
    }
}
