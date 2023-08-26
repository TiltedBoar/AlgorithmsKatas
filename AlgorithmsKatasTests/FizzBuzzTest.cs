using AlgorithmsKatas;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class FizzBuzzTest
    {
        private readonly FizzBuzz _sut;
        public FizzBuzzTest()
        {
            _sut = new FizzBuzz();
        }
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        public void FizzBuzzTests(int n, string expected)
        {
            var result = _sut.FizzBuzzes(n);
            //n-1 because our iteration starts at index 1, not 0
            Assert.Equal(expected, result[n - 1]);
        }
    }
}
