public class Solution {
    public int[] SearchRange(int[] nums, int target) {
       var searchRange = new int[2]{-1, -1};
       if(nums.Length == 0)
            return searchRange;
       searchRange[0] = FindIndex(nums, target, true);
       searchRange[1] = FindIndex(nums, target, false); 
       return searchRange; 
    }
    
    public int FindIndex(int[] nums, int target, bool isStart){
        int start = 0; 
        int end = nums.Length - 1; 
        int result = -1;
        
        while(start <= end)
        {
            int mid = start + (end - start) / 2;
            
            if(nums[mid] == target)
            {
                result = mid;
                if(isStart){
                    end = mid - 1;
                }else{
                    start = mid + 1;
                }
            }
            else if(nums[mid] < target)
                start = mid + 1;
            else
                end = mid - 1;
        }
        
        return result;
    }
    
}