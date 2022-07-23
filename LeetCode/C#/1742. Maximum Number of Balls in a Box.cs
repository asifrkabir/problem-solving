public class Solution {
    public int CountBalls(int lowLimit, int highLimit) {
        var countList = new Dictionary<int, int>();
        var currentNum = 0;
        var sum = 0;
        var maxBalls = 0;
        
        for(var i = lowLimit; i <= highLimit; i++)
        {
            sum = 0;
            currentNum = i;
            
            while(currentNum > 0)
            {
                sum += currentNum % 10;
                currentNum /= 10;
            }
            
            if(!countList.ContainsKey(sum))
            {
                countList.Add(sum, 1);
            }
            else
            {
                countList[sum]++;
            }
            
            if(maxBalls < countList[sum])
            {
                maxBalls = countList[sum];
            }
        }
        
        return maxBalls;
    }
}