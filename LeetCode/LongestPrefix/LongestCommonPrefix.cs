public class Solution {
    public string LongestCommonPrefix(string[] strs) {

       var len = strs.Length;
       if(len<2){
        return strs[0];
       }
       var str1 = strs[0];
       var str2 = strs[1];
       var lngPrefix = "";
       var shortString = str1.Length<str2.Length ? str1 : str2;
       
       for(int i = 0; i<shortString.Length; i++){
        if(str1[i] == str2[i]){
            lngPrefix += str1[i];
        }
        else{
            break;
        }
       }

       if(lngPrefix!="" && len>2){
        for(int i = 2; i<len; i++){
                var strToCheck = strs[i];
                int limit = Math.Min(lngPrefix.Length, strToCheck.Length);

                int j = 0;
                while (j < limit && strToCheck[j] == lngPrefix[j]) {
                j++;
                }

                lngPrefix = lngPrefix.Substring(0, j);
                if (lngPrefix == "") break;

            }
        }

       return lngPrefix;
    }
}