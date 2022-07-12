public class Solution {
    public int[] SortedSquares(int[] nums) {
        var start = 0;
        var end = nums.Length - 1;
        var arr = new int[nums.Length];
        
        for(var i = arr.Length - 1; i >= 0; i--)
        {
            if(Math.Abs(nums[start]) > Math.Abs(nums[end]))
            {
                arr[i] = nums[start] * nums[start];
                start++;
            }
            else
            {
                arr[i] = nums[end] * nums[end];
                end--;
            }
            
            if(start > end)
            {
                break;
            }
        }
        
        return arr;
    }
}