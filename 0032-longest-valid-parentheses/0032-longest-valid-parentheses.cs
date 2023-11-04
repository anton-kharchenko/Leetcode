public class Solution {
    public int LongestValidParentheses(string s) {
        int n = s.Length;
        int maxLength = 0;
        Stack<int> stack = new Stack<int>();
        stack.Push(-1); 
        
        for (int i = 0; i < n; i++) {
            if (s[i] == '(') {
                stack.Push(i); 
            } else {
                stack.Pop(); 
                if (stack.Count == 0) { 
                    stack.Push(i); 
                } else {
                    maxLength = Math.Max(maxLength, i - stack.Peek()); 
                }
            }
        }
        
        return maxLength; 
    }
}