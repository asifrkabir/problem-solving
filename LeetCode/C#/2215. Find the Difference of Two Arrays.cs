public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var answer = new List<IList<int>>();
        var list1 = new List<int>();
        var list2 = new List<int>();
        
        foreach(var num in nums1)
        {
            if(!nums2.Contains(num) && !list1.Contains(num))
            {
                list1.Add(num);
            }
        }
        
        answer.Add(list1);
        
        foreach(var num in nums2)
        {
            if(!nums1.Contains(num) && !list2.Contains(num))
            {
                list2.Add(num);
            }
        }
        
        answer.Add(list2);
        
        return answer;
    }
}