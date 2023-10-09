public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        var searchRange = new int[2]{-1, -1};
        if(nums.Length == 0)
            return searchRange;
        
        searchRange[0] =  FindIndex(nums, target, true);
        searchRange[1] =  FindIndex(nums, target, false);
        return searchRange;
    }

    public int FindIndex(int[] nums, int target, bool IsStart){
        var result = -1;
        var start = 0;
        var end = nums.Length - 1;
        
        while(start<=end){
            var mid = start + (end - start) / 2;
            if(nums[mid] == target){
                result = mid;
                if(IsStart){
                    end = mid - 1;
                }else{
                    start = mid + 1;
                }
            }else if(nums[mid]< target){
                start = mid + 1;
            }else{
                end = mid - 1;
            }
        }
        
        return result;
    }
}