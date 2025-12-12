using System.Collections.Generic;

namespace LeetCode.Easy._217
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = nums.ToHashSet<int>();
            foreach (var num in nums)
            {
                if (!set.Add(num))
                    return true;
            }

            return false;

            //// Alternative solution: lekin bu tezlikdan va hotiradan ko'proq ishlatadi
            //HashSet<int> set = nums.ToHashSet<int>();
            //return set.Count() != nums.Count();
        }
    }
    internal class _217_Contains_Duplicate
    {
    }
}
