public class Solution {
    public int AddDigits(int num) {
        if(num == 0)
        {
            return 0;
        }
        
        var digitSum = 0;
        var currentNum = num;
        
        while(true)
        {
            digitSum = 0;
            
            while(currentNum > 0)
            {
                digitSum += currentNum % 10;
                currentNum /= 10;
            }
            
            if(digitSum / 10 == 0)
            {
                return digitSum;
            }
            else
            {
                currentNum = digitSum;
            }
        }
    }
}