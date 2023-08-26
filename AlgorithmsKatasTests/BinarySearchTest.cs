using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class BinarySearchTest
    {
        private readonly BinarySearch _sut;
        public BinarySearchTest()
        {
            _sut = new BinarySearch();
        }
        [Fact]
        public void Exist()
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 9;

            int result = _sut.Search4(nums, target);

            Assert.Equal(4, result);
        }

        [Fact]
        public void DoesNotExist()
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 2;

            int result = _sut.Search4(nums, target);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void EmptyArray()
        {
            int[] nums = new int[0];
            int target = 5;

            int result = _sut.Search4(nums, target);

            Assert.Equal(-1, result);
        }

    }
}
