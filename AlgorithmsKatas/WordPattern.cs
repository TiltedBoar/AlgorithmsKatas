namespace AlgorithmsKatas
{
    public class WordPattern
    {
        //https://leetcode.com/problems/word-pattern/
        public bool WordPatternOfChar(string pattern, string s)
        {
            var words = s.Split(" "); //splitting space between words

            if (words.Length != pattern.Length)
            {
                return false;
            }

            Dictionary<char, string> charToWord = new Dictionary<char, string>();//map and track what character is which word
            for (var i = 0; i < words.Length; i++)
            {
                if (!charToWord.ContainsKey(pattern[i]))//checking if the character is already mapped
                {
                    if (charToWord.ContainsValue(words[i])) // checking if dictionary has 's' value, if yes, return false, if not, add it to the dictionary
                        return false;
                    charToWord.Add(pattern[i], words[i]); //add corresponding combination to dictionary
                }
                else
                {
                    if (charToWord[pattern[i]] != words[i])
                        return false;
                }
            }
            return true;
        }
    }
}
