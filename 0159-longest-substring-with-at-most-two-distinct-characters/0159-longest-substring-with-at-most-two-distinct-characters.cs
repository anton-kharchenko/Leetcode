public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        int windowStart = 0;
        int windowEnd = 0;
        int windowSize = 0;
        int longestSubstringLength = 0;
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        
        while(windowEnd<s.Length){ // O(N), O(1)
            char letter = s[windowEnd];
            if(dictionary.ContainsKey(letter)){
                dictionary[letter] += 1;
            }else{
                dictionary.Add(letter, 1);
            }
            windowEnd += 1;
            
            if(dictionary.Count > 2){
                char letterToDelete = s[windowStart];
                dictionary[letterToDelete] -= 1;
                if(dictionary[letterToDelete] == 0){
                    dictionary.Remove(letterToDelete);
                }
                windowStart += 1;
            }
            
            windowSize =  windowEnd - windowStart;
            longestSubstringLength = Math.Max(longestSubstringLength, windowSize);
        }
        
        return longestSubstringLength;
    }
}