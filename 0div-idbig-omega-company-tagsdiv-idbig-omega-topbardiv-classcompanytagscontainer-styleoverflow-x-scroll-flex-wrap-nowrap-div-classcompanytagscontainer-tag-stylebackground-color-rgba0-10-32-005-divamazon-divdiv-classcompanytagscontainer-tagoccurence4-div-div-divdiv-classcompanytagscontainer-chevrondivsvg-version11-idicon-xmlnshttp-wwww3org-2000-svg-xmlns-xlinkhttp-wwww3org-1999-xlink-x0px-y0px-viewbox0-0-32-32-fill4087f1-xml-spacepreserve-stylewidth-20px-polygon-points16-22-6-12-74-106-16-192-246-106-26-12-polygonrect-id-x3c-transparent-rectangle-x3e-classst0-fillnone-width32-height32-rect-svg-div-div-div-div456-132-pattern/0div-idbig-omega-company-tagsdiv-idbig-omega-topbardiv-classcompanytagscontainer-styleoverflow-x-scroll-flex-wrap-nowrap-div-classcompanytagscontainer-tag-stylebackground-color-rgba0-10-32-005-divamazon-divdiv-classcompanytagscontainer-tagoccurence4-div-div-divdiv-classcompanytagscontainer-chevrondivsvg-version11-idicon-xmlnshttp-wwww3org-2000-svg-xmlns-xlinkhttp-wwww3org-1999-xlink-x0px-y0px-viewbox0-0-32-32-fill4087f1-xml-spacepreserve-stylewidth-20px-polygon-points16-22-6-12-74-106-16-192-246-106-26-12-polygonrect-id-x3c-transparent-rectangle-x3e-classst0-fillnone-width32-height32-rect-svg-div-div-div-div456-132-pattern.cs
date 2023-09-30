public class Solution {
    public bool Find132pattern(int[] nums) {
        Stack<int> stack = new Stack<int>();
        var temp = int.MinValue;
        for(var i = nums.Length - 1; i>= 0; i--){
            if(temp > nums[i])
                return true;
            
            while(stack.Count> 0 && stack.Peek()<nums[i])
                temp = Math.Max(temp, stack.Pop());
            
            stack.Push(nums[i]);
        }
        
        return false;
    }
}