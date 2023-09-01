namespace AlgorithmsKatas
{
    //https://leetcode.com/problems/balanced-binary-tree/
    public class BalancedBinaryTreeV2
    {
        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        bool isBalancedV2 = true;
        public bool IsBalancedV2(TreeNode root)
        //determine if the tree is balanced
        {
            HeightV2(root);
            return isBalancedV2;

        }
        private int HeightV2(TreeNode root)
        {
            if (root == null) return 0;
            int leftChild = 1 + HeightV2(root.left);//check height of the left child
            int rightChild = 1 + HeightV2(root.right); //check the height of the right child
            if (Math.Abs(rightChild - leftChild) > 1) // check absolute difference between left and right, if the result is greater than 1,
                                                      // return false, indicating that tree is not balanced
            {
                isBalancedV2 = false;
            }
            return Math.Max(leftChild, rightChild); // if the tree is balanced return the height
        }
    }
}
