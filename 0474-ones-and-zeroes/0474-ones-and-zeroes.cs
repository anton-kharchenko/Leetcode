public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
        var dp = new int[m+1, n+1];
        
        foreach(var str in strs){
           var zeroCount =   str.Count(i=>i=='0');
           var oneCount = str.Length - zeroCount;
            
            for(int i = m; i>=0; i--){
                for(var j = n; j>=0; j--){
                    if(i-zeroCount>= 0 && j-oneCount>=0){
                        dp[i, j] = Math.Max(dp[i, j], dp[i-zeroCount, j-oneCount] + 1);
                    }
                }
            }
        }
        
        return dp[m, n];
    }
}