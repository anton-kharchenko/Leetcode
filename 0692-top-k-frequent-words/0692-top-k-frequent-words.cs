public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        var dictionary = new Dictionary<string, int>();
        foreach(var word in words){
            if(dictionary.ContainsKey(word)){
                dictionary[word]++;
            }else{
                dictionary.Add(word, 1);
            }
        }
        return dictionary.OrderByDescending(i=>i.Value).ThenBy(i=>i.Key).Take(k).Select(i=>i.Key).ToList();
    }
}