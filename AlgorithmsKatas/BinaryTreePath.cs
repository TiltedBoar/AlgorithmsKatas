namespace AlgorithmsKatas
{
    //https://leetcode.com/problems/binary-tree-paths/

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
    public class BinaryTreePath
    {
        public List<string> paths = new List<string>();

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            GeneratePath(paths, root, "");
            return paths;
        }

        public void GeneratePath(List<string> result, TreeNode? root, string currentPath)
        {
            if (root == null)
            {
                return;
            }

            currentPath = $"{currentPath}{root.val}"; //current path is a string, is not mutable, thus there is created a new instance every single time
            if (root.left is null && root.right is null) // if both are null, then add current path and then go to the other side of the tree
            {
                result.Add(currentPath);
            }

            var arrowPath = $"{currentPath}->";
            GeneratePath(result, root.left, arrowPath);
            GeneratePath(result, root.right, arrowPath);
        }



        ////right>root>left
        //public void GeneratePath2(List<string> result, TreeNode? root, string currentPath)
        //{
        //    if (root == null)
        //    {
        //        return;
        //    }
        //    currentPath = $"{currentPath}{root.val}";
        //    var arrowPath = $"{currentPath}->";
        //    GeneratePath(result, root.right, arrowPath);
        //    if (root.left is null && root.right is null)
        //    {
        //        result.Add(currentPath);
        //    }


        //    GeneratePath(result, root.left, arrowPath);

        //}

        //// left>root>right
        //public void GeneratePat3(List<string> result, TreeNode? root, string currentPath)
        //{
        //    if (root == null)
        //    {
        //        return;
        //    }

        //    currentPath = $"{currentPath}{root.val}";
        //    var arrowPath = $"{currentPath}->";
        //    GeneratePath(result, root.left, arrowPath);
        //    if (root.left is null && root.right is null)
        //    {
        //        result.Add(currentPath);
        //    }
        //    GeneratePath(result, root.right, arrowPath);

        //}
    }
}
