public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        var arr = new int[num_people];
        var currentCandy = 1;
        var candyLeft = true;
        
        while(candyLeft)
        {
            for(var i = 0; i < num_people; i++)
            {
                
                if(currentCandy <= candies)
                {
                    arr[i] += currentCandy;
                    candies -= currentCandy;
                    currentCandy++;
                }
                else
                {
                    arr[i] += candies;
                    candyLeft = false;
                    break;
                }
            }
        }
        
        return arr;
    }
}