using System.Text.Json;

namespace LeetCode.Easy._283 // Solved
{
    internal class _283_Move_Zeroes
    {
        //public static void Main()
        //{
        //    Solution s = new Solution();
        //    int[] nums = { 0, 1, 0, 3, 12 };
        //    s.MoveZeroes(nums);
        //    Console.WriteLine(JsonSerializer.Serialize(nums));
        //}
    }

    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            var left = 0;
            var right = 0;
            if (nums.Length == 0 || nums.Length == 1)
                return;

            for(right = 0; right < nums.Length; right++)
            {
                if (nums[left] == 0 && nums[right] != 0)
                {
                    nums[left] = nums[right];
                    nums[right] = 0;
                    left++;
                }
                else if (nums[left] != 0)
                {
                    left++;
                }
            }
        }
    }
}
