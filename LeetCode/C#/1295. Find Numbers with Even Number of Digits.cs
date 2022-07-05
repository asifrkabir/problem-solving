public class Solution {
    public int FindNumbers(int[] nums) {
        var evenCount = 0;
        
        foreach(var num in nums)
        {
            var digitCount = 0;
            var currentNum = num;
            
            while(currentNum != 0)
            {
                currentNum /= 10;
                digitCount++;
            }
            
            if(digitCount % 2 == 0)
            {
                evenCount++;
            }
        }
        
        return evenCount;
    }
}