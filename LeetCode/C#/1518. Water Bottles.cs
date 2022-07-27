public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        var drankBottles = 0;
        var emptyBottles = 0;
        var fullBottles = numBottles;
        
        while(numBottles >= numExchange)
        {
            drankBottles += fullBottles;
            emptyBottles = numBottles % numExchange;
            fullBottles = numBottles / numExchange;
            numBottles = emptyBottles + fullBottles;
        }
        
        return drankBottles + fullBottles;
    }
}