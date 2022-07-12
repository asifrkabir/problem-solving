public class Solution {
    public int MinCostToMoveChips(int[] position) {
        if(position.Length == 1)
        {
            return 0;
        }
        
        var evenCount = position.Count(n => n % 2 == 0);
        
        return Math.Min(evenCount, position.Length - evenCount);
    }
}