using System;

namespace IsPrime{
    class Program{

        public static bool PrimeCheck(int n){
            if(n==1){
                return false;
            }

            for(int i = 2; i<=n/2; i++){
                if(n%i == 0){
                    return false;
                }
            }
            return true;            
        }
        static void Main(){
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(PrimeCheck(x) ? "Prime" : "Not Prime");
        }
    }
}