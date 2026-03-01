public class Solution {
    public int MinPartitions(string n) {
        var max = -1;

        for(int i = 0; i<n.Length; i++){
            max = max < (int)char.GetNumericValue(n[i]) ? (int)char.GetNumericValue(n[i]) : max;
        }

        return max;
    }
}