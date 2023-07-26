public class Solution {
    public int NumSquares(int n) {
        var dp = new int[n+1];
        
        for(var target = 1; target<n+1; target++){
            dp[target] = target;
            for(var side = 1; side<target+1; side++){
                var square = side* side;
                if(target-square<0 ){
                    break;
                }
                dp[target] = Math.Min(dp[target], 1 + dp[target - square]);
            }
        }
        
        return dp[n];
    }
}