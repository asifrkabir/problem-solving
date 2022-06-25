public class Solution {
    public int FindGCD(int[] nums) {
        var max = int.MinValue;
        var min = int.MaxValue;
        var gcd = 0;
        
        for(var i = 0; i < nums.Length; i++)
        {
            if(nums[i] > max)
            {
                max = nums[i];
            }
            
            if(nums[i] < min)
            {
                min = nums[i];
            }
        }
        
        while (max != 0 && min != 0)
        {
            if(max > min)
            {
                max %= min;
            }
            else
            {
                min %= max;
            }
        }
        
        gcd = max | min;
        
        return gcd;
    }
}