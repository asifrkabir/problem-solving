public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var count = 0;
        
        foreach(var stone in stones)
        {
            if(jewels.Contains(stone)) count++;
        }
        
        return count;
    }
}