public class Solution {
    public int MaxProfit(int[] prices) {
        var purchasePrice = prices[0];
        var profit = 0;
        
        for(var i = 1; i < prices.Length; i++)
        {
            if(prices[i] < purchasePrice)
            {
                purchasePrice = prices[i];
            }
            else if(prices[i] - purchasePrice > profit)
            {
                profit = prices[i] - purchasePrice;
            }
        }
        
        return profit;
    }
}