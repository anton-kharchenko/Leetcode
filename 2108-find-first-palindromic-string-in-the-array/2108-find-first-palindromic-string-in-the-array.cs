public class Solution {
    public string FirstPalindrome(string[] words) 
        => words.FirstOrDefault(i=> i == string.Concat(i.Reverse()) ) ?? string.Empty;
        
        
    
}
