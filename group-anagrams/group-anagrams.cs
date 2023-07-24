public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
      var dic = new Dictionary<int, List<string>>();
        
      foreach(var s in strs){
          var hashCode = string.Concat(s.OrderBy(i=>i)).GetHashCode();
          if(dic.ContainsKey(hashCode)){
              dic[hashCode].Add(s);
          }else{
              dic.Add(hashCode, new List<string>(){s});
          }
      }
        
      return dic.Values.ToArray();  
    }
}