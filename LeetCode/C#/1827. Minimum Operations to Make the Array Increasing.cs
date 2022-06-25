public class Solution {
    public int MinOperations(int[] nums) {
        if(nums.Length <= 1) return 0;
        
        var numOfOperations = 0;
        
        for(var i = 1; i < nums.Length; i++)
        {
            if(nums[i] > nums[i - 1]) continue;
            else
            {
                var incrementAmount = nums[i - 1] + 1 - nums[i];
                numOfOperations += incrementAmount;
                nums[i] += incrementAmount;
            }
        }
        
        return numOfOperations;
    }
}