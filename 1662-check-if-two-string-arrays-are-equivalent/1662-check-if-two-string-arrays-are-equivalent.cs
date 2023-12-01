public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        var str1 = string.Empty; 
        var str2 = string.Empty; 
        
        for(var i = 0; i<word1.Length; i++){
            str1 += word1[i];
        }
        
        for(var i = 0; i<word2.Length; i++){
            str2 += word2[i];
        }
        
        return str1 == str2;
    }
}