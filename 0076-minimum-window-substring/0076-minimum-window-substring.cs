public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) return "";
        var map = new int[128];
        var count = 0;
        int start = 0, end = 0, minLen = int.MaxValue, startIndex = 0;
        
        foreach (var c in t) 
            map[c]++;
        
        while (end < s.Length) {
            
            if (map[s[end]] > 0) 
                count++;
            
            map[s[end]]--;    
            end++;

            while (count == t.Length) {
                
                if (end - start < minLen) {
                    startIndex = start;
                    minLen = end - start;
                }
                
                if (map[s[start]] == 0) {
                    count--;
                }
                
                map[s[start]]++;
                start++;
            }
          
        }

        return minLen == int.MaxValue ? "" : s.Substring(startIndex, minLen);
    }
}