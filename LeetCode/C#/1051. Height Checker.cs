public class Solution {
    public int HeightChecker(int[] heights) {
        if(heights.Length == 1)
        {
            return 0;
        }
        
        var count = 0;
        
        var expected = heights.OrderBy(height => height).ToArray();
        
        for(var i = 0; i < heights.Length; i++)
        {
            if(heights[i] != expected[i])
            {
                count++;
            }
        }
        
        return count;
    }
}