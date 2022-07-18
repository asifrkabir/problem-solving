public class Solution {
    public int NumberOfSteps(int num) {
        var count = 0;
        
        if(num != 0)
        {
            while(num != 0)
            {
                if(num % 2 == 0)
                {
                    num = num >> 1;
                }
                else
                {
                    num--;
                }
                
                count++;
            }
        }
        
        return count;
    }
}