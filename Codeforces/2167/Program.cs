using System;
// Incorrect Solution
namespace YetAnotherArray{
    class Program{
        static long GCD(long a, long b){
            if(b==0) return a;
            return(GCD(b, a%b));
        }

        static long FindMin(int[] nums){
            long min = long.MaxValue;
            for(int i = 0; i<nums.Length; i++){
                if(nums[i] < min){
                    min = nums[i];
                }
            }
            return min;
        }
        static void Main(){
            var t = int.Parse(Console.ReadLine());
            for(int i = 0; i<t; i++){
                var len = int.Parse(Console.ReadLine());
                int[] arr =   Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();

                
                int ans = 2;
                long x = FindMin(arr);

                while(GCD(ans, x) != 1){
                    ans++;
                }
                Console.WriteLine(ans);
                }
            }
        }
    }