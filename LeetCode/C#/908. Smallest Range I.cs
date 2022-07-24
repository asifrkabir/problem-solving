public class Solution {
    public int SmallestRangeI(int[] nums, int k) {
        if(nums.Length == 1)
        {
            return 0;
        }
        
        var max = nums.Max();
        var min = nums.Min();
        var diff = max - min;
        
        if(k == 0)
        {
            return diff;
        }
        
        if((diff) / 2 >= k)
        {
            return (diff) - k * 2;
        }
        else
        {
            return 0;
        }
    }
}