namespace LeetCode.Easy._222
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
        public int CountNodes(TreeNode root)
        {
            if (root == null)
                return 0;

            if (root.left == null)
                return 1 + CountNodes(root.right);

            if (root.right == null)
                return 1 + CountNodes(root.left);

            return 1 + CountNodes(root.left) + CountNodes(root.right);
        }
    }

    internal class _222_Count_Complete_Tree_Nodes
    {
        //public static void Main()
        //{
        //    Solution solution = new Solution();
        //    TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6), null));
        //    Console.WriteLine(solution.CountNodes(root));
        //}
    }
}
