public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var res = new List<int>();
        if(p.Length > s.Length) return res;
        var pCount = new int[26];
        var sCount= new int[26];
        
        foreach(var i in p){
            pCount[i-'a']++;
        }
        var length  = p.Length; 
        for(var i = 0;i<length; i++){
            sCount[s[i] - 'a']++;
        }
        
        if(Enumerable.SequenceEqual(sCount, pCount)) 
           res.Add(0); 
            
        for(var i = 1; i<=s.Length - length; i++ ){
            sCount[s[i-1] - 'a']--;
            sCount[s[i+(length-1)] -'a']++;
            if(Enumerable.SequenceEqual(sCount, pCount))
                res.Add(i);
        }
        
        return res;    
    }                   
    
}