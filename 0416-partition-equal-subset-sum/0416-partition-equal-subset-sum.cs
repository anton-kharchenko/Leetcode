public class Solution {
    public bool CanPartition(int[] nums) {
        var sum = nums.Sum();
        if(sum%2 != 0){
            return false;
        }
        
        return IsSubset(nums, sum/2);
    }
    
    public bool IsSubset(int[]nums, int target){
        var dp = new bool[target+1];
         dp[0] = true;
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = target; j>=nums[i]; j--){
                    var curr = nums[i];
                  dp[j] = dp[j-curr] || dp[j];
            }
                
              
        
}

        return dp[target];
    }
}