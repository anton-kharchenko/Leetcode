public class Solution {
    public int Fib(int n) {
        if(n == 0) return 0;
        var dp = new int[n+1];
        dp[0] = 0;
        dp[1] = 1;
        for(var i = 2; i<=n; i++){
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        return dp[n];
    }
}