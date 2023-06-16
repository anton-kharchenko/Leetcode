public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<string>();
        var res = 0;
        var l = new List<string>{
          "+", "-", "/", "*"  
        };
        
        for(var i = 0; i<tokens.Length; i++){
            if(!l.Contains(tokens[i])){
                stack.Push(tokens[i]);
            }else{
                var sign = tokens[i];
                var secondNumber = stack.Pop();
                var firstNumber = stack.Pop();
                var num = 0;
                if(sign == "+"){
                    num = Convert.ToInt32(firstNumber) + Convert.ToInt32(secondNumber); 
                }
                if(sign == "-"){
                    num = Convert.ToInt32(firstNumber) - Convert.ToInt32(secondNumber); 
                }
                if(sign == "/"){
                    num = Convert.ToInt32(firstNumber) / Convert.ToInt32(secondNumber); 
                }
                if(sign == "*"){
                    num = Convert.ToInt32(firstNumber) * Convert.ToInt32(secondNumber); 
                }
                
                stack.Push(num.ToString());
            }
        }
        res = Convert.ToInt32(stack.Pop());
        return res;
    }
}