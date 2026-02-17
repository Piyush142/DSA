// function findTarget(nums: number[], target: number): number {
//   let left = 0;
//   let right = nums.length - 1;

//   while (left <= right) {
//     const mid = left + (right - left) / 2;
//     if (nums[mid] === target) {
//       return mid;
//     } else if (nums[mid] > target) {
//       right = mid - 1;
//     } else {
//       left = mid + 1;
//     }
//   }

//   return -1;
// }

// function findDisappearedNumbers(nums: number[]): number[] {
//   nums.sort((a, b) => a - b);
//   let results: number[] = [];

//   for (let i = 1; i <= nums.length; i++) {
//     if (findTarget(nums, i) === -1) {
//       results.push(i);
//     }
//   }

//   return results;
// }

function findDisappearedNumbers(nums: number[]): number[] {
  let n = nums.length;
  let i = 0;
  let ans: number[] = [];

  while (i < n) {
    if (nums[i] === i + 1 || nums[nums[i] - 1] === nums[i]) {
      i++;
    } else {
      let temp = nums[nums[i] - 1];
      nums[nums[i] - 1] = nums[i];
      nums[i] = temp;
    }
  }

  for (let i = 0; i < nums.length; i++) {
    if (nums[i] !== i + 1) ans.push(i + 1);
  }

  return ans;
}
