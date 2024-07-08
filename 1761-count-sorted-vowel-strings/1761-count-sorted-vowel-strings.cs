public class Solution {
    public int CountVowelStrings(int n) {
        var dp = new int[n, 5];

        for (int i = 0; i < 5; i++)
        {
            dp[0, i] = 1;
        }

        for(var i = 1;i<n; i++){
            dp[i, 0] =  dp[i - 1, 0] + dp[i - 1, 1] + dp[i - 1, 2] + dp[i - 1, 3] + dp[i - 1, 4];
            dp[i, 1] =  dp[i - 1, 1] + dp[i - 1, 2] + dp[i - 1, 3] + dp[i - 1, 4];
            dp[i, 2] =  dp[i - 1, 2] + dp[i - 1, 3] + dp[i - 1, 4];
            dp[i, 3] =  dp[i - 1, 3] + dp[i - 1, 4];
            dp[i, 4] =  dp[i - 1, 4];
        }

        var sum = 0;
        for(var i = 0; i<=4; i++){
            sum += dp[n-1, i];
        }
        
        return sum;
    }   

}