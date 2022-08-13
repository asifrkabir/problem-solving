public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        var m = grid.Length;
        var n = grid[0].Length;
        var outputGrid = grid.Select(s => s.ToArray()).ToArray();
        
        while(k > 0)
        {
            k--;
            
            for(var i = 0; i < m; i++)
            {
                for(var j = 0; j < n; j++)
                {
                    if(i == m - 1 && j == n - 1)
                    {
                        outputGrid[0][0] = grid[m - 1][n - 1];
                    }
                    else if(j == n - 1)
                    {
                        outputGrid[i + 1][0] = grid[i][n - 1];
                    }
                    else
                    {
                        outputGrid[i][j + 1] = grid[i][j];
                    }
                }
            }
            
            if(k != 0)
            {
                grid = outputGrid.Select(s => s.ToArray()).ToArray();
            }
        }
        
        var outputList = new List<IList<int>>();
        
        for(var i = 0; i < m; i++)
        {
            var list = outputGrid[i].ToList();
            outputList.Add(list);
        }
        
        return outputList;
    }
}