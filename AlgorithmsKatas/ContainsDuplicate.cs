namespace AlgorithmsKatas
{
    //https://leetcode.com/problems/contains-duplicate/
    public class ContainsDuplicate
    {
        public bool ContainsDuplicates(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            //List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    return true;
                }
                dictionary[nums[i]] = i; // putting number in the dictionary
            }
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (list.Contains(nums[i]))
            //    {
            //        return true;
            //    }
            //    list.Add(nums[i]);
            //}

            return false;
        }

    }
}
