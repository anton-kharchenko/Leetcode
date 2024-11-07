public class Solution {
    public int[] SameEndSubstringCount(string s, int[][] queries) {
        var dp = new int[s.Length, 26];
        dp[0,s[0]-'a'] = 1;
        for (int i = 1; i < s.Length; i++){
            for (int j = 0; j < 26; j++){
                dp[i,j] = dp[i-1,j] + (s[i]-'a'==j ? 1 : 0);
            }
        }

        var ans = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++){
            int l = queries[i][0];
            int r = queries[i][1];
            for (int j = 0; j < 26; j++){
                var n = dp[r,j]-dp[l,j];
                if (dp[l,j] > 0 && s[l]-'a' == j) n++;
                ans[i] += Sum(n);
            }
        }

        return ans;
    }

    public int Sum(int n){
        return (int)((double)(n+1)*((double)n/(double)2));
    }
}