public class Solution {
    public int LargestAltitude(int[] gain) {
        var arr = new int[gain.Length +1];
        
        arr[0] = 0;
        
        for(var i = 1; i<arr.Length; i++){
            arr[i] =  gain[i-1] + arr[i -1];
        }
        
        return arr.Max();
    }
}