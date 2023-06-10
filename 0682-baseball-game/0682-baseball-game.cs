public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();
        
        foreach(var operation in operations){
            if(operation == "+" && stack.Count >0){
                var first = stack.Pop();
                var second = stack.Peek();
                var total = first + second;
                stack.Push(first);
                stack.Push(total);
            } else if(operation == "D" && stack.Count >0){
               var d =  stack.Peek();
                var number = d*2;
                stack.Push(number);
            } else if(operation == "C" && stack.Count >0){
                stack.Pop();
            }else{
                var number = Convert.ToInt32(operation);
                stack.Push(number);
            }
        }
        
        return stack.Sum();
    }
}