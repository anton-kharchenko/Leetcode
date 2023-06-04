public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var ans = new int[temperatures.Length];
        var stack = new Stack<int[]>();
        
        
        for(var i =0; i<temperatures.Length; i++){
            while(stack.Count>0 && stack.Peek()[0]<temperatures[i]){
                ans[stack.Peek()[1]] = i - stack.Peek()[1];
                stack.Pop();
            }
            stack.Push(new int[]{temperatures[i], i});
        }
        return ans;
    }
}