using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsKatas
{
    //https://leetcode.com/problems/valid-palindrome/description/
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            char[] original = s.ToLower().Trim().Where(Char.IsLetterOrDigit).ToArray();
            var reverse = string.Join("", original.Reverse());
            bool isEqual = original.SequenceEqual(reverse);
            if (isEqual)
            {
                return true;
            }
            return false;
        }
    }
}
