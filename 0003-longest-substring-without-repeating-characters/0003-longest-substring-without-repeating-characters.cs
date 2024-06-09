public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var start = 0;
        var end = 0;
        var hs = new HashSet<char>();
        var maxWindow = 0;
        var currentWindow = 0;
        while(end<s.Length){
            var letter = s[end];
            while(hs.Contains(letter)){
                var letterToDelete = s[start];
                hs.Remove(letterToDelete);
                start += 1;
            }

            hs.Add(letter);
            currentWindow = end - start + 1;
            maxWindow = Math.Max(maxWindow, currentWindow);
            end += 1;
        }
        return maxWindow;
    }
}

   