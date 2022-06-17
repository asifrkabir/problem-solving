public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        if(points.Length == 1) return 0;
        
        var time = 0;
        
        for(var i = 1; i < points.Length; i++)
        {
            time += Math.Max(Math.Abs(points[i - 1][0] - points[i][0]), Math.Abs(points[i - 1][1] - points[i][1]));
        }
        
        return time;
    }
}