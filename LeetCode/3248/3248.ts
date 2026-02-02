function removeDuplicates(nums: number[]): number {
  let temp = Number.MAX_VALUE;
  let k = 0;
  nums.forEach((num, ind) => {
    if (num != temp) {
      temp = num;
      nums[k++] = nums[ind];
    }
  });

  return k;
}
