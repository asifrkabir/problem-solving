public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> arrList = new List<int>();
        
        for(var i = 0; i < nums1.Length; i++)
        {
            if(nums2.Contains(nums1[i]))
            {
                for(var j = 0; j < nums2.Length; j++)
                {
                    if(nums1[i] == nums2[j])
                    {
                        arrList.Add(nums1[i]);
                        nums2[j] = -1;
                        break;
                    }
                }
            }
        }
        
        return arrList.ToArray();
    }
}