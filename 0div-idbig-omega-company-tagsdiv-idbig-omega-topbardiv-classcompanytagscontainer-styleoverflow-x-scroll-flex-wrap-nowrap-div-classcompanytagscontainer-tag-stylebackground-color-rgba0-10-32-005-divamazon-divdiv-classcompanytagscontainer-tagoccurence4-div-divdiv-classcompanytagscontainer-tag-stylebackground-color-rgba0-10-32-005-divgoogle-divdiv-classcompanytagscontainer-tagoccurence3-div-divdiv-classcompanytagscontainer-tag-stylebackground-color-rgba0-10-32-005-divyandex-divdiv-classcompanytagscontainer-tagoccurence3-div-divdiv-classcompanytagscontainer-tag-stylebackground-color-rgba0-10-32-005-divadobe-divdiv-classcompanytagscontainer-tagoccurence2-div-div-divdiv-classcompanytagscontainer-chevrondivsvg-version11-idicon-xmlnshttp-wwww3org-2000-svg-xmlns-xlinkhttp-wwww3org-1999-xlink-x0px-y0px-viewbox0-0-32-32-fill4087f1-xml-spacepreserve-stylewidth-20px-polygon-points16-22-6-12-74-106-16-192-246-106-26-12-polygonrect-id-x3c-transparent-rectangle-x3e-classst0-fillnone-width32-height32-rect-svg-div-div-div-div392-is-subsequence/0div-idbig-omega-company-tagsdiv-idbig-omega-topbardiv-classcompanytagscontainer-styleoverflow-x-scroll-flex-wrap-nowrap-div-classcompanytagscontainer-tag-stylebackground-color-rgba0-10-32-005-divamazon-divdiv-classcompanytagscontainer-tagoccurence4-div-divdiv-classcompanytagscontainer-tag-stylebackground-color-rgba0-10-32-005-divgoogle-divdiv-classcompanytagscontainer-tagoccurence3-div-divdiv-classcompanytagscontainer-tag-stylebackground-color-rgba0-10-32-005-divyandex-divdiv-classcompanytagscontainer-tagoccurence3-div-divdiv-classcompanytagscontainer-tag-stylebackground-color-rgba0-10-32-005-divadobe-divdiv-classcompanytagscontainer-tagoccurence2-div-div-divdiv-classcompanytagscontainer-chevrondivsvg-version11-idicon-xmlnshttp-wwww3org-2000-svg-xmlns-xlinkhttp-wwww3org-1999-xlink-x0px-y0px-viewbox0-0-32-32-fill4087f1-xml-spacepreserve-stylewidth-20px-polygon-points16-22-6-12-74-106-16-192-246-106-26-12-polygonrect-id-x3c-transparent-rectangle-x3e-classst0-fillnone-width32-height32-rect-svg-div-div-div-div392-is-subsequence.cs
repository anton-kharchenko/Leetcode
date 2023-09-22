public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0) return true;
        
        int sPointer = 0;
        
        for(var i = 0; i<t.Length; i++){
            if(s[sPointer] == t[i]){
                sPointer++;
            }
            
            if(sPointer == s.Length){
                return true;
            }
        }
        
        return false;
    }
}