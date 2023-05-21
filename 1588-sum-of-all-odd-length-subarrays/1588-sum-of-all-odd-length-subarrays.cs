public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
     
        var oddNumber = 1;
        var length = arr.Length;
        var sum = 0;
        
        while(oddNumber<=length){
           var curr = 0;
            
            for(var i = 0; i<length; i++){
                curr += arr[i];
                
                if(i >= oddNumber - 1){
                    
                    sum += curr;
                    
                    curr -= arr[ i - oddNumber + 1];
                    
                }
                
            }
            
            oddNumber += 2;
        }
        
        return sum;
    }
}