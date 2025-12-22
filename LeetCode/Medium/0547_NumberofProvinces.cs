namespace LeetCode.Medium
{
    internal class _0547_NumberofProvinces
    {
        public class Solution
        {
            public int FindCircleNum(int[][] isConnected)
            {
                int n = isConnected.Length;
                bool[] visited = new bool[n];
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (!visited[i])
                    {
                        count++;
                        DFS(isConnected, visited, i);
                    }
                }

                return count;
            }

            private void DFS(int[][] isConnected,bool[] visited, int node)
            {
                visited[node] = true;

                for (int next = 0; next < isConnected.Length; next++)
                {
                    if(isConnected[node][next] == 1 && !visited[next])
                    {
                        DFS(isConnected, visited, next);
                    }                   
                }
            }
        }
    }
}
