public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(nums1.Length == 1)
        {
            if(nums1[0] == 0)
            {
                nums1[0] = nums2[0];
            }
        }
        else{
            for(int i = m, j = 0; i < nums1.Length; i++, j++)
            {
                nums1[i] = nums2[j];
            }
            
            Array.Sort(nums1);
        }
    }
}