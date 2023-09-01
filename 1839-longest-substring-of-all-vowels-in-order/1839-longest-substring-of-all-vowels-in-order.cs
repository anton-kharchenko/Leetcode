public class Solution {
    public int LongestBeautifulSubstring(string word) {
        var max = 0;
        var start = 0;
        var hashSet = new HashSet<char>();
        
        for(var end = 0; end<word.Length; end++){
            
            if(end > 0 && word[end] < word[end - 1]){
                hashSet.Clear();
                start = end;
            }
            
            
            hashSet.Add(word[end]);
            
            if(hashSet.Count == 5) 
                max = Math.Max(max, end - start + 1);
        }
        
        
        return max;
    }
}