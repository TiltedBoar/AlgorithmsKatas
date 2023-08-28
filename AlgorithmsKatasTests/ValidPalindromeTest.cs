using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class ValidPalindromeTest
    {
        private readonly ValidPalindrome _sut;
        public ValidPalindromeTest()
        {
            _sut = new ValidPalindrome();
        }
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData("Madam, in Eden, I'm Adam", true)]
        [InlineData("12321", true)]
        [InlineData("No lemon, no melon", true)]
        [InlineData("Hello, world!", false)]
        [InlineData("", true)]
        [InlineData(" ", true)]
        public void IsPalindromeValidInputsReturnsExpectedResult(string input, bool expected)
        {

            bool result = _sut.IsPalindrome(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Was it a car or a cat I saw?", true)]
        [InlineData("A Toyota's a Toyota.", true)]
        public void IsPalindromeSpecialCharactersAndSpacesReturnsTrue(string input, bool expected)
        {
            bool result = _sut.IsPalindrome(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("No 'x' in Nixon", true)]
        [InlineData("Red roses run no risk, sir, on Nurse's order.", true)]
        public void IsPalindromeComplexCasesWithPunctuationReturnsTrue(string input, bool expected)
        {
            bool result = _sut.IsPalindrome(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1a2", false)]
        [InlineData("racecar?", true)]
        public void IsPalindromeNonAlphanumericCharactersReturnsExpectedResult(string input, bool expected)
        {
            bool result = _sut.IsPalindrome(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("A man a plan a canal Panama", true)]
        [InlineData("No lemon no melon", true)]
        public void IsPalindromeNoPunctuationOrSpacesReturnsTrue(string input, bool expected)
        {
            bool result = _sut.IsPalindrome(input);
            Assert.Equal(expected, result);
        }
    }
}

