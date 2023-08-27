namespace AlgorithmsKatas
{
    //https://leetcode.com/problems/is-subsequence/description/
    public class IsSubsequence
    {
        //https://leetcode.com/problems/is-subsequence/
        public bool IsSubsequence1(string s, string t)
        {
            ////pointers
            //int i = 0;
            //int j = 0;

            ////compares the character at positions i-s, j-t, if found, increment
            //while (i < s.Length && j < t.Length)
            //{
            //    if (s[i] == t[j])
            //    {
            //        i++; //increment if there is a match
            //    }

            //    j++; // 
            //}

            //return i == s.Length;


            int i = 0;
            for (int j = 0; j < t.Length && i < s.Length; j++)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
            }

            return i == s.Length;
        }
    }
}


