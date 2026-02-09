function heightChecker(heights: number[]): number {
  let expectedHeights = [...heights].sort((a, b) => a - b);
  let unmatched = 0;
  for (let i = 0; i < heights.length; i++) {
    if (heights[i] !== expectedHeights[i]) {
      unmatched++;
    }
  }

  return unmatched;
}
