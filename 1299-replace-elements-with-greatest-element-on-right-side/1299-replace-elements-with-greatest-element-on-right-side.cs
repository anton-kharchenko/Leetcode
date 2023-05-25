public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if(arr.Length == 1){
            return new []{-1};
        }
        
        for(var i = 0; i<arr.Length; i++ ){
            arr[i] = FindMax(arr, i+1, arr.Length); 
        }
        arr[^1] = -1;
        return arr;
    }
    
    public int FindMax(int[] arr, int start, int end){
        var max = 0;
        while(start<end){
            if(arr[start] > max){
                max = arr[start];
            }
            
            start++;
        }
        
        return max;
    }
}