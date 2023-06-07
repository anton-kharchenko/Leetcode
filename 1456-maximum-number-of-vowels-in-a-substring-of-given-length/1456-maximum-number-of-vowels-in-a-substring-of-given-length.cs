public class Solution {
    public int MaxVowels(string s, int k) {
        var set = new HashSet<char>(){
            'a', 'e', 'i', 'o', 'u'
        };
        
        int count = 0, res = 0;
        
        for(var i =0; i<s.Length; i++){
            
            var curr = s[i];
            
            if(set.Contains(curr)){
                count++;
            }
            
            if(i>=k && set.Contains(s[i-k])){
                count--;
            }
            
            res = Math.Max(count, res);
        }
        
        return res;
        
    }
}