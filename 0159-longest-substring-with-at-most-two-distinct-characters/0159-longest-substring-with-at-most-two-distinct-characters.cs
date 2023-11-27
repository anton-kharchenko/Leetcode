public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        int windowStart = 0;
        int windowEnd = 0;
        int winodwSize = 0;
        int longestSubstringLength = 0;
        Dictionary<char, int> uniqueLetters = new Dictionary<char, int>();
        
        while(windowEnd<s.Length){
            char letter = s[windowEnd];
            if (!uniqueLetters.ContainsKey(letter)) {
                uniqueLetters[letter] = 1;
            } else {
                uniqueLetters[letter] += 1;
            }
            windowEnd += 1;
             
            if(uniqueLetters.Count > 2){
                char letterToRemove = s[windowStart];
                uniqueLetters[letterToRemove] -= 1;
                if(uniqueLetters[letterToRemove] == 0){
                   uniqueLetters.Remove(letterToRemove); 
                }
                windowStart += 1;
            }
            
            winodwSize = windowEnd - windowStart;
            longestSubstringLength = Math.Max(longestSubstringLength, winodwSize);

        }
        
        return longestSubstringLength;
    }
}