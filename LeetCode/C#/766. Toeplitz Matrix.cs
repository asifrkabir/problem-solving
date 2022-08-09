public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
        if(matrix.Length == 1)
        {
            return true;
        }
        
        for(var i = 1; i < matrix.Length; i++)
        {
            for(var j = 1; j < matrix[i].Length; j++)
            {
                if(matrix[i][j] != matrix[i - 1][j - 1])
                {
                    return false;
                }
            }
        }
        
        return true;
    }
}