class Solution {
    public int maxProfit(int[] prices) {
        int minPrice = prices[0];
        int maxProfit = 0;
        int currentDiff = 0;

        for(int i = 1; i < prices.length; i++) {
            if(prices[i] < minPrice) {
                minPrice = prices[i];
            }
            else if(maxProfit < (currentDiff = prices[i] - minPrice)) {
                maxProfit = currentDiff;
            }
        }

        return maxProfit;
    }
}