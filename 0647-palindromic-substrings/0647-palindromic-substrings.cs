public class Solution {
    public int CountSubstrings(string s) {
        var res = 0;
        for(var i = 0; i<s.Length; i++){
            res += Calculate(i, i, s);
            res += Calculate(i, i+1, s);
        }  
        return res;
    }
    
    public int Calculate(int l, int r, string s){
        var res = 0;
        while(l>= 0 && r<s.Length && s[l] == s[r]){
            res++;
            l--;
            r++;
        }
        return res;
    }
}