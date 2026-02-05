function sortArrayByParity(nums: number[]): number[] {
  let left = 0;
  let right = nums.length - 1;

  while (left <= right) {
    if (nums[left] % 2 != 0) {
      while (nums[right] % 2 != 0 && right > left) {
        right--;
      }
      //swap
      let temp = nums[left];
      nums[left] = nums[right];
      nums[right] = temp;
    }
    left++;
  }
  return nums;
}
