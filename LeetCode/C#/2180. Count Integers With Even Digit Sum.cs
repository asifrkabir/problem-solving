public class Solution {
    public int CountEven(int num) {
        var count = 0;
        var digitSum = 0;
        var currentNum = 0;
        
        for(var i = 1; i <= num; i++)
        {
            currentNum = i;
            digitSum = 0;
            
            while(currentNum > 0)
            {
                digitSum += currentNum % 10;
                currentNum /= 10;
            }
            
            if(digitSum % 2 == 0)
            {
                count++;
            }
        }
        
        return count;
    }
}