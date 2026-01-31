using System;

namespace PrintFactors2{
    class Program{
        public static string PrintFactors(int n){
            string Factors = "";
            for(int i = n; i>0; i--){
                if(n%i == 0){
                Factors += i.ToString() + " ";
            }

            
         }
         return Factors;
        }
        static void Main(){
            var t = int.Parse(Console.ReadLine());
            var ans = PrintFactors(t);
            Console.WriteLine(ans);
        }
    }
}
