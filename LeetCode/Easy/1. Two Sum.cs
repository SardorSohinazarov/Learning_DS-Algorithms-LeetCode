namespace LeetCode.Easy
{
    internal class _1
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                HashSet<int> hashSet = nums.ToHashSet();

                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    if (hashSet.Contains(complement))
                    {
                        for (int j = 0; j < nums.Length; j++)
                        {
                            if (nums[j] == complement && j != i)
                            {
                                return new int[] { i, j };
                            }
                        }
                    }
                }

                return Array.Empty<int>();
            }
        }
    }
}
