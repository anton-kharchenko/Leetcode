public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        var i = 0;
        while(i+1 < nums.Length && nums[i] == nums[i+1]){
            i += 2;
        }

        return nums[i];
    }
}