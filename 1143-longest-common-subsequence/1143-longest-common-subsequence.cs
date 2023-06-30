public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        var n = text1.Length;
        var m = text2.Length;
        var dp = new int[n+1, m+1];
        
        for(var i = 0;i<n; i++){
            for(var j = 0; j<m; j++){
                dp[i, j] = 0;
            }
        }
        
        for(var i=0; i<n; i++){
            for(var j = 0;j<m;j++){
                if(text1[i] == text2[j]){
                    dp[i+1, j+1] = 1 + dp[i, j];
                }else{
                    dp[i+1, j+1] = Math.Max(dp[i, j+1], dp[i+1, j]);
                }
            }
        }
        
        
        return dp[n, m];
    }
}

