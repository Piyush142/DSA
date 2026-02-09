public class Solution {
    public int HeightChecker(int[] heights) {
        int[] expectedHeights = new int[heights.Length];
        Array.Copy(heights, expectedHeights, heights.Length);
        Array.Sort(expectedHeights);
        int count = 0;
        
        for(int i = 0; i<heights.Length; i++){
            if(heights[i] != expectedHeights[i]){
                count++;
            }
        }
        
        return count;
    }
}