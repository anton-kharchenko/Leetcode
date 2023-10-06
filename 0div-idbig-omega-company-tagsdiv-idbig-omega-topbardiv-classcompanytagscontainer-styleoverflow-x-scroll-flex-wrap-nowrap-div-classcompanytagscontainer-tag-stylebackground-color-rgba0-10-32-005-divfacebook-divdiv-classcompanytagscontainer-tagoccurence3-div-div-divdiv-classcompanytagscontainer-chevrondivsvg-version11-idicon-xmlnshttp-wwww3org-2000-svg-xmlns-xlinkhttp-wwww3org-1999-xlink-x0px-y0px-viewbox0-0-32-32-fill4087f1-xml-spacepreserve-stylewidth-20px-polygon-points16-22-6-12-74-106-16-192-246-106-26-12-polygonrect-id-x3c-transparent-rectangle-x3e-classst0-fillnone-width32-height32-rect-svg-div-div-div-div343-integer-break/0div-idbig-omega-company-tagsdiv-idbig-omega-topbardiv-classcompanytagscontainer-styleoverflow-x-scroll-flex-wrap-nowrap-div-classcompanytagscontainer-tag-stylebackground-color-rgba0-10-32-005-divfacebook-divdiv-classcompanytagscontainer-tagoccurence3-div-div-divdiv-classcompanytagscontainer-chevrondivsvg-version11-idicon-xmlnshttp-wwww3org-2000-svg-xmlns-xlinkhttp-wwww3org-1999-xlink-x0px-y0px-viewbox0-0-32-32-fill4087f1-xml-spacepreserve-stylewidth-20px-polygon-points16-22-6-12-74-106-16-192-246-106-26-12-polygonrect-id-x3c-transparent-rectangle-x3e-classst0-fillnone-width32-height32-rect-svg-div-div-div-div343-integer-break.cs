public class Solution {
    public int IntegerBreak(int n) {
        if(n<4) return n - 1;
        int[] dp = new int[n+1];
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 3;
        for(var i = 4;i<=n;i++)
            dp[i] = Math.Max(2*dp[i-2], 3*dp[i-3]);
        return dp[n];
    }
}