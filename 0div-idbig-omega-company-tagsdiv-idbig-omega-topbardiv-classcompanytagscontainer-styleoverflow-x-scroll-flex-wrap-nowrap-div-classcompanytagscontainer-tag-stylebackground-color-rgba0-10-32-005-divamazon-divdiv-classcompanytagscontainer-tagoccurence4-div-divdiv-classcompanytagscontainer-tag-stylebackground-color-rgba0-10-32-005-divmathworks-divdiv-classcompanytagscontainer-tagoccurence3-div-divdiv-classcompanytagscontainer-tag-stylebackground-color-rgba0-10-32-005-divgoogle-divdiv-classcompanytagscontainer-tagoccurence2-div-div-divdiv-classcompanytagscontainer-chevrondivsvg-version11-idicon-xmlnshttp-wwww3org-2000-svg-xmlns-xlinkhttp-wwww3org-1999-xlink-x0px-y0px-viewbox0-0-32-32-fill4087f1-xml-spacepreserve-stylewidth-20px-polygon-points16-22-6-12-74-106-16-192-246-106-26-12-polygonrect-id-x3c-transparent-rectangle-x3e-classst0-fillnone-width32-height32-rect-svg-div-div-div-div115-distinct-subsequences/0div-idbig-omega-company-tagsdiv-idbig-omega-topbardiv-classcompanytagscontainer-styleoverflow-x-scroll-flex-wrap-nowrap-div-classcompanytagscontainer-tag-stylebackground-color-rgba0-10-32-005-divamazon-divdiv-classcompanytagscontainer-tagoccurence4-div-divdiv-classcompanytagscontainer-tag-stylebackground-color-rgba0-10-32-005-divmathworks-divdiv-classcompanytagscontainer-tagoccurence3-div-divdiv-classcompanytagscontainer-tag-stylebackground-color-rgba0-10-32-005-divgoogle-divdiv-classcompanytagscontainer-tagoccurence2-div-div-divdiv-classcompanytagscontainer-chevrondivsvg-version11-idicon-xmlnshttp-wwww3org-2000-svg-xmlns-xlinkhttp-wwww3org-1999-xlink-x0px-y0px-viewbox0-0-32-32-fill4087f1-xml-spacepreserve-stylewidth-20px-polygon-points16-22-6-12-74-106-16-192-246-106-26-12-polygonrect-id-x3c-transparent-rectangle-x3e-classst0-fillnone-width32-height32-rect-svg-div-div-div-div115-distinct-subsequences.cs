public class Solution {
    public int NumDistinct(string s, string t) {
        int n = s.Length, m = t.Length;
        if(n<m) 
            return 0;
        
        var cache = new int[n + 1, m + 1];
        
        for(var i = 0;i<=n;i++){
            cache[i, 0] = 1;
        }
        
        for(var i = 1; i<=n; i++){
            for(var j = 1;j<=m; j++){
                if(s[i - 1] == t[j-1]){
                    cache[i, j] = cache[i-1, j - 1] + cache[i-1, j];
                }else{
                    cache[i, j] = cache[i-1,j];
                }
            }
        }
        
      return cache[n, m];
    }

  
}