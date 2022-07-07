public class Solution {
    public int CountNegatives(int[][] grid) {
        var count = 0;
        
        for(var i = grid.Length - 1; i >= 0; i--)
        {
            for(var j = grid[i].Length - 1; j >= 0; j--)
            {
                if(grid[i][j] < 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
        }
        
        return count;
    }
}