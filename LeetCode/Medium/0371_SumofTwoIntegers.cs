using System.Runtime.CompilerServices;

namespace LeetCode.Medium
{
    public class _0371_SumofTwoIntegers
    {
        public class Solution
        {
            //private static void Main()
            //{
            //    var solution = new Solution();
            //    int a = 1, b = 2;
            //    var result = solution.GetSum(a, b);
            //    Console.WriteLine(result); // Output: 3
            //}

            public int GetSum(int a, int b)
            {
                int carry = 0;
                int result = 0;

                for (int i = 0; i < 32; i++)
                {
                    int bitA = (a >> i) & 1;
                    int bitB = (b >> i) & 1;
                    int sum = bitA ^ bitB ^ carry;
                    carry = (bitA & bitB) | (carry & (bitA ^ bitB));
                    result |= (sum << i);
                }

                return result;
            }
        }
    }
}
