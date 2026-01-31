using System;

namespace RemoveElements{
    class Program{

        // public static void RemoveEleFromInd(int[] nums,int ind){
        //     for(int i = ind+1; i<nums.Length; i++){
        //         nums[i-1] = nums[i];
        //     }
        // }
        // public static int RemoveElement(int[] nums, int val) {
        //     int len = nums.Length;
        //     for(int i = 0; i<len; i++){
        //         if(nums[i] == val){
        //             RemoveEleFromInd(nums, i);
        //             len--;
        //             i--;
        //         }  
        //     }
        //     return len;
        // }


        //Better Solution

        public int RemoveElement(int[] nums, int val) {
            int ind = 0;
            for(int i = 0; i<nums.Length; i++){
                if(nums[i] != val){
                    nums[ind++] = nums[i];
                }
            }
            return ind;
        }

        static void Main(){
            
        }
    }
}