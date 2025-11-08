namespace LeetCode.Easy._997
{
    public class Solution
    {
        //public static void Main()
        //{
        //    int[][] trust = [[1, 2]];
        //    Console.WriteLine(FindJudge(2, trust));
        //}

        public static int FindJudge(int n, int[][] trust)
        {
            var followers = new int[n + 1];
            var following = new int[n + 1];

            foreach (var i in trust) 
            {
                following[i[0]] ++;
                followers[i[1]] ++;
            }

            for (var i = 1; i <= n ; i++)
            {
                if (following[i] == 0 && followers[i] == n-1)
                    return i;
            }

            return -1;
        }
    }
}
