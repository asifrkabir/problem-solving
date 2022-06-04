public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var ans = new int[nums.Length];
        
        for(var i = 0; i < nums.Length; i++)
        {
            for(var j = 0; j < nums.Length; j++)
            {
                if(j != i)
                {
                    if(nums[j] < nums[i])
                    {
                        ans[i]++;
                    }
                }
            }
        }
        
        return ans;
    }
}