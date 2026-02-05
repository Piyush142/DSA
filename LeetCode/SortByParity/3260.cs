using System;
namespace ArrayParity{
    class Program{
        public int[] SortArrayByParity(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        while(left<=right){
            if(nums[left]%2 != 0){
                while(nums[right]%2 != 0 && left < right){
                    right--;
                }
                //swap
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
            }
            left++;
        }
        return nums;
        }
        static void Main(){

        }
    }
}