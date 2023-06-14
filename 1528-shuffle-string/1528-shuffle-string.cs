public class Solution {
    public string RestoreString(string s, int[] indices) {
        var c = new char[s.Length];
        
        for(var i = 0; i<s.Length; i++){
            c[indices[i]] =  s[i];
        }
        
        return new string(c);
    }
}