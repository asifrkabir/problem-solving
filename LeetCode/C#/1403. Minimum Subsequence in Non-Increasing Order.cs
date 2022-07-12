public class Solution {
    public IList<int> MinSubsequence(int[] nums) {
        if(nums.Length == 1) return new List<int>(){nums[0]};
        
        nums = nums.OrderByDescending(n => n).ToArray();
        var subSequence = new List<int>();
        
        var totalSum = nums.Sum();
        var subSequenceSum = 0;
        
        for(var i = 0; i < nums.Length; i++)
        {
            if(subSequenceSum > totalSum)
            {
                break;
            }
            else
            {
                subSequence.Add(nums[i]);
                totalSum -= nums[i];
                subSequenceSum += nums[i];
            }
        }
        
        return subSequence;
    }
}