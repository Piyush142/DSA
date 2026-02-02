function checkIfExist(arr: number[]): boolean {
  arr = arr.sort((a, b) => a - b);

  for (let ele of arr) {
    let l = 0;
    let r = arr.length - 1;
    let target = ele * 2;
    while (l <= r) {
      let mid = Math.floor(l + (r - l) / 2);

      if (arr[mid] === target) {
        if (ele !== 0) return true;
        if (arr[mid - 1] === 0 || arr[mid + 1] === 0) return true;
        break;
      } else if (arr[mid] < target) {
        l = mid + 1;
      } else {
        r = mid - 1;
      }
    }
  }

  return false;
}
