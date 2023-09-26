public class Solution {
    public string RemoveDuplicateLetters(string s) {
        var freq = new int[26];
        var stack = new Stack<char>();
        var hs = new HashSet<char>();
        
        for(var i = 0; i<s.Length; i++){
            freq[s[i] - 'a'] = i;
        }
        
        for(var i = 0; i<s.Length; i++){
            var currentChar = s[i];
            if(hs.Contains(currentChar)) continue;
            
            while(stack.Count> 0 && stack.Peek() > currentChar && freq[stack.Peek() - 'a'] > i){
                hs.Remove(stack.Pop());
            }
            
            stack.Push(currentChar);
            hs.Add(currentChar);
        }
        
        var arr = stack.ToArray();
        Array.Reverse(arr);
        return new string(arr);
        
    }
}

// cbacdcbc

// acdb