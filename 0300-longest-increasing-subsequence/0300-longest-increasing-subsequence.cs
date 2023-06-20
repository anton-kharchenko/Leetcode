public class Solution {
    public int LengthOfLIS(int[] nums) {
        var arr = new int[nums.Length];
        
        Array.Fill(arr, 1);
        
        for(var i = nums.Length - 1; i>=0; i--){
            for(var j =i+1; j<nums.Length; j++){
                if(nums[i]<nums[j]){
                    arr[i] = Math.Max(arr[i], 1 + arr[j]);
                }
            }
        }
        
        return arr.Max();
    }
}