public class Solution {
    public bool WordPattern(string pattern, string s) {
        var dict = new Dictionary<char, string>();
        var arr = s.Split(" ").ToArray();
        
        if(arr.Length != pattern.Length) return false;
        
        
        for(var i = 0; i<arr.Length; i++){
            if(dict.ContainsKey(pattern[i]) && dict[pattern[i]] != arr[i]){
                return false;
            }
            
            if(!dict.ContainsKey(pattern[i]) && dict.ContainsValue(arr[i])){
                return false;
            }
            
            if(!dict.ContainsKey(pattern[i]) && !dict.ContainsValue(arr[i])){
                dict.Add(pattern[i], arr[i]);
            }
        }
        
        return true;
    }
}
