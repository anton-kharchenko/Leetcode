public class Solution {
    public int CountPrefixes(string[] words, string s) {
        return words.Count(i=>s.StartsWith(i));
    }
}