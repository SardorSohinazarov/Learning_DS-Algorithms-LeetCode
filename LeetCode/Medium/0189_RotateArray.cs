
namespace LeetCode.Medium._189
{
    internal class _189
    {
    }

    class Solution
    {
        public int[] rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);

            return nums;
        }

        private void Reverse(int[] nums, int start, int end)
        {
            for (int i = start, j = end; i < j; i++, j--)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
}
