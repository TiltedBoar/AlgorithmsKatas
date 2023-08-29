namespace AlgorithmsKatas
{
    //https://leetcode.com/problems/balanced-binary-tree/
    public class BalancedBinaryTree
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

        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            int treeHeight = Height(root);
            return treeHeight >= 0;
        }

        //-1 child is imbalanced
        private int Height(TreeNode node)
        {
            int height;
            if (node == null)
            {
                return 0;
            }
            //calculate height of the children
            var leftChildHeight = Height(node.left);
            var rightChildHeight = Height(node.right);
            //if child is not balanced, mark it the tree as unbalanced, exit the code immediately if it is -1
            if (leftChildHeight == -1 || rightChildHeight == -1)
            {
                return -1;
            }

            //check if left node is not balanced
            if ((leftChildHeight - rightChildHeight) > 1)
            {
                return -1;
            }
            //check if right node is not balanced
            if ((rightChildHeight - leftChildHeight) > 1)
            {

                return -1;
            }

            //return the tallest child and increment by one (+1 because only then it will become height of the parent)
            if (leftChildHeight > rightChildHeight)
            {
                height = 1 + leftChildHeight;
            }
            else
            {
                height = 1 + rightChildHeight;
            }

            return height;

        }
    }
}

