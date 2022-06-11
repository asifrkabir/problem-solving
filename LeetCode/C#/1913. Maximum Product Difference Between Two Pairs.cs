public class Solution {
    public int MaxProductDifference(int[] nums) {
        var maxDifference = 0;
        
        Array.Sort(nums);
        
        maxDifference = (nums[nums.Length - 1] * nums[nums.Length - 2]) - (nums[0] * nums[1]);
        
        return maxDifference;
    }
}