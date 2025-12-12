namespace LeetCode.Easy._104
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
        public int MaxDepth(TreeNode root)
        {
            if(root == null)
                return 0;

            if(root.left == null)
                return 1 + MaxDepth(root.right);

            if(root.right == null)
                return 1 + MaxDepth(root.left);

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }

    internal class _104_Maximum_Depth_of_Binary_Tree
    {
        //public static void Main()
        //{
        //    Solution solution = new Solution();
        //    TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        //    Console.WriteLine(solution.MaxDepth(root));
        //}
    }
}
