public class Solution {
    public int FindDuplicate(int[] nums) {
      var slow = nums[0];
      var fast = nums[0];
        
        while(true){
            slow = nums[slow];
            fast = nums[nums[fast]];
            if(slow == fast){
                break;
            }
        }
        
        slow = nums[0];
        while(fast != slow ){
            slow = nums[slow];
            fast = nums[fast];
        }
        
      return fast;
    }
}