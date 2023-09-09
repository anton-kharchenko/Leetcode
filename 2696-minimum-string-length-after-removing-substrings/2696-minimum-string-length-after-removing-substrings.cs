public class Solution {
    public int MinLength(string s) {
        var c = true;
        while(c){
            c = false;
            var length = s.Length;
            s = s.Replace("AB", "");
            s = s.Replace("CD", "");
            if(s.Length != length) c = true;
        }
        
        return s.Length;
    }
}