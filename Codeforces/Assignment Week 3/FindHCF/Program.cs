using System;

namespace FindHCF{
    class Program{

        public static int HCF(int a, int b){
           return b == 0 ? a : HCF(b, a % b);
        }
        static void Main(){
            int[] x = Console.ReadLine()
                             .Split(' ')
                             .Select(int.Parse)
                             .ToArray();

            int ans = HCF(x[0], x[1]);
            Console.WriteLine(ans);
        }
    }
}