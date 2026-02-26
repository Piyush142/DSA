function maxProfit(prices: number[]): number {
  let maxGain = 0;
  let minPrice = prices[0];
  let n = prices.length;

  for (let i = 0; i < n; i++) {
    maxGain = maxGain < prices[i] - minPrice ? prices[i] - minPrice : maxGain;
    minPrice = minPrice > prices[i] ? prices[i] : minPrice;
  }

  return maxGain;
}
