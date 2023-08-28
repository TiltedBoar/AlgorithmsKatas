using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class MoveZeroesTest
    {
        private readonly MoveZeroes _sut;
        public MoveZeroesTest()
        {
            _sut = new MoveZeroes();
        }
        [Fact]
        public void ShouldMoveZerosToEnd()
        {

            int[] nums = { 0, 1, 0, 3, 12 };
            int[] expected = { 1, 3, 12, 0, 0 };
            _sut.MoveZeroesToEndOfList(nums);
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void ShouldHandleSingleZero()
        {
            int[] nums = { 0 };
            int[] expected = { 0 };
            _sut.MoveZeroesToEndOfList(nums);
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void ShouldHandleNoZeros()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            _sut.MoveZeroesToEndOfList(nums);
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void ShouldHandleAllZeros()
        {
            int[] nums = { 0, 0, 0, 0 };
            int[] expected = { 0, 0, 0, 0 };
            _sut.MoveZeroesToEndOfList(nums);
            Assert.Equal(expected, nums);
        }
    }
}
