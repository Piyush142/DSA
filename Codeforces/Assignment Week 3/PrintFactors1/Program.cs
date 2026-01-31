using System;

namespace PrintFactors1{
    class Program{
        public static void PrintFactors(int n){
            string factors = "";
            for(int i = 1; i<=n; i++){
                if(n%i == 0){
                factors += i.ToString() + " ";
                }
            }
            Console.WriteLine(factors);
        }

        static void Main(){
        var t = int.Parse(Console.ReadLine());
        PrintFactors(t);
        }
    }
}
