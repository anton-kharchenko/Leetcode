public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var length = temperatures.Length;
        var answers = new int[length];
        var stack = new Stack<int[]>();
        
        for(var i = 0; i<length; i++){
            var currentTemperature =  temperatures[i];
            
            while(stack.Count > 0 && stack.Peek()[0]<currentTemperature){
                var index  = stack.Pop()[1];
                answers[index] = i - index;
            }
            
            stack.Push(new int[2]{currentTemperature, i});
        }
        
        return answers;
    }
}
