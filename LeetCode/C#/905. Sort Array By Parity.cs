public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        if(nums.Length == 0) return nums;
        
        var outputArr = new int[nums.Length];
        var start = 0;
        var end = nums.Length - 1;
        
        foreach(var num in nums)
        {
            if(num % 2 == 0)
            {
                outputArr[start] = num;
                start++;
            }
            else
            {
                outputArr[end] = num;
                end--;
            }
        }
        
        return outputArr;
    }
}