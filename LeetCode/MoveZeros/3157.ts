function moveZeroes(nums: number[]): void {
  let k = 0;
  if (nums.length > 1) {
    for (let i = 0; i < nums.length; i++) {
      if (nums[i] != 0) {
        if (i == k) {
          nums[k++] = nums[i];
        } else {
          nums[k++] = nums[i];
          nums[i] = 0;
        }
      }
    }
  }
}
