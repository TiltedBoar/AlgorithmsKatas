using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class BinaryTreePathTest
    {
        private readonly BinaryTreePath _sut;
        public BinaryTreePathTest()
        {
            _sut = new BinaryTreePath();
        }
        [Fact]
        public void BinaryTreePath_ReturnsCorrectPaths()
        {

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(5);

            var expectedPaths = new List<string> { "1->2->5", "1->3" };

            var result = _sut.BinaryTreePaths(root);
            Assert.Equal(expectedPaths, result);
        }

        [Fact]
        public void BinaryTreePath_ReturnsSingleRootNode()
        {

            var root = new TreeNode(42);
            var expectedPath = new List<string> { "42" };
            var result = _sut.BinaryTreePaths(root);
            Assert.Equal(expectedPath, result);
        }

        [Fact]
        public void BinaryTreePath_ReturnsEmptyListForNullRoot()
        {

            var result = _sut.BinaryTreePaths(null);
            Assert.Empty(result);
        }
        [Fact]
        public void BinaryTreePaths_ReturnsCorrectPaths()
        {
            var binaryTreePath = new BinaryTreePath();

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(5);

            var expectedPaths = new List<string> { "1->2->5", "1->3" };

            var result = binaryTreePath.BinaryTreePaths(root);

            Assert.Equal(expectedPaths, result);
        }

        [Fact]
        public void BinaryTreePaths_ReturnsSingleRootNode()
        {
            var binaryTreePath = new BinaryTreePath();

            var root = new TreeNode(42);

            var expectedPath = new List<string> { "42" };

            var result = binaryTreePath.BinaryTreePaths(root);

            Assert.Equal(expectedPath, result);
        }

        [Fact]
        public void BinaryTreePaths_ReturnsEmptyListForNullRoot()
        {
            var binaryTreePath = new BinaryTreePath();

            var result = binaryTreePath.BinaryTreePaths(null);

            Assert.Empty(result);
        }

        [Fact]
        public void BinaryTreePaths_ReturnsCorrectPaths_ForComplexTree()
        {
            var binaryTreePath = new BinaryTreePath();

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            var expectedPaths = new List<string>
            {
                "1->2->4",
                "1->2->5",
                "1->3->6",
                "1->3->7"
            };

            var result = binaryTreePath.BinaryTreePaths(root);

            Assert.Equal(expectedPaths, result);
        }

        [Fact]
        public void BinaryTreePaths_ReturnsEmptyList_ForEmptyTree()
        {
            var binaryTreePath = new BinaryTreePath();

            var result = binaryTreePath.BinaryTreePaths(null);

            Assert.Empty(result);
        }

        [Fact]
        public void BinaryTreePaths_ReturnsCorrectPaths_ForSingleBranchTree()
        {
            var binaryTreePath = new BinaryTreePath();

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.left.left = new TreeNode(4);

            var expectedPaths = new List<string>
            {
                "1->2->3->4"
            };

            var result = binaryTreePath.BinaryTreePaths(root);

            Assert.Equal(expectedPaths, result);
        }

        [Fact]
        public void BinaryTreePaths_ReturnsCorrectPaths_ForDuplicateValues()
        {

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);

            var expectedPaths = new List<string>
            {
                "1->2->3",
                "1->2->4",
                "1->2"
            };

            var result = _sut.BinaryTreePaths(root);

            Assert.Equal(expectedPaths, result);
        }

        [Fact]
        public void BinaryTreePaths_ReturnsCorrectPaths_ForNegativeValues()
        {
            var root = new TreeNode(-1);
            root.left = new TreeNode(-2);
            root.right = new TreeNode(-3);
            root.left.left = new TreeNode(-4);

            var expectedPaths = new List<string>
            {
                "-1->-2->-4",
                "-1->-3"
            };

            var result = _sut.BinaryTreePaths(root);

            Assert.Equal(expectedPaths, result);
        }
    }
}

