function replaceElements(arr: number[]): number[] {
  let len = arr.length - 1;
  let greatest = arr[len];
  arr[len] = -1;
  for (let i = len - 1; i >= 0; i--) {
    let temp = greatest;
    if (arr[i] > greatest) {
      greatest = arr[i];
    }
    arr[i] = temp;
  }

  return arr;
}
