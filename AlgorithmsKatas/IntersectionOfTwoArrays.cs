namespace AlgorithmsKatas
{
    public class IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            //https://leetcode.com/problems/intersection-of-two-arrays/
            var intersection = new List<int>();
            for (var i = 0; i < nums1.Length; i++)
            {
                for (var j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])

                        intersection.Add(nums1[i]);
                    // numberIntersection(intersection, nums1[i]);
                }
            }
            return intersection.Distinct().ToArray();
        }

        //add object to the end of the list
        //void numberIntersection(List<int> intersection, int num)
        //{
        //    for (int i = 0; i < intersection.Count; i++)
        //    {
        //        if (num == intersection[i])
        //        {
        //            return;
        //        }
        //    }
        //    intersection.Add(num);
        //}
    }
}
