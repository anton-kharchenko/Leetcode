public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var ans = new int[nums.Length];
        var left = new int[nums.Length];
        var right =  new int[nums.Length];
        
        Array.Fill(left, 1);
        Array.Fill(right, 1);
        
        for(var i = 1; i<nums.Length; i++){
            left[i] = left[i-1] * nums[i-1];
        }
        
        for(var i = nums.Length -2; i>=0; i--){
            right[i] = right[i+1] * nums[i+1];
        }
        
        for(var i = 0; i<nums.Length; i++){
            ans[i] = left[i] * right[i];
        }
        
        return ans;
    }
}