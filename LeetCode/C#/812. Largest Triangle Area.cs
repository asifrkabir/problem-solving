public class Solution {
    public double LargestTriangleArea(int[][] points) {        
        var x1 = 0;
        var y1 = 0;
        var x2 = 0;
        var y2 = 0;
        var x3 = 0;
        var y3 = 0;
        var maxArea = 0.0;
        var area = 0.0;
        
        for(var i = 0; i < points.Length - 2; i++)
        {
            x1 = points[i][0];
            y1 = points[i][1];
            
            for(var j = i + 1; j < points.Length - 1; j++)
            {
                x2 = points[j][0];
                y2 = points[j][1];
                
                for(var k = j + 1; k < points.Length; k++)
                {
                    x3 = points[k][0];
                    y3 = points[k][1];
                    
                    area = Math.Abs(x1 * (y2 - y3)
                                    + x2 * (y3 - y1)
                                    + x3 * (y1 - y2));
                    
                    if(area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
        }
        
        return maxArea / 2;
    }
}