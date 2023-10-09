public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] ints = new int[2] { -1, -1 };

        var l = 0;
        var r = nums.Length - 1;
        
        while(l<=r){
            if(nums[l]== target && nums[r]==target){
                return new int[2]{l, r};
            }
            if(nums[l]<target){
               l++;  
            }
           if(nums[r]>target){
             r--;  
           } 
        }
        

        return ints;

    }
}