public class Solution {
    
    public int LongestCommonSubsequence(string text1, string text2) {
        // return Dfs(text1, text2, 0, 0);
        var length1 = text1.Length;
        var length2 = text2.Length;
        var dp = new int[length1 + 1, length2 + 1];
        
        for(var i = 0; i<length1; i++){
            for(var j = 0; j<length2; j++){
              if(text1[i]==text2[j]){
                  dp[i+1, j+1] =  1 + dp[i,j];
              }else{
                  dp[i+1, j+1] = Math.Max(dp[i+1, j], dp[i, j+1]);
            }
          }
        }
        return dp[length1, length2];
      }
}
//     1.Recursive solution 
//     public int Dfs(string s1, string s2, int index1, int index2){
//         if(index1 == s1.Length || index2 == s2.Length)
//             return 0;
//         if(s1[index1]==s2[index2]){
//             return 1+ Dfs(s1, s2, index1+1, index2 + 1);
//         }else{
//             return Math.Max(Dfs(s1, s2, index1, index2 + 1), 
//                             Dfs(s1, s2, index1+1, index2));
//         }
//     }

//    2. Recursive solution with cache 
//         public int Dfs(string s1, string s2, int index1, int index2, int[,] cache){
//         if(index1 == s1.Length || index2 == s2.Length)
//             return 0;
//         if(cache[index1, index2] != 0)
//             return cache[index1, index2];
           
//         if(s1[index1]==s2[index2]){
//             cache[index1, index2] = 1+ Dfs(s1, s2, index1+1, index2 + 1, cache);
//         }else{
//             cache[index1, index2] = Math.Max(Dfs(s1, s2, index1, index2 + 1, cache), 
//                                              Dfs(s1, s2, index1+1, index2, cache));
//         }
//         return cache[index1, index2];
//     }
// }

