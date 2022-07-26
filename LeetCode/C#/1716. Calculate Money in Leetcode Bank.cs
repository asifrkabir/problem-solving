public class Solution {
    public int TotalMoney(int n) {
        var day = 1;
        var sum = 0;
        var currentSave = 1;
        var week = 1;
        
        while(n > 0)
        {
            sum += currentSave;
            currentSave++;
            day++;
            n--;
            
            if(day == 8)
            {
                day = 1;
                week++;
                currentSave = week;
            }
        }
        
        return sum;
    }
}