public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        var dp = new int[target+1];
        dp[0] = 1;
        
        for(var i = 1; i<=target;i++){
            foreach(var num in nums){
                if(i-num>= 0){
                    dp[i] += dp[i-num];
                }
            }
        }
        
        return dp[target];
     }
}