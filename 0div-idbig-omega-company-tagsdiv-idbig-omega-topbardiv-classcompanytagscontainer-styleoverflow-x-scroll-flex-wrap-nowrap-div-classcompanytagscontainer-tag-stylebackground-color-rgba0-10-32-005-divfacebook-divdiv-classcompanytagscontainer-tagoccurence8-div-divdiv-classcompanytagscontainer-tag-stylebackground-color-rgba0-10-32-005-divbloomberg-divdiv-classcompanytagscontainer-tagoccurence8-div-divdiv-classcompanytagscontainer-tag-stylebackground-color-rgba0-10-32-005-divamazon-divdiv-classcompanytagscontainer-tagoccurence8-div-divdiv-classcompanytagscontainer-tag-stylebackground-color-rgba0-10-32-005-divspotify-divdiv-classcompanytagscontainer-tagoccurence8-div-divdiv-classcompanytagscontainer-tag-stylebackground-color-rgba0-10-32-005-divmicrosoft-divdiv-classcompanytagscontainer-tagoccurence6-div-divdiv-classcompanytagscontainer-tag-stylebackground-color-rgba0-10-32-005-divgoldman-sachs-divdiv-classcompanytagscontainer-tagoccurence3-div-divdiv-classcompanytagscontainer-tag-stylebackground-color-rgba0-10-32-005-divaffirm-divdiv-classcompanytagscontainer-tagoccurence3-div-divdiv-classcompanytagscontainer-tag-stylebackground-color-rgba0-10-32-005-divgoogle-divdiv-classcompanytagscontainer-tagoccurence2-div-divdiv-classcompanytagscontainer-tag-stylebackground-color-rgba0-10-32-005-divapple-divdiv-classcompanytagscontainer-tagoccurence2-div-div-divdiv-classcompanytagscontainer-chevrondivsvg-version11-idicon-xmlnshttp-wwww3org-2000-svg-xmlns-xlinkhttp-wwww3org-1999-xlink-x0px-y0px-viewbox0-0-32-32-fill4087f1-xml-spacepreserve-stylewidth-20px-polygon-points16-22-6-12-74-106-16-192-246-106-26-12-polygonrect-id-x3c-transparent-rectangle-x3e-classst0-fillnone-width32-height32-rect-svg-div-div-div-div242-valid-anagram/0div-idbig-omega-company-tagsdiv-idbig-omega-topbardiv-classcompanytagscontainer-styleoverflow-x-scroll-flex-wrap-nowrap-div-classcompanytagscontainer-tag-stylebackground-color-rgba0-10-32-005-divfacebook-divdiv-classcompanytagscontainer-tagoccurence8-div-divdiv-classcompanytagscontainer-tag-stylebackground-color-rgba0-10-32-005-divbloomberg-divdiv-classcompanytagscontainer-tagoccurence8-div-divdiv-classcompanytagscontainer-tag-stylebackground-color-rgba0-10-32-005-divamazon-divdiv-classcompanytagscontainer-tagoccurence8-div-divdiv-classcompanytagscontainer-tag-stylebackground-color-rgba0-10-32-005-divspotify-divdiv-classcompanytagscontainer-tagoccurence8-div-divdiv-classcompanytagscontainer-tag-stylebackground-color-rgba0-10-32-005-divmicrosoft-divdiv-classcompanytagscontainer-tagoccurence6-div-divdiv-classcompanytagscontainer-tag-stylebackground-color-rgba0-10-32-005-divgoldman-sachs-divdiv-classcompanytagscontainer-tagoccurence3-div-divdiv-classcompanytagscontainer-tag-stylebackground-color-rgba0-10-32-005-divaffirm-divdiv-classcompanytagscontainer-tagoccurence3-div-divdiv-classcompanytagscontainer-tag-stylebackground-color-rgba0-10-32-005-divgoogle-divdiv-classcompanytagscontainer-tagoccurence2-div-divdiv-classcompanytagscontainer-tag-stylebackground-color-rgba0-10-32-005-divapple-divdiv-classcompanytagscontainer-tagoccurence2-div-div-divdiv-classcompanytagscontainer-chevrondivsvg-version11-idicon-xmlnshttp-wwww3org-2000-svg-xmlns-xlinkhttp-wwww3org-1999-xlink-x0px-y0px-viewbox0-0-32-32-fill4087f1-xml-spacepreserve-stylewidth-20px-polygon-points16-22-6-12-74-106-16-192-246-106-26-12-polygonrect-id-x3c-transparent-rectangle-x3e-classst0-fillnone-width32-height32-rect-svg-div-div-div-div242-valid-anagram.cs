public class Solution {
    public bool IsAnagram(string s, string t) {
    if(s.Length != t.Length) return false;
     var dS = new Dictionary<char, int>();
     var dT = new Dictionary<char, int>();
        
     foreach(var c in s.ToCharArray()){
         if(dS.ContainsKey(c)){
             dS[c]++;
         }else{
             dS.Add(c, 1);
         }
     }
        
             foreach(var c in t.ToCharArray()){
         if(dT.ContainsKey(c)){
             dT[c]++;
         }else{
             dT.Add(c, 1);
         }
     } 
        return dS.Count == dT.Count && !dS.Except(dT).Any();
        
    }
}