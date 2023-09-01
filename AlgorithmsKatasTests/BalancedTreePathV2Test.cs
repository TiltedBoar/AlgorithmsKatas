using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class BalancedBinaryTreeV2Tests
    {
        private readonly BalancedBinaryTreeV2 _sut;

        public BalancedBinaryTreeV2Tests()
        {
            _sut = new BalancedBinaryTreeV2();
        }

        [Fact]
        public void GivenTreeNodes_When_TreeIsBalancedWithDifferentHeight_Then_ReturnTrue()
        {
            // Simple balanced tree:       1
            //                            / \
            //                           2   2
            //                          / \
            //                         3   3
            var root = new BalancedBinaryTreeV2.TreeNode(1, new BalancedBinaryTreeV2.TreeNode(2, new BalancedBinaryTreeV2.TreeNode(3),
                    new BalancedBinaryTreeV2.TreeNode(3)), new BalancedBinaryTreeV2.TreeNode(2));

            var result = _sut.IsBalancedV2(root);

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
            var root = new BalancedBinaryTreeV2.TreeNode(1, new BalancedBinaryTreeV2.TreeNode(2, new BalancedBinaryTreeV2.TreeNode(3),
                    null), new BalancedBinaryTreeV2.TreeNode(2));
            var result = _sut.IsBalancedV2(root);

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
            var root = new BalancedBinaryTreeV2.TreeNode(1, new BalancedBinaryTreeV2.TreeNode(2, new BalancedBinaryTreeV2.TreeNode(3),
                new BalancedBinaryTreeV2.TreeNode(4)), new BalancedBinaryTreeV2.TreeNode(2, new BalancedBinaryTreeV2.TreeNode(4), new BalancedBinaryTreeV2.TreeNode(3)));

            var result = _sut.IsBalancedV2(root);

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
            var root = new BalancedBinaryTreeV2.TreeNode(1,
                new BalancedBinaryTreeV2.TreeNode(2, new BalancedBinaryTreeV2.TreeNode(3, new BalancedBinaryTreeV2.TreeNode(5), null),
                new BalancedBinaryTreeV2.TreeNode(4)), new BalancedBinaryTreeV2.TreeNode(2, new BalancedBinaryTreeV2.TreeNode(4), new BalancedBinaryTreeV2.TreeNode(3)));

            var result = _sut.IsBalancedV2(root);

            Assert.True(result);
        }

        [Fact]
        public void GivenTreeNodes_WHen_TreeIsEmpty_Then_ReturnTrue()
        {
            BalancedBinaryTreeV2.TreeNode root = null;

            var result = _sut.IsBalancedV2(root);

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
            var root = new BalancedBinaryTreeV2.TreeNode(1, new BalancedBinaryTreeV2.TreeNode(2, new BalancedBinaryTreeV2.TreeNode(4,
                        new BalancedBinaryTreeV2.TreeNode(8, new BalancedBinaryTreeV2.TreeNode(9), null), null), new BalancedBinaryTreeV2.TreeNode(5)),
                        new BalancedBinaryTreeV2.TreeNode(3, new BalancedBinaryTreeV2.TreeNode(6), new BalancedBinaryTreeV2.TreeNode(7)));

            var result = _sut.IsBalancedV2(root);

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
            var root = new BalancedBinaryTreeV2.TreeNode(1, new BalancedBinaryTreeV2.TreeNode(2), new BalancedBinaryTreeV2.TreeNode(3, null,
                    new BalancedBinaryTreeV2.TreeNode(4, null, new BalancedBinaryTreeV2.TreeNode(5, new BalancedBinaryTreeV2.TreeNode(6, null,
                                new BalancedBinaryTreeV2.TreeNode(7)), null))));

            var result = _sut.IsBalancedV2(root);

            Assert.False(result);
        }
    }
}