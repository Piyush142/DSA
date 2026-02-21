function countPrimes(n: number): number {
  let primes = Array(n).fill(1);
  let primeCount = 0;
  let limit = Math.sqrt(n);

  if (n <= 2) {
    return 0;
  }

  primes[0] = 0;
  primes[1] = 0;
  for (let i = 2; i <= limit; i++) {
    if (primes[i] === 1) {
      for (let j = i * i; j < n; j += i) {
        primes[j] = 0;
      }
    }
  }

  primeCount = primes.reduce((acc, ele) => acc + ele, 0);

  return primeCount;
}
