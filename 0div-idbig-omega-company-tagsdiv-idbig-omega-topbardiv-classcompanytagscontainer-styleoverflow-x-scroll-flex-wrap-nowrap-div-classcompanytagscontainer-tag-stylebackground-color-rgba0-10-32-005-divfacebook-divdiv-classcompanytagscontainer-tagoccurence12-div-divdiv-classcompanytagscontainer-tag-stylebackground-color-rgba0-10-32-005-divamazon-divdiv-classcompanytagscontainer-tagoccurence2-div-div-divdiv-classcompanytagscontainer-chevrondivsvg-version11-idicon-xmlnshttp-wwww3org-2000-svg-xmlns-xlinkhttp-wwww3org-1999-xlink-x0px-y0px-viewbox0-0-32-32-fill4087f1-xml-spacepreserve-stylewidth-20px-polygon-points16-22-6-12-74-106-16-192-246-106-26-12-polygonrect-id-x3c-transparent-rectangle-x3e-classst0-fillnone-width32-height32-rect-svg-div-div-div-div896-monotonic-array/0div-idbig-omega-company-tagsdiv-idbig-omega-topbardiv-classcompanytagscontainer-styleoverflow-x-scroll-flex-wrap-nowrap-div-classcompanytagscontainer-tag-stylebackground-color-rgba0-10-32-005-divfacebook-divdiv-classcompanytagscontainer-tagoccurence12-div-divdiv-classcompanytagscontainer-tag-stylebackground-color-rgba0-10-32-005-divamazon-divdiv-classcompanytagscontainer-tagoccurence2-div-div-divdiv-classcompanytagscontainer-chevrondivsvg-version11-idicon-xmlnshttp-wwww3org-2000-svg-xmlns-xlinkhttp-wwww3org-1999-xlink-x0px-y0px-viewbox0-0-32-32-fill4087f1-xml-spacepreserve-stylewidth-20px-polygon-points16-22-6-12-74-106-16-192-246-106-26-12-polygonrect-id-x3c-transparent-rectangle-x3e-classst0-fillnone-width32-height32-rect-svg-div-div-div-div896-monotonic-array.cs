public class Solution {
    public bool IsMonotonic(int[] nums) {
        var dicr = true;
        var incr = true;
        
        for(var i = 0; i<nums.Length - 1; i++){
            if(nums[i] > nums[i+ 1]){
                dicr  = false;
            }
            if(nums[i] < nums[i+ 1]){
                incr  = false;
            }
        }
        
        return dicr  || incr;
    }
}