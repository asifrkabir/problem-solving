public class Solution {
    public int[] RunningSum(int[] nums) {
        var runningSum = new int[nums.Length];
        
        for(var i = 0; i < nums.Length; i++){
            if(i == 0){
                runningSum[i] = nums[0];
            }
            else{
                runningSum[i] = runningSum[i-1] + nums[i];
            }
        }
        
        return runningSum;
    }
}