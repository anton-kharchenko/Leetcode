public class Solution {
    public bool WordPattern(string pattern, string s) {
        var dic = new Dictionary<char, string>();
        var arr = s.Split(" ").ToArray();
        if(pattern.Length != arr.Length) return false;
        for(var i = 0; i<arr.Length; i++ ){
          if(!dic.ContainsKey(pattern[i])&& !dic.ContainsValue(arr[i])){
              dic.Add(pattern[i], arr[i]);
                
            }
            
            if(!dic.ContainsKey(pattern[i]) || dic[pattern[i]] != arr[i]){
                return false;
            }
        }
        return true;
    }
}
