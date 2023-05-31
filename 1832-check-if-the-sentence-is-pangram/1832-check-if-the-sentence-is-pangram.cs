public class Solution {
    public bool CheckIfPangram(string sentence) {
        var set = new HashSet<char>(sentence);
        
        return set.Count == 26;
    }
}