function twoSum(nums: number[], target: number): number[] {
  let map = {};
  for (let i = 0; i < nums.length; i++) {
    map[nums[i]] = i;
  }

  for (let i = 0; i < nums.length; i++) {
    let compliment = target - nums[i];
    if (map[compliment] !== undefined && map[compliment] !== i) {
      return [i, Number(map[compliment])];
    }
  }

  return [0, 0];
}
