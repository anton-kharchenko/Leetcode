public class Solution {
    public int NumSquares(int n)
    {
        var dp = new int[n + 1];
        return Dfs(n, dp);
    }
    
    int Dfs(int n, IList<int> dp)
    {
        if (n == 0)
            return 0;

        if (dp[n] != 0)
            return dp[n];

        var result = n;

        for (int i = 1; i * i <= n; i++)
        {
            
            result = Math.Min(result, 1 + Dfs(n - i * i, dp));

        }

        dp[n] = result;
        
        return result;
    }
}