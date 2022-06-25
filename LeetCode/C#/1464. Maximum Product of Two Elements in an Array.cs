public class Solution {
    public int MaxProduct(int[] nums) {
        
        var max = 0;
        var secondMax = 0;
        
        for(var i = 0; i < nums.Length; i++)
        {
            if(nums[i] > max)
            {
                secondMax = max;
                max = nums[i];
            }
            
            else if(nums[i] > secondMax)
            {
                secondMax = nums[i];
            }                
        }
        
        return (max - 1) * (secondMax - 1);
    }
}