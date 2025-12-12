namespace LeetCode.Easy
{
    internal class _268
    {
        public class Solution
        {
            public int MissingNumber(int[] nums)
            {
                var n = nums.Length;

                var total = n * (n + 1) / 2;

                return total - nums.Sum();
            }
        }
    }
}
