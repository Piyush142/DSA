public class Solution {
    public int MaxSubArray(int[] nums) {
        int MaxSum = nums[0];
        int Sum = 0;
        if(nums.Length == 1){
            return nums[0];
        }

        for(int i = 0; i<nums.Length; i++){
            Sum += nums[i];
            MaxSum = Math.Max(Sum, MaxSum); 

            if(Sum<0){
                Sum = 0;
            }
        }

        return MaxSum;
    }
}