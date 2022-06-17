public class Solution {
    public int LargestAltitude(int[] gain) {
        var maxAltitude = 0;
        var currentSum = 0;
        
        foreach(var num in gain)
        {
            currentSum += num;
            maxAltitude = Math.Max(maxAltitude, currentSum);
        }
        
        return maxAltitude;
    }
}