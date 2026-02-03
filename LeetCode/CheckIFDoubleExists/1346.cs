using System;
namespace CheckIfDoubleExist{
    class Program{

        public static bool CustomBinarySearch(int[] arr, int target, int indEle){
            var l = 0;
            var r = arr.Length - 1; 

            while(l<=r){
                var mid = l + (r-l)/2;
                if(arr[mid] == target){
                    if(target == 0 && mid ==indEle){
                        return false;
                    }
                    return true;
                }
                else if(arr[mid] < target){
                    l = mid + 1;
                }
                else{
                    r = mid - 1;
                }
            }

            return false;
        
        }
        public static bool CheckIfExist(int[] arr) {
            Array.Sort(arr);
            for(int i = 0; i<arr.Length; i++){
                int target = arr[i]*2;
                if(CustomBinarySearch(arr, target)){
                    return true;
                }
            }
            return false;
        }
        static void Main(){

        }
    }
}