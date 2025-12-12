namespace LeetCode.Medium._129
{
    internal class _129
    {
        //private static void Main()
        //{
        //    //Solution solution = new Solution();
        //    ////root = [1,2,3]
        //    //TreeNode root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        //    //Console.WriteLine(solution.SumNumbers(root));
        //}
    }

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
        //public int SumNumbers(TreeNode root)
        //{
        //    return 10 * root.val + SumNumbers();
        //}

        //public (int,int) Sum(TreeNode root)
        //{
        //    if (root.left == null && root.right == null)
        //        return (root.val, 1);

        //    var resultLeft = Sum(root.left);
        //    var resultRight = Sum(root.right);

        //    return ((Math.Pow(root.val, resultLeft.Item2) + resultLeft.Item1) +
        //        (Math.Pow(root.val, resultRight.Item2) + resultRight.Item1),
        //        resultLeft
        //        );
        //}
    }
}
