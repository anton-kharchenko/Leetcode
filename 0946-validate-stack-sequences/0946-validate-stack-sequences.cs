public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        var stack = new Stack<int>();
        var index = 0;
        for(var i = 0; i<pushed.Length; i++){
            stack.Push(pushed[i]);
            while(index<popped.Length&&stack.Count>0&&popped[index] == stack.Peek()){
                stack.Pop();
                index++;
            }
        }
        
        return stack.Count == 0;
    }
}