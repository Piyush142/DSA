using System;

namespace RemoveDups{
    class Program{
        public static int RemoveDuplicates(int[] nums) {
            let k = 1;
            for(int i = 1; i<nums.Length; i++){
                if(nums[i]!=nums[i-1]){
                    nums[k++] = nums[i];
                }
            }

            return k;
        }
        static void Main(){

        }
    }
}