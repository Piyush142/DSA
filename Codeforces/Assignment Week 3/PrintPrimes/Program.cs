using System;

namespace PrintPrimes{
    class Program{
        static bool isPrime(int x){
            if(x == 1){
                return false;
            }
            for(int i = 2; i<=x/2; i++){
                if(x%i == 0){
                    return false;
                }
            }
        return true;
        }
        static void Main(){
            int x = int.Parse(Console.ReadLine());
            string ans = "";
            for(int i = 1; i<=x; i++){
                if(isPrime(i)){
                    ans+=i + " ";
                }
            }
            Console.WriteLine(ans);
        }
    }
}