function maxSubArray(nums: number[]): number {
  let maxi = Number.NEGATIVE_INFINITY;
  let sum = 0;

  if (nums.length < 2) {
    return nums[0];
  }

  for (let i = 0; i < nums.length; i++) {
    sum += nums[i];
    if (sum > maxi) {
      maxi = sum;
    }
    if (sum < 0) {
      sum = 0;
    }
  }

  return maxi;
}
