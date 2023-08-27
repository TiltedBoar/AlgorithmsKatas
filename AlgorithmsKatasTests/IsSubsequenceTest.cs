using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class IsSubsequenceTest
    {
        private readonly IsSubsequence _sut;
        public IsSubsequenceTest()
        {
            _sut = new IsSubsequence();
        }
        [Theory]
        [InlineData("abc", "ahbgdc", true)]
        [InlineData("axc", "ahbgdc", false)]
        [InlineData("", "ahbgdc", true)]
        [InlineData("abc", "", false)]
        [InlineData("aaa", "aa", false)] 
        [InlineData("abc", "abracadabra", true)]
        [InlineData("abcdef", "abcdef", true)]
        public void IsSubsequenceTests(string s, string t, bool expected)
        {
            bool result = _sut.IsSubsequence1(s, t);
            Assert.Equal(expected, result);
        }
    }
}
