public class Solution {
    public int BalancedStringSplit(string s) {
        var balancedCount = 0;
        
        var lCount = 0;
        var rCount = 0;
        
        for(var i = 0; i < s.Length; i++)
        {
            var currentLetter = s[i];
            
            if(currentLetter == 'R')
            {
                rCount++;
            }
            else
            {
                lCount++;
            }
            
            if(lCount == rCount)
            {
                balancedCount++;
            }
        }
        
        return balancedCount;
    }
}