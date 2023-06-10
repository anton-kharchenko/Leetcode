public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long result = 0, count = 0;
        
        for(var i = 0; i<nums.Length;i++){
            if(nums[i] == 0){
                count += 1;
            }else{
                count = 0;
            }
            
            result += count;
        }
        
        return result;
    }
}