public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        var dict = new Dictionary<string, int>();
        
        foreach(var word in words){
            if(dict.ContainsKey(word)){
                dict[word]++;
            }else{
                dict.Add(word, 1);
            }
        }
        
        return dict.OrderByDescending(i=>i.Value).ThenBy(i=>i.Key).Take(k).Select(i=>i.Key).ToList();
    }
}