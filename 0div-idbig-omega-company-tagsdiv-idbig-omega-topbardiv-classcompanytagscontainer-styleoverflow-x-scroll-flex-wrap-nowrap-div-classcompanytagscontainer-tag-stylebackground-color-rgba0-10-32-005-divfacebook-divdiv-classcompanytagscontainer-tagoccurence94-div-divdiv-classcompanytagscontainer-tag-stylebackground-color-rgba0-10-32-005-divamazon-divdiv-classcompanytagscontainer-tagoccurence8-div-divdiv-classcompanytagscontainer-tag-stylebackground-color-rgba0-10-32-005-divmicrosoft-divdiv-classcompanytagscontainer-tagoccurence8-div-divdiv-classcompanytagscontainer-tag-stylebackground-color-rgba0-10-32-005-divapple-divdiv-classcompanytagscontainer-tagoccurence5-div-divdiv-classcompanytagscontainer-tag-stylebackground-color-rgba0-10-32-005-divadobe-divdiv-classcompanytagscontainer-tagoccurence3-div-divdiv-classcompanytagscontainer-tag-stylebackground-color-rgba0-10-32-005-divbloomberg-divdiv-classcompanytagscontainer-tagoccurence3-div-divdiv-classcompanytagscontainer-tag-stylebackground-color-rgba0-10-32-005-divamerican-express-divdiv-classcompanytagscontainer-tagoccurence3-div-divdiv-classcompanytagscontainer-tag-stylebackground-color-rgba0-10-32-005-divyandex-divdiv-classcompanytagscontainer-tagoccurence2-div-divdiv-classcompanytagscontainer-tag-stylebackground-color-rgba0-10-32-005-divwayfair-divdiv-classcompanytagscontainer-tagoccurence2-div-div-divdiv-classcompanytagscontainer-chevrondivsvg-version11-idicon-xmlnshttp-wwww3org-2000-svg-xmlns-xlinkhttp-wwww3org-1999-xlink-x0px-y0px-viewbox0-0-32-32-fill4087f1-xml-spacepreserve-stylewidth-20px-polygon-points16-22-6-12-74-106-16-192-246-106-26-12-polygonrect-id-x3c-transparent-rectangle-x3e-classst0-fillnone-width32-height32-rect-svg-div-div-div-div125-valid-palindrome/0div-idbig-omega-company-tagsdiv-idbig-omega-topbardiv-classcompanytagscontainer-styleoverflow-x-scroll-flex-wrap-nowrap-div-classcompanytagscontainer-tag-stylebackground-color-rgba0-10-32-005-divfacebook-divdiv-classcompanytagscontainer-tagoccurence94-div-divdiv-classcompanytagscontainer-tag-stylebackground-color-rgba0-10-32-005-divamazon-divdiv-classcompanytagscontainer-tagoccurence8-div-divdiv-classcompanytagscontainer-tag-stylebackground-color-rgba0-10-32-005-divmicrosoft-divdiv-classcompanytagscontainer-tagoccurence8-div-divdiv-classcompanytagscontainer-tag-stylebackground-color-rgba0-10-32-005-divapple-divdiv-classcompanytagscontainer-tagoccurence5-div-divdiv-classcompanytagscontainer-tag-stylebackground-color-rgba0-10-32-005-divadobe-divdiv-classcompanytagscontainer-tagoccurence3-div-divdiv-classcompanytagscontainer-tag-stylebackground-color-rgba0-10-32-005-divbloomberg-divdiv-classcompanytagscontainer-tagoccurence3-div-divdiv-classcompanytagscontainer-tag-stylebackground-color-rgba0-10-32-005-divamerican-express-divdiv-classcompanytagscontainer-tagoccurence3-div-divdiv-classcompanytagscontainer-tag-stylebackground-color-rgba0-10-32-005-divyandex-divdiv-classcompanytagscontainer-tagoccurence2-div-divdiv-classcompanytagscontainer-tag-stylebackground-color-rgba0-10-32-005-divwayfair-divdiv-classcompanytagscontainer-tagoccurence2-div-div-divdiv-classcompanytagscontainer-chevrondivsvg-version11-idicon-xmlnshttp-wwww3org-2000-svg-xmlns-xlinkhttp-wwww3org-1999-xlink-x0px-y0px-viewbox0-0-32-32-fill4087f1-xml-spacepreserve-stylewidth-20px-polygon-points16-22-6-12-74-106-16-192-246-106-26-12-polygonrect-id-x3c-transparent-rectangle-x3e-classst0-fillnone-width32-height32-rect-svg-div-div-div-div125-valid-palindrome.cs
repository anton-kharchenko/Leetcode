using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        
        var strWithoutSpaces = Regex.Replace(s, @"[^0-9a-zA-Z]+", "").ToLower();
        var arr = strWithoutSpaces.ToCharArray();
        var left = 0;
        var right = arr.Length - 1;

        
        while(left < right){
            if(arr[left] != arr[right])
                return false;
            
            left++;
            right--;
        }
        
        return true;
    }
}