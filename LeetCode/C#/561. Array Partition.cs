public class Solution {
    public int ArrayPairSum(int[] nums) {
        var maxSum = 0;
        
        Array.Sort(nums);
        
        for(var i = 0; i < nums.Length; i += 2)
        {
            maxSum += nums[i];
        }
        
        return maxSum;
    }
}