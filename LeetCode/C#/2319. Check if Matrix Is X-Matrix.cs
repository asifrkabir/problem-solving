public class Solution
{
    public bool CheckXMatrix(int[][] grid)
    {
        var start = 0;
        var end = grid.Length - 1;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (j == start || j == end)
                {
                    if (grid[i][j] == 0)
                    {
                        return false;
                    }
                }
                else
                {
                    if (grid[i][j] != 0)
                    {
                        return false;
                    }
                }
            }

            start++;
            end--;
        }

        return true;
    }
}