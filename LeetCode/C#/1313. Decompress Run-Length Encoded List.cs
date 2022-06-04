public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        List<int> ans = new List<int>();
        
        for(var i = 0; i < nums.Length - 1; i += 2)
        {
            while(nums[i] != 0)
            {
                ans.Add(nums[i+1]);
                nums[i]--;
            }
        }
        
        return ans.ToArray();
    }
}