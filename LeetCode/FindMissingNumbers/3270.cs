// public class Solution {
    
//     public int FindTarget(int[] nums, int target){
//         int left = 0;
//         int right = nums.Length - 1;
        
//         while(left<=right){
//             int mid = left + (right - left)/2;
//             if(nums[mid] == target){
//                 return mid;
//             }
//             else if(nums[mid]<target){
//                 left = mid+1;
//             }
//             else{
//                 right = mid - 1;
//             }
//         }
        
//         return -1;
//     }
//     public IList<int> FindDisappearedNumbers(int[] nums) {
//         IList<int> results = [];
        
//         Array.Sort(nums);
        
//         for(int i = 1; i<=nums.Length; i++){
//             if(FindTarget(nums, i) == -1){
//                 results.Add(i);
//             }
//         }
        
//         return results; 
//     }
// }