public class Solution {
    public int OddCells(int m, int n, int[][] indices) {
        var numOfOdds = 0;
        int[,] matrix = new int[m, n];
        
        foreach(int[] data in indices)
        {
            for(var i = 0; i < n; i++)
            {
                matrix[data[0], i]++;
            }
            
            for(var i = 0; i < m; i++)
            {
                matrix[i, data[1]]++;
            }
        }
        
        for(var i = 0; i < m; i++)
        {
            for(var j = 0; j < n; j++)
            {
                numOfOdds += matrix[i, j] % 2;
            }
        }
        
        return numOfOdds;
    }
}