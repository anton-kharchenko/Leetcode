public class Solution {
    public int Reverse(int x) {
        var length = x.ToString().Length;
        var isNeg = x < 0;
        
        var stack = new Stack<char>();
        
        var res = "";
        
        if(isNeg){
            x *= -1;
            length -= 1;
        }
        
        for(var i = 0; i<length; i++){
            stack.Push(x.ToString()[i]);
        }
        
        while(stack.Count>0){
            res += stack.Pop();
        }
        
        if(Int32.TryParse(res, out var r)){
            if(isNeg){
                r *= - 1;
                return r;
            }
            
            return r;
        }
        
        
        return 0;
    }
}