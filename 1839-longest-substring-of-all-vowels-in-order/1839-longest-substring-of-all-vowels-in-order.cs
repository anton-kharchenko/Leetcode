public class Solution {
    public int LongestBeautifulSubstring(string word) {
        var set = new HashSet<char>();
        var res = 0;
        var start = 0;
        
        for(var end = 0; end<word.Length; end++){
            if(end > 0 && word[end]<word[end - 1]){
                start = end;
                set.Clear();
            }
            
            set.Add(word[end]);
            
            if(set.Count == 5){
                res = Math.Max(res, end - start + 1);
            }
        }
        
        return res;
    }
}