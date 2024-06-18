public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        var start = 0;
        var end = 0;
        var count = 0;
        var sum = 0;
        var prefix = 0;

        while(end < nums.Length){
            sum += nums[end];

            while(start < end &&( sum > goal || nums[start] == 0)){
                if(nums[start] == 0){
                    prefix += 1;
                }else{
                    prefix = 0;
                }
                
                var toDelete = nums[start];
                sum -= toDelete;
                start += 1;
            }

            if(sum == goal){
                count += 1 + prefix;
            }

            end += 1;
        }
        return count;
    }
}