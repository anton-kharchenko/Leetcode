public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var length = nums.Length;
        
        var arr = new int[length];
        var left = new int[length];
        var right = new int[length];
        
        Array.Fill(left, 1);
        Array.Fill(right, 1);
        
        for(var i = 1; i<length; i++){
            left[i] = left[i-1] * nums[i-1]; // Count left part 
        }
        
        for(var i = length - 2; i>=0; i--){
            right[i] = right[i+1] * nums[i+1]; // Count right part 
        }
        
        for(var i = 0; i<length; i++){
            arr[i] = left[i] * right[i]; // Multiply it 
        }
        
        return arr;
    }
}