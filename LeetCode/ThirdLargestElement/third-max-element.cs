using System;
namespace ThirdGreatestEle{

public class Program {
    public int ThirdMax(int[] nums) {
        long firstMax = long.MinValue;
        long secondMax = long.MinValue;
        long thirdMax = long.MinValue;

        foreach(long num in nums){
            if(firstMax == num || secondMax == num || thirdMax == num){
                continue;
            }
            if(firstMax <= num){
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = num;
            }
            else if(secondMax <= num){
                thirdMax = secondMax;
                secondMax = num;
            }
            else if(thirdMax <= num){
                thirdMax = num;
            }
        }

        if(thirdMax == long.MinValue){
            return (int)firstMax;
        }

        return (int)thirdMax;
    }
}

static void Main(){
    
}
}