public class Solution {
    public int ClimbStairs(int n) {
        var dp = new int[n+1];
        if(n == 1) return 1;
        if(n == 2) return 2;
        dp[1] = 1;
        dp[2] = 2;
        for(var i =3; i<=n;i++ ){
           dp[i] =  dp[i-1] + dp[i -2];
        }
        return dp[n];
    }
}