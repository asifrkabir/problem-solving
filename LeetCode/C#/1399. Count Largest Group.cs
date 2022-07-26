public class Solution {
    public int CountLargestGroup(int n) {
        var numList = new Dictionary<int, int>();
        var digitSum = 0;
        var currentNum = 0;
        var maxSize = 1;
        var maxCount = 0;
        
        for(var i = 1; i <= n; i++)
        {
            currentNum = i;
            digitSum = 0;
            
            while(currentNum > 0)
            {
                digitSum += currentNum % 10;
                currentNum /= 10;
            }
            
            if(!numList.ContainsKey(digitSum))
            {
                numList.Add(digitSum, 1);
            }
            else
            {
                numList[digitSum]++;
            }
            
            if(numList[digitSum] > maxSize)
            {
                maxSize = numList[digitSum];
            }
        }
        
        foreach(var entry in numList)
        {
            if(entry.Value == maxSize)
            {
                maxCount++;
            }
        }
        
        return maxCount;
    }
}