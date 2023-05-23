public class Solution {
    public string FirstPalindrome(string[] words) {
        
     foreach (var t in words)
     {
         if(t == string.Concat(t.Reverse())){
             return t;
         }
     }
        
        return string.Empty;
    }
}