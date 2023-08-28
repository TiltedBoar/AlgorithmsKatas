namespace AlgorithmsKatas
{
    public class MoveZeroes
    {
        //https://leetcode.com/problems/move-zeroes/
        public void MoveZeroesToEndOfList(int[] nums)
        {
            int count = 0; //tracking index position where is the zero
            for (int i = 0; i < nums.Length; i++) //iterate through array
            {
                if (nums[i] != 0)
                {
                    (nums[count], nums[i]) = (nums[i], nums[count]);
                    //if it is not zero, swap numbers based on the index count,  e.g 0,1,0,3,12, where 'count' is left side, and 'i' is right side
                    //zeroes are tracked by count
                    count++;
                }

            }
        }
    }
}
