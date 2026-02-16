function findTarget(nums: number[], target: number): number {
  let left = 0;
  let right = nums.length - 1;

  while (left <= right) {
    const mid = left + (right - left) / 2;
    if (nums[mid] === target) {
      return mid;
    } else if (nums[mid] > target) {
      right = mid - 1;
    } else {
      left = mid + 1;
    }
  }

  return -1;
}

function findDisappearedNumbers(nums: number[]): number[] {
  nums.sort((a, b) => a - b);
  let results: number[] = [];

  for (let i = 1; i <= nums.length; i++) {
    if (findTarget(nums, i) === -1) {
      results.push(i);
    }
  }

  return results;
}
