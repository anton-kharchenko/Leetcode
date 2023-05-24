public class Solution {
    public string[] FindWords(string[] words) {
        var rows = new []{"qwertyuiop", "asdfghjkl", "zxcvbnm"}.Select(i=>i.ToHashSet());
        return words.Where(w=>rows.Any(i=>w.ToLower().All(i.Contains))).ToArray();
    }
}