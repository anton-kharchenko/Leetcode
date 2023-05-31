public class Solution {
    public int MinPathSum(int[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        var dp = new int[n, m];
        
        for(var i = 0; i<n; i++ ){
            for(var j = 0; j<m; j++){
                if(i==0 &&j==0){
                    dp[i, j] =  grid[i][j];
                }else if(j==0){
                    dp[i, j] = grid[i][j] + dp[i-1, j];
                }else if(i==0){
                    dp[i, j] = grid[i][j]  + dp[i, j-1];
                }else{
                     dp[i, j] = grid[i][j]  + Math.Min(dp[i-1, j], dp[i, j-1]); 
                }
            }
        }
        
        return dp[n-1, m-1];
    }
}

// O(n^m)