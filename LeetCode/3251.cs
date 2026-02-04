using System;
namespace MountainArray{
    class Program{
        public bool ValidMountainArray(int[] arr) {
        int k = arr.Length - 1;
        int l = 0;
        int r = k;

        while(k>0){
            if(l==r) return true;
            if(arr[r] < arr[r-1]){
                r--;
            }
            if(arr[l] < arr[l+1]){
                l++;
            }
            k--;
        }

        return false;
    }
        static void Main(){

        }
    }
}