public class Solution {
    public int CountPrimes(int n) {
        var Primes = new int[n];
        var PrimeCount = 0;
        Array.Fill(Primes,1);
        int limit = (int)Math.Sqrt(n);

        if(n<=2){
            return 0;
        }

        for(int i = 2; i<=limit; i++){
            if(Primes[i] == 1){
                for(int j = i*i; j<n; j+=i){
                    Primes[j] = 0;
                }
            }
        }

        foreach(int ele in Primes){
            if(ele == 1){
                PrimeCount++;
            }
        }

        return PrimeCount-2;
    }
}