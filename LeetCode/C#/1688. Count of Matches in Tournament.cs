public class Solution {
    public int NumberOfMatches(int n) {
        var numOfMatches = 0;
        
        while(n > 1)
        {
            if(n % 2 == 0)
            {
                n >>= 1;
                numOfMatches += n;
            }
            else
            {
                n = (n - 1) / 2;
                numOfMatches += n;
                n++;
            }
        }
        
        return numOfMatches;
    }
}