public class Solution {
    public string ReverseWords(string s) {
        var result = new StringBuilder();
        var words = s.Split(" ").ToArray();
        foreach(var word in words){
           var reversedWord = word.Reverse();
           result.Append(string.Concat(reversedWord)).Append(" ");
        }
        
        return result.ToString().Trim();
    }
}