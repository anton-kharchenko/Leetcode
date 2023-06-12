public class Solution {
    public bool AreOccurrencesEqual(string s) {
        var dic = new Dictionary<char, int>();
        
        foreach(var c in s){
            if(!dic.ContainsKey(c)){
                dic.Add(c, 1);
            }else{
                dic[c] += 1;
            }
        }
        
 
        
        
        if(dic.Count == 0) return true;
        
        var num = dic.First().Value;
        
        foreach(var (key, value) in dic){
            if(value != num){
                return false;
            }
        }
        
        return true;
    }
}