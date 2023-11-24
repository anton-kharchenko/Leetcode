public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        int result = 0;
        int max = 0;
        int start = 0;
        int end = 0;
        
        while(end<s.Length){
            char letter = s[end];
            
            if(dictionary.ContainsKey(letter)){
                dictionary[letter] += 1;
            }else{
                dictionary.Add(letter, 1);
            }
            end += 1;
            
            max = Math.Max(max, dictionary[letter]);
            
            if(end - start - max > k ){
                char letterToDelete = s[start];
                dictionary[letterToDelete] -= 1;
                start += 1;
            }
            
            result = Math.Max(result, end - start);
        }
        
        
        return result;
    }
}