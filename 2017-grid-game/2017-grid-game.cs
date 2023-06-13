public class Solution {
    public long GridGame(int[][] grid) {
        var score = Int64.MaxValue;
        var n = grid[0].Length;
        
        var prefixSum = new long[n];
        var prefixSum2 = new long[n];
        
        prefixSum[0] = grid[0][0];
        prefixSum2[0] = grid[1][0];
        
        for(var i = 1; i<n; i++){
            prefixSum[i] = prefixSum[i-1] + grid[0][i];
            prefixSum2[i] = prefixSum2[i-1] + grid[1][i];
        }
        
       for(var i = 0; i<n; i++){
            var topRight = prefixSum[n-1] - prefixSum[i];
            var bottomLeft = i == 0 ? 0 : prefixSum2[i-1];
           
            score = Math.Min(score, Math.Max(topRight, bottomLeft));
        }
        
        
        return score;
    }
}