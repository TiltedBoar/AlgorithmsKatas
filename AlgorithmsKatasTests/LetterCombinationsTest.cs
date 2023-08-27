using AlgorithmsKatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmsKatasTests
{
    public class LetterCombinationsTest
    {
        private readonly LetterCombinations _sut;
        public LetterCombinationsTest()
        {
            _sut = new LetterCombinations();
        }
        [Fact]
        public void LetterCombinationsOfPNTests()
        {
            var result1 = _sut.LetterCombination("23");
            var result2 = _sut.LetterCombination("");
            var result3 = _sut.LetterCombination("2");
            List<string> expected1 = new List<string>
            {
                "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"
            };
            List<string> expected2 = new List<string>();
            List<string> expected3 = new List<string> { "a", "b", "c" };
            Assert.Equal(expected1, result1);
            Assert.Equal(expected2, result2);
            Assert.Equal(expected3, result3);
        }
    }
}
