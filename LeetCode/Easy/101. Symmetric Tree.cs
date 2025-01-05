namespace LeetCode.Easy._101
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
        public bool IsSymmetric(TreeNode root)
        {
            return Equals(root.left, root.right);
        }

        public bool Equals(TreeNode left, TreeNode right)
        {
            if(left == null && right == null)
                return true;
            else if (left == null || right == null)
                return false;
            else if (left.val != right.val)
                return false;
            else
                return Equals(left.left, right.right) 
                    && Equals(left.right, right.left);
        }
    }

    internal class _101
    {
        //public static void Main()
        //{
        //    Solution solution = new Solution();
        //    TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3)));
        //    Console.WriteLine(solution.IsSymmetric(root));
        //}
    }
}
