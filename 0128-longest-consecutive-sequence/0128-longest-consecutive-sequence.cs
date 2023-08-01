public class Solution {
    public int LongestConsecutive(int[] nums) {
    if(nums.Length == 0) return 0;
    if(nums.Length == 1) return 1;
			
    Array.Sort(nums);
        
    var count = 0;
    var maxCount = 0;
        
    for(var i = 0; i < nums.Length -1; i++){
        
        if(nums[i+1] - nums[i] == 1){
            count++;
        }

        if (maxCount < count)
        {
            maxCount = count;
        }
        
        if (nums[i+1] - nums[i] > 1)
        {
            count = 0;
        }
    }
		
    return maxCount + 1;
    }
}