public class Solution {
    public int SmallestEqual(int[] nums) {
        var index = -1;
        
        for(var i = 0; i < nums.Length; i++)
        {
            if(i % 10 == nums[i])
            {
                index = i;
                break;
            }
        }
        
        return index;
    }
}