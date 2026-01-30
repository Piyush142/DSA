// First Attempt: O(n^2) time complexity, O(1) space complexity

function duplicateZeros(arr: number[]): void {  
    for(let i = 0; i<arr.length; i++){
        if(arr[i] === 0){
            //shift
            for(let j = arr.length - 1; j>i; j--){
                arr[j]=arr[j-1];
            }
            i++;
        }
    }
};

