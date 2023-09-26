public class Solution {
    public string RemoveDuplicateLetters(string s) {
        var freq = new int[26];
        var visited = new HashSet<char>();
        var stack = new Stack<char>();
        
        for(var i = 0; i<s.Length; i++){
            freq[s[i] - 'a'] = i;
        }
        
        for(var i = 0; i<s.Length; i++){
            var currentChar = s[i];
            if(visited.Contains(currentChar))continue;
        
            while(stack.Count> 0 && stack.Peek() > currentChar && freq[stack.Peek() - 'a'] > i ){
               var el = stack.Pop();
                visited.Remove(el);
            }
            
            stack.Push(currentChar);
            visited.Add(currentChar);
        }
        
        var arr = stack.ToArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}