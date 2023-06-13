public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var set = new HashSet<string>();
             var list = new List<string>();
            if(s.Length <= 10) return list;
    
            for(var i = 0; i+9<s.Length; i++){
                var temp = s.Substring(i, 10);
                if(set.Contains(temp) && !list.Contains(temp )){
                    list.Add(temp);
                }else{
                    set.Add(temp);
                }
            }
        
     
       return list;
    }
}