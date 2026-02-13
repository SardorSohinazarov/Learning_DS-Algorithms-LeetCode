namespace LeetCode.Easy
{
    internal class _0461_HammingDistance
    {
        public class Solution
        {
            public int HammingDistance(int x, int y)
            {
                int diff = 0;

                while (x != 0 || y != 0)
                {
                    diff += (x & 1) ^ (y & 1);
                    x = x >> 1;
                    y = y >> 1;
                }

                return diff;
            }
        }
    }
}
