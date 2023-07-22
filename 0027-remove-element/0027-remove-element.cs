public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var index = 0;
        
        for(var i = 0; i<nums.Length; i++){
            if(nums[i] != val){
                nums[index] = nums[i];
                index++;
            }
        }
        
        return index;
    }
}