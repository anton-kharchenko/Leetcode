public class Solution {
    public int DominantIndex(int[] nums) {
        var maxValue = nums.Max();
        var index = 0;
        var isMax = true;
        
        for(var i = 0; i<nums.Length; i++){
            if(nums[i] == maxValue) {
                index = i;
                continue;
            }
            if(nums[i] == 0 )
                continue;
            if(maxValue / nums[i] < 2){
                isMax = false;
            }
        }
        
        
        return isMax == true ? index : -1;
    }
}