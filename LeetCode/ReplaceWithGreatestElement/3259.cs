using System;
namespace ReplaceWithGreEle{
    class Program{
    public int[] ReplaceElements(int[] arr) {
       int len = arr.Length; 
       int maxValRight = arr[len-1];
       arr[len-1] = -1;
       
        for(int i= len-2; i>=0; i--){
            int temp = maxValRight;
            if(arr[i]>maxValRight){
                maxValRight = arr[i];
            }
            arr[i] = temp;
        }
        return arr;
    }
        static void Main(){

        }
    }
}