using System;

namespace nCr{
    class Program{

        static long Factorial(int n){
            long ans = 1;
            if(n == 0 || n == 1){
                return 1;
            }

            for(int i = 2; i<=n; i++){
                ans*=i;
            }

            return ans;
        } 

        static long NCR(int n, int r){
            return Factorial(n)/(Factorial(r)*Factorial(n-r));
        }
        static void Main(){
            int[] x = Console.ReadLine().Split(' ')
                             .Select(int.Parse)
                             .ToArray();

            Console.WriteLine(NCR(x[0],x[1]));
        }
    }
}