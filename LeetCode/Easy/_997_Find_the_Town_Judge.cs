namespace LeetCode.Easy._997
{
    public class Solution
    {
        public int FindJudge(int n, int[][] trust)
        {
            var ishonchlilik = new int[n + 1]; 

            foreach(var item in trust)
            {
                ishonchlilik[item[0]]--;
                ishonchlilik[item[1]]++;
            }

            for (int i = 1; i <= n; i++)
            {
                if (ishonchlilik[i] == n - 1)
                    return i;
            }

            return -1;
        }
    }

    internal class _997_Find_the_Town_Judge
    {
        //public static void Main()
        //{
        //    Solution solution = new Solution();
        //    int n = 3;
        //    int[][] trust = new int[][]
        //    {
        //        new int[] {1, 2},
        //        new int[] {2, 3}
        //    };
        //    Console.WriteLine(solution.FindJudge(n, trust));
        //}
    }
}
