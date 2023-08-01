public class Solution {
    public string LongestPalindrome(string s) {
    
        int start = 0;
        int end = 0;
        
        for(var i = 0; i<s.Length; i++){
            var len = Math.Max(GetLength(i, i, s), GetLength(i, i+1, s));
            if(len<= end - start) continue;
            start = i - (len - 1) / 2;
            end = i + len/2;
        }
        
        return s.Substring(start, end - start + 1);
    }
    
    public int GetLength(int start, int end, string s){
        while(start>= 0  && end<s.Length && s[start] == s[end]){
            start--;
            end++;
        }
        
        return end - start - 1;
    }
}