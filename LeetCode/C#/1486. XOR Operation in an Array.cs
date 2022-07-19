public class Solution {
    public int XorOperation(int n, int start) {
        var nums = new int[n];
        var xor = start;
        
        for(var i = 0; i < nums.Length; i++)
        {
            nums[i] = start + i * 2;
            
            if(i > 0)
            {
                xor = xor ^ nums[i];
            }
        }
        
        return xor;
    }
}