public class Solution {
    public int CountKDifference(int[] nums, int k) {
        var count = 0;
        
        for(var i = 0; i < nums.Length - 1; i++)
        {
            for(var j = i + 1; j < nums.Length; j++)
            {
                if(Math.Abs(nums[i] - nums[j]) == k) count++;
            }
        }
        
        return count;
    }
}