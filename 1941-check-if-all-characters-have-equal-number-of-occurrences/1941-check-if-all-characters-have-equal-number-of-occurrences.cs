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
        
        var num = 0;
        if(dic.Count == 0) return true;
        
        num = dic.First().Value;
        
        foreach(var (key, value) in dic){
            if(value != num) return false;
        }
        
        
        return true;
    }
}