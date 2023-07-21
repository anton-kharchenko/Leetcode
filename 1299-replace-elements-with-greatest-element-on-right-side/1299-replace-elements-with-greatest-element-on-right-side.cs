public class Solution {
    public int[] ReplaceElements(int[] arr) {
    if(arr.Length == 1){
        return new int[]{-1};
    }
     for(var i = 0; i<arr.Length; i++){
         if(i+1<arr.Length){
              arr[i] = FindMax(arr, i+1, arr.Length);
         }
        
     }   
       
        arr[^1] = -1;
        return arr;
    }
    
    public int FindMax(int[] arr, int start, int end){
        var max = arr[start];
        
        
        while(start<end){
            var curr = arr[start];
            if(max<curr){
                max = curr;
            }
            
            start++;
        }
        
        
        return max;
    }
}