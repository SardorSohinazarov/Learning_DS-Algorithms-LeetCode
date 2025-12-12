namespace LeetCode.Easy
{
    internal class _338
    {
        public class Solution
        {
            //public static void Main()
            //{
            //    int n = 5;
            //    var solution = new Solution();
            //    var result = solution.CountBits(n);
            //    Console.WriteLine(string.Join(", ", result));
            //}

            public int[] CountBits(int n)
            {
                var nums = new int[n + 1];
                for (int i = 0; i <= n; i++)
                {
                    nums[i] = i;
                }
                var result = new List<int>();

                foreach (var num in nums)
                {
                    result.Add(CountOfBits(num));
                }

                return result.ToArray();
            }

            public int CountOfBits(int num)
            {
                int count = 0;

                while (num > 1)
                {
                    var qoldiq = num % 2;
                    if (qoldiq == 1)
                    {
                        count++;
                    }
                    num = num >> 1;
                }

                if (num == 1)
                    count++;

                return count;
            }
        }
    }
}
