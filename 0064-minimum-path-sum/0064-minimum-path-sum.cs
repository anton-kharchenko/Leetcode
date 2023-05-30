public class Solution {
    public int MinPathSum(int[][] grid) {
          int m = grid.Length, n = grid[0].Length;
          var dp = new int[m, n];
        
        for(var i = 0; i<m; i++){
            for(var j = 0; j<n; j++){
                if(i==0 && j==0){
                    dp[i, j] = grid[i][j];
                } else if(i == 0){
                    dp[i, j] = grid[i][j] + dp[i, j - 1];
                }else if(j == 0){
                    dp[i, j] = grid[i][j] + dp[i-1, j];
                }else{
                    dp[i, j] = grid[i][j] + Math.Min(dp[i-1, j], dp[i, j-1]);
                }
            }
        }
        
        return dp[m - 1, n - 1];
    }
}