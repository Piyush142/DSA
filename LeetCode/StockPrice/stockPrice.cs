public class Solution {
    public int MaxProfit(int[] prices) {
        var maxGain = 0;
        var minPriceSoFar = prices[0];

        for(int i = 0; i<prices.Length; i++){
            maxGain = maxGain < (prices[i] - minPriceSoFar) ? (prices[i] - minPriceSoFar) : maxGain;
            minPriceSoFar = minPriceSoFar > prices[i] ? prices[i] : minPriceSoFar;
        }

        return maxGain;
    }
}