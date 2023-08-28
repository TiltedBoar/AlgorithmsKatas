using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class WordPatternTest
    {
        private readonly WordPattern _sut;
        public WordPatternTest()
        {
            _sut = new WordPattern();
        }
        [Fact]
        public void Given_WordPattern_When_PatternWithTwoParametersSameTwoWords_Then_ReturnValidPattern()
        {
            var pattern = "abab";
            var s = "dog cat dog cat";
            var result = _sut.WordPatternOfChar(pattern, s);
            Assert.True(result);
        }

        [Fact]
        public void Given_WordPattern_When_PatternWithThreeParametersTwoWords_Then_ReturnInvalidPattern()
        {
            var pattern = "abcb";
            var s = "dog cat dog cat";
            var result = _sut.WordPatternOfChar(pattern, s);
            Assert.False(result);
        }

        [Fact]
        public void Given_WordPattern_When_PatternWithThreeParametersSameThreeWords_Then_ReturnValidPattern()
        {
            var pattern = "abcb";
            var s = "dog cat hat cat";
            var result = _sut.WordPatternOfChar(pattern, s);
            Assert.True(result);
        }

        [Fact]
        public void Given_WordPattern_When_PatternWithTwoParametersDifferentTwoWords_Then_ReturnInvalidPattern()
        {
            var pattern = "aabb";
            var s = "dog cat dog cat";
            var result = _sut.WordPatternOfChar(pattern, s);
            Assert.False(result);
        }

        [Fact]
        public void Given_WordPattern_When_PatternWithFourParametersThreeWords_Then_ReturnInvalidPattern()
        {
            var pattern = "abcde";
            var s = "dog cat hat cat";
            var result = _sut.WordPatternOfChar(pattern, s);
            Assert.False(result);
        }

        [Fact]
        public void Given_WordPattern_When_PatternWithTwoParametersThreeWords_Then_ReturnInvalidPattern()
        {
            var pattern = "ab";
            var s = "dog cat dog";
            bool result = _sut.WordPatternOfChar(pattern, s);
            Assert.False(result);
        }
    }
}