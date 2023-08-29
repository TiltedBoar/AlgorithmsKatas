using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class BalancedBinaryTreeTest
    {
        private readonly BalancedBinaryTree _sut;

        public BalancedBinaryTreeTest()
        {
            _sut = new BalancedBinaryTree();
        }

        [Fact]
        public void GivenTreeNodes_When_TreeIsBalancedWithDifferentHeight_Then_ReturnTrue()
        {
            // Simple balanced tree:       1
            //                            / \
            //                           2   2
            //                          / \
            //                         3   3
            var root = new BalancedBinaryTree.TreeNode(1, new BalancedBinaryTree.TreeNode(2, new BalancedBinaryTree.TreeNode(3),
                    new BalancedBinaryTree.TreeNode(3)), new BalancedBinaryTree.TreeNode(2));

            var result = _sut.IsBalanced(root);

            Assert.True(result);
        }

        [Fact]
        public void GivenTreeNodes_When_TreeHasDifferentHeight_Then_ReturnTrue()
        {
            // Simple balanced tree with higher left subtree:
            //                             1
            //                            / \
            //                           2   2
            //                          /
            //                         3
            var root = new BalancedBinaryTree.TreeNode(1, new BalancedBinaryTree.TreeNode(2, new BalancedBinaryTree.TreeNode(3),
                    null), new BalancedBinaryTree.TreeNode(2));
            var result = _sut.IsBalanced(root);

            Assert.True(result);
        }

        [Fact]
        public void GivenTreeNodes_When_TreeIsComplexAndBalanced_Then_ReturnTrue()
        {
            // Complex balanced tree:       1
            //                            /   \
            //                           2     2
            //                          / \   / \
            //                         3   4 4   3
            var root = new BalancedBinaryTree.TreeNode(1, new BalancedBinaryTree.TreeNode(2, new BalancedBinaryTree.TreeNode(3),
                new BalancedBinaryTree.TreeNode(4)), new BalancedBinaryTree.TreeNode(2, new BalancedBinaryTree.TreeNode(4), new BalancedBinaryTree.TreeNode(3)));

            var result = _sut.IsBalanced(root);

            Assert.True(result);
        }

        [Fact]
        public void GivenTreeNodes_When_TreeIsComplexAndBalancedWithLeftSubtreeHigher_ThenReturnTrue()
        {
            // Complex tree with higher left subtree:
            //                              1
            //                            /   \
            //                           2     2
            //                          / \   / \
            //                         3   4 4   3
            //                        /
            //                       5
            var root = new BalancedBinaryTree.TreeNode(1,
                new BalancedBinaryTree.TreeNode(2, new BalancedBinaryTree.TreeNode(3, new BalancedBinaryTree.TreeNode(5), null),
                new BalancedBinaryTree.TreeNode(4)), new BalancedBinaryTree.TreeNode(2, new BalancedBinaryTree.TreeNode(4), new BalancedBinaryTree.TreeNode(3)));

            var result = _sut.IsBalanced(root);

            Assert.True(result);
        }

        [Fact]
        public void GivenTreeNodes_WHen_TreeIsEmpty_Then_ReturnTrue()
        {
            BalancedBinaryTree.TreeNode root = null;

            var result = _sut.IsBalanced(root);

            Assert.True(result);
        }
        [Fact]
        public void GivenTreeNodes_When_TreeIsUnbalancedWithLeftSubtreeHigher_Then_ReturnFalse()
        {
            // Unbalanced tree with higher left subtree:
            //                          1
            //                        /   \
            //                       2     3
            //                      / \   / \
            //                     4   5 6   7
            //                    /
            //                   8
            //                  /
            //                 9
            var root = new BalancedBinaryTree.TreeNode(1, new BalancedBinaryTree.TreeNode(2, new BalancedBinaryTree.TreeNode(4,
                        new BalancedBinaryTree.TreeNode(8, new BalancedBinaryTree.TreeNode(9), null), null), new BalancedBinaryTree.TreeNode(5)),
                        new BalancedBinaryTree.TreeNode(3, new BalancedBinaryTree.TreeNode(6), new BalancedBinaryTree.TreeNode(7)));

            var result = _sut.IsBalanced(root);

            Assert.False(result);
        }
        [Fact]
        public void GivenTreeNodes_When_TreeIsUnbalancedWithRightSubtree_Then_ReturnFalse()
        {
            // Unbalanced with higher right subtree:
            //                       1
            //                      /   \
            //                     2     3
            //                        /   \
            //                       4     5
            //                        \
            //                         6
            //                          \
            //                           7
            var root = new BalancedBinaryTree.TreeNode(1, new BalancedBinaryTree.TreeNode(2), new BalancedBinaryTree.TreeNode(3, null,
                    new BalancedBinaryTree.TreeNode(4, null, new BalancedBinaryTree.TreeNode(5, new BalancedBinaryTree.TreeNode(6, null,
                                new BalancedBinaryTree.TreeNode(7)), null))));

            var result = _sut.IsBalanced(root);

            Assert.False(result);
        }
    }
}