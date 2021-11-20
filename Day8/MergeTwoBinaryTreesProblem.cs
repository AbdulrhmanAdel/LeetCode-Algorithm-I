namespace Algorithm_I.Day8
{
    public class MergeTwoBinaryTreesProblem
    {
        /*
         * You are given two binary trees root1 and root2.
         * Imagine that when you put one of them to cover the other,
         * some nodes of the two trees are overlapped while the others are not.
         * You need to merge the two trees into a new binary tree.
         * The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node.
         * Otherwise, the NOT null node will be used as the node of the new tree.
         * Return the merged tree.
         *
         * Note: The merging process must start from the root nodes of both trees.
         */
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null) return root2;
            if (root2 == null) return root1;
            root1.val += root2.val;
            root1.left = MergeLeftBranches(root1.left, root2.left);
            root1.right = MergeRightBranches(root1.right, root2.right);
            return root1;
        }

        private TreeNode MergeLeftBranches(TreeNode rootLeft, TreeNode left2)
        {
            if (left2 == null)
            {
                return rootLeft;
            }

            if (rootLeft == null)
            {
                return left2;
            }

            rootLeft.val += left2.val;
            rootLeft.left = MergeLeftBranches(rootLeft.left, left2.left);
            rootLeft.right = MergeRightBranches(rootLeft.right, left2.right);
            return rootLeft;
        }

        private TreeNode MergeRightBranches(TreeNode right1, TreeNode right2)
        {
            if (right2 == null)
            {
                return right1;
            }

            if (right1 == null)
            {
                return right2;
            }

            right1.val += right2.val;
            right1.left = MergeLeftBranches(right1.left, right2.left);
            right1.right = MergeRightBranches(right1.right, right2.right);
            return right1;
        }
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
}