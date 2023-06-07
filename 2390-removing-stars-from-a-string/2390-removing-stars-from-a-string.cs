public class Solution {
    public string RemoveStars(string s) {
        var stack = new Stack<char>();
        
        foreach(var i in s){
            if(i!= '*'){
                stack.Push(i);
            }else{
                stack.Pop();
            }
        }
        
        var res = string.Empty;
        
        while(stack.Count >0){
            res += stack.Pop();
        }
        
        return string.Concat(res.Reverse());
    }
}