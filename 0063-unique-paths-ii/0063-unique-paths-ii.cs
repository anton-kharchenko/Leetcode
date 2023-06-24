public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int n  = obstacleGrid.Length, m = obstacleGrid[0].Length;
        
        var dp = new int[m];
        dp[m-1] = 1;
        
        for(var i = n -1; i>= 0; i--){
            for(var j = m-1;j>=0; j--){
                if(obstacleGrid[i][j] == 1){
                    dp[j] = 0;
                }else if(j+1 < m){
                    dp[j] = dp[j] + dp[j+1];
                }
            }
        }
        
        return dp[0];
    }
    
   
}