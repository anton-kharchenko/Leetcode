public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var answers = new int[temperatures.Length];
        var stack = new Stack<int[]>();
        
        for(var i = 0; i<temperatures.Length; i++){
            var currentTemperature = temperatures[i];
            
            while(stack.Count>0 && stack.Peek()[0] <currentTemperature){
               var lastPeekIndex = stack.Pop()[1];
               answers[lastPeekIndex]  = i - lastPeekIndex;
            }
            
            stack.Push(new int[2]{currentTemperature, i});
        }
        
        return answers;
    }
}