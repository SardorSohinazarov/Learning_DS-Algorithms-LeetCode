namespace LeetCode.Medium._11
{
    public class _11
    {
        //private static void Main()
        //{
        //    //Solution solution = new Solution();
        //    //Console.WriteLine(solution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
        //}
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var maxArea = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    var area = (right - left) * height[left];
                    maxArea = maxArea < area ? area : maxArea;
                    left++;
                }
                else
                {
                    var area = (right - left) * height[right];
                    maxArea = maxArea < area ? area : maxArea;
                    right--;
                }
            }

            return maxArea;
        }
    }
}
