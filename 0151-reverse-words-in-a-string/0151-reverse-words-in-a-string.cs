public class Solution {
    public string ReverseWords(string s) {
        s.Trim();
        string[] words  = s.Split(' ');
        StringBuilder result = new StringBuilder();
        
        Array.Reverse(words);
        
        foreach(string word in words){
            if(string.IsNullOrWhiteSpace(word)){
                continue;
            } 
            
            result.Append(word);
            result.Append(' '); 
        }
        
        return result.ToString().Trim();
    }
}