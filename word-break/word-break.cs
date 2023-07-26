public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var set = new HashSet<string>(wordDict);
        var l = s.Length; 
        var dp = new bool[l+1];
        dp[0] = true;
        
        for(var i = 1; i<=l; i++){
            for(var j = 0; j<i; j++){
                var sub = s.Substring(j, i-j);
                if(dp[j] && set.Contains(sub) ){
                   dp[i] = true; 
                    break;
                }
            }
        }
        
        
        return dp[l];
        
    }


}