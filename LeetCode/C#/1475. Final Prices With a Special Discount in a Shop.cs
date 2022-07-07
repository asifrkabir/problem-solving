public class Solution {
    public int[] FinalPrices(int[] prices) {
        if(prices.Length <= 1) return prices;
        
        for(var i = 0; i < prices.Length - 1; i++)
        {
            var discount = 0;
            
            for(var j = i + 1;  j < prices.Length; j++)
            {
                if(prices[j] <= prices[i])
                {
                    discount = prices[j];
                    prices[i] -= discount;
                    break;
                }
            }
        }
        
        return prices;
    }
}