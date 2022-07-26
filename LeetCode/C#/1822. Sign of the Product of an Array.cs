public class Solution {
    public int ArraySign(int[] nums) {
        var neg = false;
        
        foreach(var num in nums)
        {
            if(num == 0)
            {
                return 0;
            }
            else if(num < 0)
            {
                neg = !neg;
            }
        }
        
        if(!neg)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}