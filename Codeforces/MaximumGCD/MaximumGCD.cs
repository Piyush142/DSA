using System;

namespace MaximumGCD{
    class Program{

        static void Main(string[] args){
            var n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++){
                var a = int.Parse(Console.ReadLine());
                Console.WriteLine(a/2);
            }
        }
    }
}
