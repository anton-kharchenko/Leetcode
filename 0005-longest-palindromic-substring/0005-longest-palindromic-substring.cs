public class Solution {
    public string LongestPalindrome(string s) {
       var start = 0;
       var end = 0;
        var len = 0;
        for(var i = 0; i<s.Length; i++){
            len = Math.Max(ExpandSubstring(i,i, s), ExpandSubstring(i,i+1, s));
            if(len>end-start){
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }

        return s.Substring(start, end - start + 1);
    }

    private int ExpandSubstring(int left, int right, string s){
        while(left>=0&&right<s.Length&&s[left] == s[right]){
            right++;
            left--;
        }

        return right - left - 1;
    }
}