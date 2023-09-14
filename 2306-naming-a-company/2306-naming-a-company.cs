public class Solution {
    public long DistinctNames(string[] ideas) {
        var rs = 0L;
        
        var dic = GroupByChar(ideas);
        var keys = dic.Keys.ToList();
        
        for(var i = 0; i<keys.Count-1; i++){
            for(var j = i+1; j<keys.Count; j++){
            var count = dic[keys[i]].Intersect(dic[keys[j]]).ToList().Count;
                rs += (dic[keys[i]].Count - count) * (dic[keys[j]].Count - count);
           }
        }
        
        rs *= 2;
        
        return rs;
    }
    
    public Dictionary<char, HashSet<string>> GroupByChar(string[] ideas){
        var dic = new  Dictionary<char, HashSet<string>>();
        
        foreach(var idea in ideas){
            if(!dic.ContainsKey(idea[0])){
                dic.Add(idea[0], new HashSet<string>(){idea.Substring(1)});
            }else{
                dic[idea[0]].Add(idea.Substring(1));
            }
        }
        
        return dic;
        
    }
}