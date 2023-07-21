public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if(arr.Length == 1) return new int[]{-1};
        
        for(var i = 0; i<arr.Length ; i++){
            
            if(i+1<arr.Length){
                 arr[i] = FindMaxGreatest(arr, i+1, arr.Length);
            }
           
        }
        
        arr[^1] = -1;
        return arr;
    }
    
    public int FindMaxGreatest(int[] arr, int startIndex, int endIndex){
        var max = arr[startIndex];
        
        while(startIndex< endIndex){
            var curr = arr[startIndex];
        
            if(curr>max){
                max = curr;
            }
            
            
            startIndex++;
        }
        
        return max;
    }
}