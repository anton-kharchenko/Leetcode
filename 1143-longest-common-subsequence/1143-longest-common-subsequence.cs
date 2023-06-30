public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        var n = text1.Length;
        var m = text2.Length;
        var dp = new int[m+1];
    
        
        for(var i=0; i<n; i++){
            var curr = new int[m+1];
            for(var j = 0;j<m;j++){
                if(text1[i] == text2[j]){
                    curr[j+1] = 1 + dp[j];
                }else{
                    curr[j+1] = Math.Max(dp[j+1], curr[j]);
                }
            }
            
            dp = curr;
        }
        
        
        return dp[m];
    }
}

