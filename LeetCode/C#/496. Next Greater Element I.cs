public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var ans = new int[nums1.Length];
        
        for(var i = 0; i < nums1.Length; i++)
        {
            var greaterElement = -1;
            var found = false;
            
            for(var j = 0; j < nums2.Length - 1; j++)
            {
                if(found)
                {
                    break;
                }
                
                if(nums1[i] == nums2[j])
                {
                    for(var l = j + 1; l < nums2.Length; l++)
                    {
                        if(nums2[l] > nums2[j])
                        {
                            greaterElement = nums2[l];
                            break;
                        }
                    }
                }
            }
            
            ans[i] = greaterElement;
        }
        
        return ans;
    }
}