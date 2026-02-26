public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var n = nums.Length;
        var newSet = new HashSet<int>();

        for(int i = 0; i<n; i++){
            if(newSet.Contains(nums[i])){
                return true;
            }
            else{
                newSet.Add(nums[i]);
            }
        }

        return false;
    }
}