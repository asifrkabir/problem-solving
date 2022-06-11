public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        for(var i = 0; i < image.Length; i++)
        {
            Array.Reverse(image[i]);
            
            for(var j = 0; j < image[0].Length; j++)
            {
                if(image[i][j] == 0) image[i][j] = 1;
                else image[i][j] = 0;
            }
        }
        
        return image;
    }
}