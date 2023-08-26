using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsKatas
{
    //https://leetcode.com/problems/binary-search/
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            return nums.ToList().IndexOf(target);
        }
        public int Search2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }

            }
            return -1;
        }
        public int Search3(int[] nums, int target)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] == target)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public int Search4(int[] nums, int target)
        {
            var index = 0;
            foreach (int number in nums) // 'number' variable to store number from nums
            {
                if (number == target)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
    }
}
