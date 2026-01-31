function removeElement(nums: number[], val: number): number {
  let k = 0;
  nums.forEach((ele: number, i: number) => {
    if (ele != val) {
      nums[k++] = nums[i];
    }
  });
  return k;
}
