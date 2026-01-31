using System;

namespace CountZeros{
    class Program{

        public static int ZeroCounter(long n){
            int count = 0;
            if(n == 0){
                return 1;
            }
            while(n!=0){
                if(n%10 == 0){
                    count++;
                }
                n/=10;
            }
            return count;
        }
        static void Main(){
            long x = long.Parse(Console.ReadLine());
            Console.WriteLine(ZeroCounter(x));
        }
    }
}
