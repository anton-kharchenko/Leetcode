public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        int windowStart = 0;
        int windowEnd = 0;
        int maxLetterCount = 0;
        int maxSubstringCount = 0;
        
        while(windowEnd<s.Length){
            char letter = s[windowEnd];
            if(dictionary.ContainsKey(letter)){
                dictionary[letter] += 1;
            }else{
                dictionary.Add(letter, 1);
            }
            
            windowEnd += 1;
            
            maxLetterCount = Math.Max(maxLetterCount, dictionary[letter]);
            
            if(windowEnd - windowStart - maxLetterCount > k ){
                char letterToDelete = s[windowStart];
                dictionary[letterToDelete] -= 1;
                windowStart += 1;
            }
            
            maxSubstringCount = Math.Max(maxSubstringCount, windowEnd - windowStart);
        }
        
        return maxSubstringCount;
    }
}