using AlgorithmsKatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class ContainsDuplicateTest
    {
        private readonly ContainsDuplicate _sut;

        public ContainsDuplicateTest()
        {
            _sut = new ContainsDuplicate();
        }
        [Fact]
        public void ContainsDuplicateTests()
        {
           
            var result1 = _sut.ContainsDuplicates(new int[] { 1, 2, 3, 1 });
            var result2 = _sut.ContainsDuplicates(new int[] { 1, 2, 3, 4 });
            var result3 = _sut.ContainsDuplicates(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
            var result4 = _sut.ContainsDuplicates(new int[] { 9, 8, 7, 3, 6, 5, 1, 0, 4, 2 });
            var expected1 = true;
            var expected2 = false;
            var expected3 = true;
            var expected4 = false;
            Assert.Equal(expected1, result1);
            Assert.Equal(expected2, result2);
            Assert.Equal(expected3, result3);
            Assert.Equal(expected4, result4);
        }
    }
}
