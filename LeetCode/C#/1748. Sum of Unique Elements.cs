public class Solution {
    public int SumOfUnique(int[] nums) {
        var sum = 0;
        
        var numCount = new Dictionary<int, int>();
        
        foreach(var num in nums)
        {
            if(numCount.ContainsKey(num))
            {
                if(numCount[num] == 1)
                {
                    sum -= num;
                    numCount[num]++;
                }
            }
            else
            {
                numCount.Add(num, 1);
                sum += num;
            }
        }
        
        return sum;
    }
}