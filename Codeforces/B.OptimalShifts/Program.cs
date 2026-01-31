using System;

namespace OptimalShift{
    class Program{

        public static int CountMaxZeros(string st){
            int count = 0;
            int max = 0;
            for(int i = 0; i<st.Length; i++){
                if(int.Parse(st[i].ToString()) == 1){
                    max = count>=max ? count : max;
                    count = 0;
                }
                else{
                    count++;
                }
            }
            return max;
        }
        static void Main(){
            var t = int.Parse(Console.ReadLine());
            for(int i = 0; i<t; i++){
                var len = int.Parse(Console.ReadLine());
                var inputStr = Console.ReadLine();
                inputStr += inputStr;
                var count = CountMaxZeros(inputStr);
                Console.WriteLine(count);
            }

        }
    }
}