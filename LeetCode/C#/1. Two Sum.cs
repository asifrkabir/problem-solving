public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indices = new int[2];
        
        for(var i = 0; i < nums.Length - 1; i++)
        {
            for(var j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    indices[0] = i;
                    indices[1] = j;
                }
            }
        }
        
        return indices;
    }
}