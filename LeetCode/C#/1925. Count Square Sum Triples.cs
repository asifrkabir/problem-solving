public class Solution {
    public int CountTriples(int n) {
        var count = 0;
        var sum = 0;
        var root = 0.0;
        var squareI = 0;
        
        for(var i = 1; i < n; i++)
        {
            squareI = i * i;
            
            for(var j = n - 1; j != i; j--)
            {
                sum = squareI + j * j;
                root = Math.Sqrt(sum);
                
                if(root <= n && root % 1 == 0)
                {
                    count += 2;
                }
            }
        }
        
        return count;
    }
}