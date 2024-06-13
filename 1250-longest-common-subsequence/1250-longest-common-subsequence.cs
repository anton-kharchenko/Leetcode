public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        var length1 = text1.Length;
        var length2 = text2.Length;
        var cache = new int[length1 + 1, length2 + 1];

        for(var i = 1; i<= length1; i++){
            for(var j = 1; j<= length2; j++){
                if(text1[i-1] == text2[j-1]){
                  cache[i, j] = 1 + cache[i - 1, j - 1];
                }else{
                  cache[i, j] = Math.Max(cache[i - 1, j], cache[i, j - 1]);
                }
            }
        }

        return cache[length1, length2];
    }

}

