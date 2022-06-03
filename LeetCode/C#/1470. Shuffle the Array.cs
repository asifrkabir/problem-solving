public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var ans = new int[nums.Length];
        
        for(int i = 0, j = 0; i < nums.Length; i += 2, j++){
            ans[i] = nums[j];
            ans[i+1] = nums[n+j];
        }
        
        return ans;
    }
}