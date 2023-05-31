public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        var count = 0;
        for(var i = 0; i<arr.Length; i++){
            for(var j = 0; j<arr.Length; j++){
                for(var k = 0; k<arr.Length; k++){
                bool conditions = 
                    Math.Abs(arr[i] - arr[j]) <= a 
                    && Math.Abs(arr[j] - arr[k]) <= b
                    && Math.Abs(arr[i] - arr[k]) <= c;
                    
                    if(conditions && i<j && j<k){
                       count++; 
                    }
              }
           }
        }
        
        return count;
    }
}