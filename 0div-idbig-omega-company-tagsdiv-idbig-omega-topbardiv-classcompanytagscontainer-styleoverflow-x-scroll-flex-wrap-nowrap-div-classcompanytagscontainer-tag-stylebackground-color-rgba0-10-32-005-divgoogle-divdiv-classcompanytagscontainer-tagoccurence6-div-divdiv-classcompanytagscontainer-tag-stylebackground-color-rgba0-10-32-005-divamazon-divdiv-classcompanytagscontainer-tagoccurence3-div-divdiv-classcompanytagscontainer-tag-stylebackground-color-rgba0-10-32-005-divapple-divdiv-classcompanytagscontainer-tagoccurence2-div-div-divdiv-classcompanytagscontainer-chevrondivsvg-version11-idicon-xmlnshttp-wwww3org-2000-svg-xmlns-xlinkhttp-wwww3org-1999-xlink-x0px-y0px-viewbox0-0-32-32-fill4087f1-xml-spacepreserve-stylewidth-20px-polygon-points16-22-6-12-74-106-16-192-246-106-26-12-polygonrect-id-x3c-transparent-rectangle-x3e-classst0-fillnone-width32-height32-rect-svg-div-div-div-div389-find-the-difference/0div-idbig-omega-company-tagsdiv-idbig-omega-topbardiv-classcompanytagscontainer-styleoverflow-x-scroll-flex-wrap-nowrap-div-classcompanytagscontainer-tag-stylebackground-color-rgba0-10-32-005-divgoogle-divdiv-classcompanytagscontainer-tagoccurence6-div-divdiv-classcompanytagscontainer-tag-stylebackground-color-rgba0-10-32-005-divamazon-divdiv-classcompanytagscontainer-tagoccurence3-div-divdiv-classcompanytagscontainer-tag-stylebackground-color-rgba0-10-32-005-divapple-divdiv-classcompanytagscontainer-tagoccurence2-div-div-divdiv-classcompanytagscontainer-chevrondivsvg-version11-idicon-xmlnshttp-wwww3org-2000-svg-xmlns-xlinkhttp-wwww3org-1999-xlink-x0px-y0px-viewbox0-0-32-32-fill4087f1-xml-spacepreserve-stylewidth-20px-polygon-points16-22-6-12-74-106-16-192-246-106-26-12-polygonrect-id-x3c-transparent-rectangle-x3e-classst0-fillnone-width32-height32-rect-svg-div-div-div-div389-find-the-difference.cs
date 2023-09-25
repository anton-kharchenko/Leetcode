public class Solution {
    public char FindTheDifference(string s, string t) {
        var s_dict = new Dictionary<char, int>();
        var t_dict = new Dictionary<char, int>();
        foreach(var i in s){
            if(s_dict.ContainsKey(i)){
                s_dict[i]++;
            }else{
                s_dict.Add(i, 1);
            }
        }
        
        foreach(var i in t){
            if(t_dict.ContainsKey(i)){
                t_dict[i]++;
            }else{
                t_dict.Add(i, 1);
            }
        }
        
        foreach(var (key, value) in t_dict){
            if(!s_dict.ContainsKey(key)){
                return key;
            }
            if(value != s_dict[key]){
                return key; 
            }
        }
        
        return "".ToCharArray()[0];
    }
}