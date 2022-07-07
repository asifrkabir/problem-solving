public class Solution {
    public bool DivideArray(int[] nums) {
        var numCount = new Dictionary<int, int>();
        
        foreach(var num in nums)
        {
            if(numCount.ContainsKey(num))
            {
                numCount[num]++;
            }
            else
            {
                numCount.Add(num, 1);
            }
        }
        
        foreach(var count in numCount)
        {
            if(count.Value % 2 != 0)
            {
                return false;
            }
        }
        
        return true;
    }
}