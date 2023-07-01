public class Solution {
    public int MinDistance(string word1, string word2) {
        var m = word1.Length;
        var n = word2.Length;
        var cache = new int[m+1, n+1];
        
        for(var i =0; i<m+1; i++){
            cache[i, n] = m - i;
        }
                
        for(var j =0; j<n+1; j++){
            cache[m, j] = n - j;
        }
        
        for(var i = m - 1; i>=0; i--){
            for(var j = n- 1; j>=0;j--){
                if(word1[i] == word2[j]){
                    cache[i, j] = cache[i+1, j+1];
                }
                else{
                    cache[i, j] = 1 + Math.Min(Math.Min(cache[i+1, j+1], cache[i+1, j]), cache[i, j+1]);
                }
            }
        }
        
        return cache[0, 0];
        
    }
}