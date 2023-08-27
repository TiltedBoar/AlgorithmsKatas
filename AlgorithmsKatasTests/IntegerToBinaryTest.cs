using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{

    public class IntegerToBinaryTest
    {
        private readonly IntegerToBinary _sut;
        public IntegerToBinaryTest()
        {
            _sut = new IntegerToBinary();
        }

        [Fact]
        public void IntegerToBinaryTests()
        {

            var result = _sut.ToBinary(2);
            var result2 = _sut.ToBinary(3);
            var result3 = _sut.ToBinary(4);
            var result4 = _sut.ToBinary(-3);
            var result5 = _sut.ToBinary(-4);
            var result6 = _sut.ToBinary(-8);
            Assert.Equal("10", result);
            Assert.Equal("11", result2);
            Assert.Equal("100", result3);
            Assert.Equal("11111111111111111111111111111101", result4);
            Assert.Equal("11111111111111111111111111111100", result5);
            Assert.Equal("11111111111111111111111111111000", result6);
        }
        [Fact]
        public void IntegerToBinaryTestsV2()
        {

            var result = _sut.ToBinaryV2(2);
            var result2 = _sut.ToBinaryV2(3);
            var result3 = _sut.ToBinaryV2(4);
            var result4 = _sut.ToBinaryV2(-3);
            var result5 = _sut.ToBinaryV2(-4);
            var result6 = _sut.ToBinaryV2(-8);
            Assert.Equal("10", result);
            Assert.Equal("11", result2);
            Assert.Equal("100", result3);
            Assert.Equal("11111111111111111111111111111101", result4);
            Assert.Equal("11111111111111111111111111111100", result5);
            Assert.Equal("11111111111111111111111111111000", result6);
        }
    }
}
