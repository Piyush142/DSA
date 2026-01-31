using System;

namespace Factorial{
    class Program{

        public static long FactorialCalc(int n){
            if(n==0){
                return 1;
            }
            long ans = 1;
            for(int i = 1; i<=n ; i++){
                ans*=i;
            }
            return ans;
        }
        static void Main(){
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialCalc(x));
        }
    }
}