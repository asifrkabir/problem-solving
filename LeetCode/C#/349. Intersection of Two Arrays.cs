public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var hash1 = new HashSet<int>();
        var hash2 = new HashSet<int>();
        
        foreach(var num in nums1)
        {
            hash1.Add(num);
        }
        
        foreach(var num in nums2)
        {
            hash2.Add(num);
        }
        
        hash1.IntersectWith(hash2);
        
        return hash1.ToArray();
    }
}