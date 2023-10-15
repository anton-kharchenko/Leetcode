public class Solution {
    
    public int LongestCommonSubsequence(string text1, string text2) {
        //return Recursive(text1, text2, 0, 0);
        // return RecursiveWithCache(text1, text2, 0, 0, new int[text1.Length,text2.Length]);
        return DP(text1, text2, 0, 0, new int[text1.Length + 1, text2.Length + 1]);
     }
     
    
    public int Recursive(string s1, string s2, int index1, int index2){ // Time: O(2^(n+m)) Space: O(n+m)
        if(index1 == s1.Length || index2 == s2.Length)
            return 0;
       if(s1[index1]==s2[index2]){
           return 1 + Recursive(s1, s2, index1+1, index2 + 1);
         }else{
            return Math.Max(Recursive(s1, s2, index1, index2 + 1), 
                           Recursive(s1, s2, index1+1, index2));
      }
    }
    
    public int RecursiveWithCache(string s1, string s2, int index1, int index2, int[,] cache){ // Time: O(n*m) Space: O(n+m)
         if(index1 == s1.Length || index2 == s2.Length)
             return 0;
        if(cache[index1, index2] != 0)
             return cache[index1, index2];
           
         if(s1[index1]==s2[index2]){
            cache[index1, index2] = 1 + RecursiveWithCache(s1, s2, index1+1, index2 + 1, cache);
        }else{
             cache[index1, index2] = Math.Max(RecursiveWithCache(s1, s2, index1, index2 + 1, cache), 
                                             RecursiveWithCache(s1, s2, index1+1, index2, cache));
        }

         return cache[index1, index2];
    }
    
    public int DP(string s1, string s2, int index1, int index2, int[,] dp){ // Time: O(n*m) Space: O(n+m)
        var s1Length = s1.Length;
        var s2Length = s2.Length;
        
        for(var i = 0; i<s1Length; i++){
            for(var j = 0; j<s2Length; j++){
                if(s1[i] == s2[j]){
                    dp[i+1, j+1] = 1  + dp[i, j];
                }else{
                    dp[i+1, j+1] = Math.Max(dp[i+1, j], dp[i, j+1]);
                }
            }
        }
        
        return dp[s1Length, s2Length];
        
    }
}

