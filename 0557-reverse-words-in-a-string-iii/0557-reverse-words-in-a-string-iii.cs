public class Solution {
    public string ReverseWords(string s) {
    var words  = s.Split(' ').ToArray();
    var left = 0;
    var res = string.Empty;
    foreach(var word in words){
        res += string.Concat(word.Reverse());
        res += " ";
    }
    return res.Trim();
    }
}