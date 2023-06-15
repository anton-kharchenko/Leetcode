public class Solution {
    public int MinSwaps(string s) {
        int max = 0, curr = 0;
        
        for(var i = 0; i<s.Length; i++){
            if(s[i] == ']'){
                curr += 1;
            }else{
                curr -= 1;
            }
            max = Math.Max(max, curr);
        }
        
        var result = (max + 1)/2;
        
        return result;
    }
}