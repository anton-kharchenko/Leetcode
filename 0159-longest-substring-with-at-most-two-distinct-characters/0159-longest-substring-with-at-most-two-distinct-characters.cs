public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        int windowStart = 0;
        int windowEnd = 0;
        int windowSize = 0;
        int longestSubstingLength = 0;
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        while(windowEnd < s.Length){
            char letter = s[windowEnd];
            if(dictionary.ContainsKey(letter)){
                dictionary[letter] += 1;
            }else{
                dictionary.Add(letter, 1);
            }
            windowEnd += 1;
            
            if(dictionary.Count > 2){
                char letterToRemove = s[windowStart];
                dictionary[letterToRemove] -= 1;
                if(dictionary[letterToRemove]<=0){
                    dictionary.Remove(letterToRemove);
                }
                windowStart += 1;
            }
            
            windowSize =  windowEnd - windowStart;
            longestSubstingLength = Math.Max(longestSubstingLength, windowSize);
        }
        
        return longestSubstingLength;
    }
}