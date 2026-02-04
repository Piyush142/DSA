function validMountainArray(arr: number[]): boolean {
  let l = 0;
  let r = arr.length - 1;
  let k = arr.length - 1;
  if (arr.length < 3) {
    return false;
  }
  while (k > 0) {
    if (l == r) {
      return true;
    }
    if (arr[r] < arr[r - 1]) {
      r--;
    }
    if (arr[l] < arr[l - 1]) {
      l++;
    }
    k--;
  }
  return false;
}
