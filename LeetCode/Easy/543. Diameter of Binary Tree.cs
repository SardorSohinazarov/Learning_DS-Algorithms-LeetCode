namespace LeetCode.Easy._543
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
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;
            var left = GetHight(root.left);
            var right = GetHight(root.right);

            return left + right;
        }

        public int GetHight(TreeNode root)
        {
            if(root is null)
                return 0;
            else if(root.left is null && root.right is null)
                return 1;
            else { 
                return 1 + Math.Max(GetHight(root.left), GetHight(root.right));
            }
        }

        internal class _543
        {
            //public static void Main()
            //{
            //    Solution solution = new Solution();
            //    //root = [4, -7, -3, null, null, -9, -3, 9, -7, -4, null, 6, null, -6, -6, null, null, 0, 6, 5, null, 9, null, null, -1, -4, null, null, null, -2]
            //    TreeNode root = new TreeNode(4, new TreeNode(-7, null, null), new TreeNode(-3, new TreeNode(-9, null, null), new TreeNode(-3, new TreeNode(9, new TreeNode(-7, null, null), new TreeNode(-4, null, new TreeNode(6, null, null))), new TreeNode(6, new TreeNode(-6, null, null), new TreeNode(-6, new TreeNode(0, null, new TreeNode(6, new TreeNode(5, null, new TreeNode(9, null, null)), null)), new TreeNode(-1, new TreeNode(-4, null, null), new TreeNode(-2, null, null)))))));
            //    Console.WriteLine(solution.DiameterOfBinaryTree(root));
            //}
        }
    }
}
