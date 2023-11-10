class Solution {
    public int maxProfit(int[] prices) {
        int minPrice = prices[0];
        int finalProfit = 0;

        if (prices.length == 2 && prices[1] > minPrice) {
            return prices[1] - minPrice;
        }

        for (int i = 1; i < prices.length - 1; i++) {
            if (minPrice >= prices[i]) {
                minPrice = prices[i];
            }
            else if (prices[i + 1] < prices[i]) {
                finalProfit += prices[i] - minPrice;
                minPrice = prices[i + 1];
                i++;
            }

            if (i == prices.length - 2 && minPrice < prices[i + 1]) {
                finalProfit += prices[i + 1] - minPrice;
            }
        }

        return finalProfit;
    }
}