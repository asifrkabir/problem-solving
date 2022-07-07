public class Solution {
    public int RepeatedNTimes(int[] nums) {
        var repeatedNum = 0;
        
        var numCount = new Dictionary<int, int>();
        
        foreach(var num in nums)
        {
            if(numCount.ContainsKey(num))
            {
                repeatedNum = num;
                break;
            }
            else
            {
                numCount.Add(num, 1);
            }
        }
        
        return repeatedNum;
    }
}