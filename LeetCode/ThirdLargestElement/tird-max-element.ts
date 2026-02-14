function thirdMax(nums: number[]): number {
  let firstMax = -Infinity;
  let secondMax = -Infinity;
  let thirdMax = -Infinity;

  for (const num of nums) {
    if (firstMax == num || secondMax == num || thirdMax == num) {
      continue;
    }

    if (firstMax < num) {
      thirdMax = secondMax;
      secondMax = firstMax;
      firstMax = num;
    } else if (secondMax < num) {
      thirdMax = secondMax;
      secondMax = num;
    } else if (thirdMax < num) {
      thirdMax = num;
    }
  }

  if (thirdMax == -Infinity) {
    return firstMax;
  }

  return thirdMax;
}
