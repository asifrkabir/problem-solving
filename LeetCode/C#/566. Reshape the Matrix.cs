public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        if(mat.Length * mat[0].Length != r * c)
        {
            return mat;
        }
        else{
            int[][] ans = new int[r][];
            int a = 0, b = 0;
            
            for(var i = 0; i < r; i++)
            {
                int[] arr = new int[c];
                
                for(var j = 0; j < c; j++)
                {
                    arr[j] = mat[a][b];
                    b++;
                    if(b == mat[0].Length)
                    {
                        b = 0;
                        a++;
                    }
                }
                
                ans[i] = arr;
            }
            
            return ans;
        }
    }
}