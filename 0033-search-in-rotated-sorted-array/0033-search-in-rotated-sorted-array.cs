public class Solution {
    public int Search(int[] nums, int target) {
        var left = 0;
        var right = nums.Length - 1;
        
        while(left<= right){
            if(nums[left] == target) return left;
            if(nums[right] == target) return right;
            left++;
            right--;
        }
        
        return -1;
    }
}