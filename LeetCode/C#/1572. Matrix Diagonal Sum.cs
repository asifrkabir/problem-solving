public class Solution {
    public int DiagonalSum(int[][] mat) {
        
        if(mat[0].Length == 1) return mat[0][0];
        
        var sum = 0;
        
        for(int i = 0, j = 0, k = mat[0].Length - 1; i < mat[0].Length; i++, j++, k--)
        {
            sum += mat[i][j];
            
            if(mat[0].Length % 2 == 1 && i == (mat[0].Length - 1) / 2)
            {
                continue;
            }
            
            sum += mat[i][k];
        }
        
        return sum;
    }
}