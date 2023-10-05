public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        if(s.Length != words.Count) return false;
        
        for(var i =0; i<words.Count; i++){
            var word = words[i];
            if(string.IsNullOrWhiteSpace(word)) return false;
            if(word[0] != s[i]){
                return false;
            }
        }
        
        return true;
    }
}