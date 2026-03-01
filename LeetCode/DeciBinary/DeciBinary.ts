function minPartitions(n: string): number {
  let max = -Infinity;

  for (let i = 0; i < n.length; i++) {
    max = max < Number(n[i]) ? Number(n[i]) : max;
  }

  return max;
}
