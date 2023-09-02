public class Solution {
    public string RemoveDuplicates(string s, int k) {
        var stack = new Stack<(char ch, int count)>();
        
        foreach(var c in s){
            if(!stack.Any() || stack.Peek().ch != c){
                stack.Push((c, 1));
            }else{
                var (ch, count) = stack.Pop();
                if(count + 1 != k)
                    stack.Push((ch, count + 1));
            } 
        }
        
        
        return string.Concat(stack.Select(i=>new string(i.ch, i.count)).Reverse());
    }
}
