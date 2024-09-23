public class Solution {
    public char RepeatedCharacter(string s) {
        var hs = new HashSet<char>();
        return s.FirstOrDefault(letter => !hs.Add(letter));
    }
}