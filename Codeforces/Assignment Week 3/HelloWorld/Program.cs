using System;

namespace HelloWorld{
    class Program{
        public static void HelloFunction(int n){
            for(int i = 0; i<n; i++){
                Console.WriteLine("I am learning functions");
            }
        }
        static void Main(){
            var t = int.Parse(Console.ReadLine());
            HelloFunction(t);
        }
    }   
}