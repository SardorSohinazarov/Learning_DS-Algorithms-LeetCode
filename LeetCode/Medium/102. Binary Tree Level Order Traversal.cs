namespace LeetCode.Medium._102
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Count(root, result, 0);
            return result;
        }

        public void Count(TreeNode root, IList<IList<int>> result, int level)
        {
            if (root is null)
                return;
            else
            {
                if (result.Count > level)
                    result[level].Add(1);
                else
                {
                    while (level >= result.Count)
                    {
                        result.Add(new List<int>());
                    }

                    result[level].Add(1);
                }

                Count(root.left, result, level + 1);
                Count(root.right, result, level + 1);
            }
        }

    }

    internal class _102
    {
        //public static void Main()
        //{
        //    Solution solution = new Solution();
        //    TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        //    Console.WriteLine(solution.LevelOrder(root));
        //}
    }
}
