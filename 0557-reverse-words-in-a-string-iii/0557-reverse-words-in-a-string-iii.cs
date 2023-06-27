public class Solution {
    public string ReverseWords(string s) {
        var res = string.Empty;
        var arr = s.Split(" ").ToArray();
        for(var i = 0; i<arr.Length; i++){
            var word = arr[i].Reverse().ToArray();
            res += string.Concat(word);
            res += " ";
        }
        
        return res.TrimEnd();
    }
}