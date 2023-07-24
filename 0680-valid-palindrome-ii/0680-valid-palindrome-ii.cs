public class Solution {
    public bool ValidPalindrome(string s)
    {
        return HasError(0, s.Length -1, s, false);
    }
    
    public bool HasError(int start, int end, string s, bool hasError){
        while(start<end){
            if(s[start] == s[end]){
                start++;
                end--;
                continue;
            }
            
            if(hasError) return false;
            return HasError(start +1, end, s, true) || HasError(start, end - 1, s, true);
        }
        
        return true;
    }
}