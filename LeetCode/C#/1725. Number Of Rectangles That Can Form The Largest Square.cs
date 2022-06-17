public class Solution {
    public int CountGoodRectangles(int[][] rectangles) {
        var maxLen = 0;
        
        for(var i = 0; i < rectangles.Length; i++)
        {
            
            maxLen = Math.Max(maxLen, Math.Min(rectangles[i][0], rectangles[i][1]));
        }
        
        var count = rectangles.Where(lengths => maxLen == Math.Min(lengths[0], lengths[1])).Count();
        
        return count;
    }
}