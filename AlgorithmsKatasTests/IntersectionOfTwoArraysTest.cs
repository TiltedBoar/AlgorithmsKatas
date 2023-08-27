using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class IntersectionOfTwoArraysTest
    {
        private readonly IntersectionOfTwoArrays _sut;
        public IntersectionOfTwoArraysTest()
        {
            _sut = new IntersectionOfTwoArrays();
        }
        [Fact]
        public void ReturnsIntersectionArray()
        {

            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };
            int[] result = _sut.Intersection(nums1, nums2);
            int[] expected = new int[] { 2 };

            int[] nums3 = new int[] { 4, 9, 5 };
            int[] nums4 = new int[] { 9, 4, 9, 8, 4 };
            int[] result2 = _sut.Intersection(nums3, nums4);
            int[] expected2 = new int[] { 4, 9 };
            //jak zrobić operator or, 9,4 albo 4,9

            Assert.Equal(expected, result);
            Assert.Equal(expected2, result2);
        }

        [Fact]
        public void ReturnsEmptyArrayWhenNoIntersection()
        {
            int[] nums1 = new int[] { 1, 2, 3, 4 };
            int[] nums2 = new int[] { 5, 6, 7, 8 };
            int[] expected = new int[] { };
            int[] result = _sut.Intersection(nums1, nums2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnsUniqueIntersectionValues()
        {
            int[] nums1 = new int[] { 1, 2, 2, 3 };
            int[] nums2 = new int[] { 2, 2, 3, 4 };
            int[] expected = new int[] { 2, 3 };
            int[] result = _sut.Intersection(nums1, nums2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnsEmptyArrayWhenOneArrayIsEmpty()
        {
            int[] nums1 = new int[] { 1, 2, 3 };
            int[] nums2 = new int[] { };
            int[] expected = new int[] { };
            int[] result = _sut.Intersection(nums1, nums2);
            Assert.Equal(expected, result);
        }
    }
}
