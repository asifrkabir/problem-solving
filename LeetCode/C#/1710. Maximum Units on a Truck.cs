public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        var maxUnits = 0;
        
        Array.Sort(boxTypes, (x, y) => y[1].CompareTo(x[1]));
        
        for(var i = 0; i < boxTypes.Length; i++)
        {
            if(truckSize >= boxTypes[i][0])
            {
                truckSize -= boxTypes[i][0];
                maxUnits += boxTypes[i][0] * boxTypes[i][1];
            }
            else
            {
                maxUnits += truckSize * boxTypes[i][1];
                break;
            }
        }
        
        return maxUnits;
    }
}