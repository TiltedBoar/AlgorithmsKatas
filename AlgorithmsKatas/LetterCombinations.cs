using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsKatas
{
    //https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
    public class LetterCombinations
    {
        private Dictionary<char, string> digitToLetters = new Dictionary<char, string>
    {

        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }
    };

        public IList<string> LetterCombination(string digits)
        {
            IList<string> result = new List<string>();
            if (string.IsNullOrWhiteSpace(digits))
                return result;

            void Combinations(int index, string path)
            {
                if (index == digits.Length)
                {
                    result.Add(path);
                    return;
                }

                char digit = digits[index];
                string letters = digitToLetters[digit];
                foreach (char letter in letters)
                {
                    Combinations(index + 1, path + letter);
                }
            }

            Combinations(0, "");
            return result;
        }
    }
}
