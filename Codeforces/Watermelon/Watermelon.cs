using System;

namespace Watermelon{
    class Program{
        static void Main(string[] args){
            var weight = int.Parse(Console.ReadLine());
            if(weight % 2 == 0 && weight > 2){
                Console.WriteLine("YES");
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}