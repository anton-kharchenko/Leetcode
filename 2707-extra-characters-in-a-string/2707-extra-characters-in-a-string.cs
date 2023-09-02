public class Solution {
    Dictionary<int, int> cache = new Dictionary<int, int>();
    
    public int MinExtraChar(string s, string[] dictionary) {
        return Dfs(s, dictionary);
    }
    
    public int Dfs(string text, string[] dictionary){
        
        if(text.Length <= 0) return 0;
        if(cache.ContainsKey(text.Length))
            return cache[text.Length];
        
        var min = text.Length; 
        
        foreach(var word in dictionary){
                if(text == word){
                    min = 0;
                    cache[text.Length] = min;
                    return min;
                    
                }else if(text.StartsWith(word)){
                    var res = Dfs(text.Substring(word.Length), dictionary);
                    min = Math.Min(min, res);
                    
                }
        }
        
        min = Math.Min(min, 1 + Dfs(text.Substring(1), dictionary));
        cache[text.Length] = min;
        return min;
    }
}