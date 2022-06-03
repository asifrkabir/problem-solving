public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        for(var i = 0; i < nums.Length - 1; i++)
        {
            for(var j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        
        return false;
    }
}