public class Solution {
    public int PivotIndex(int[] nums) {
        var left = 0;
        var right = nums.Skip(1).Sum();
        
        if(left == right){
            return 0;
        }
        
        for(var i = 1; i<nums.Length; i++){
            left += nums[i-1];
            right -= nums[i];
            if(left == right){
                return i;
            }
        }
        
        return -1;
    }
}