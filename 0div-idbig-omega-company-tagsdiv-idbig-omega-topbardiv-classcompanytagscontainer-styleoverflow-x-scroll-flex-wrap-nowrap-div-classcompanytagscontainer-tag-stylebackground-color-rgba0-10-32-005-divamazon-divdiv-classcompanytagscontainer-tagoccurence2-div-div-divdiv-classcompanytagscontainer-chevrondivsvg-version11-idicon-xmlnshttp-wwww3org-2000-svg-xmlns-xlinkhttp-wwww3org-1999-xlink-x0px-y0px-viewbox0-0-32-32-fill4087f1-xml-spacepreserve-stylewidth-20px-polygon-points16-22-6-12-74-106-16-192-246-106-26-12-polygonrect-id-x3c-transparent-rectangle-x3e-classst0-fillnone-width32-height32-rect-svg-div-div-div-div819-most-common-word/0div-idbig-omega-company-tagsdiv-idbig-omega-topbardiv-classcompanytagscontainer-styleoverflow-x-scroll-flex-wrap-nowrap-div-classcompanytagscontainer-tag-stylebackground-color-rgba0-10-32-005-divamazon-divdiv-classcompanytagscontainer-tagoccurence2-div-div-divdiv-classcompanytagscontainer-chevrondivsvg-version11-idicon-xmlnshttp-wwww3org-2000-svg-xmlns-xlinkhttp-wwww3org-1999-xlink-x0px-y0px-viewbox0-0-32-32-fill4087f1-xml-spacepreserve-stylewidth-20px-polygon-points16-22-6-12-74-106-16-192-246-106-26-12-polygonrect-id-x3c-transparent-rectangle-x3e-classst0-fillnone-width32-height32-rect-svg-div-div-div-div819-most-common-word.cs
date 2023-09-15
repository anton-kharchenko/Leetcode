public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        var dict = new Dictionary<string, int>();
        var words = paragraph
            .Replace("!", " ")
            .Replace("?", " ")
            .Replace("'", " ")
            .Replace(",", " ")
            .Replace(";", " ")
            .Replace(".", " ")
            .Replace("\"", " ")
            .ToLower()
            .Split(" ");
        foreach(var word in words)
        {
            if(banned.Any(i=>i == word)) continue;
            if(string.IsNullOrWhiteSpace(word.Trim())) continue;
            if(dict.ContainsKey(word)){
                dict[word]++;
            }else{
                dict.Add(word, 1);
            }
        }
        
        return dict.OrderByDescending(x=>x.Value).Select(x=>x.Key).First();
    }
}