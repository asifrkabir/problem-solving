public class Solution {
    public int MaxSubArray(int[] nums) {
        var max = int.MinValue; 
        var currentMax = 0;
        
        for(var i = 0; i < nums.Length; i++)
        {
            currentMax += nums[i];
            
            max = max < currentMax ? currentMax : max;
            
            currentMax = currentMax < 0 ? 0 : currentMax;
        }
        
        return max;
    }
}