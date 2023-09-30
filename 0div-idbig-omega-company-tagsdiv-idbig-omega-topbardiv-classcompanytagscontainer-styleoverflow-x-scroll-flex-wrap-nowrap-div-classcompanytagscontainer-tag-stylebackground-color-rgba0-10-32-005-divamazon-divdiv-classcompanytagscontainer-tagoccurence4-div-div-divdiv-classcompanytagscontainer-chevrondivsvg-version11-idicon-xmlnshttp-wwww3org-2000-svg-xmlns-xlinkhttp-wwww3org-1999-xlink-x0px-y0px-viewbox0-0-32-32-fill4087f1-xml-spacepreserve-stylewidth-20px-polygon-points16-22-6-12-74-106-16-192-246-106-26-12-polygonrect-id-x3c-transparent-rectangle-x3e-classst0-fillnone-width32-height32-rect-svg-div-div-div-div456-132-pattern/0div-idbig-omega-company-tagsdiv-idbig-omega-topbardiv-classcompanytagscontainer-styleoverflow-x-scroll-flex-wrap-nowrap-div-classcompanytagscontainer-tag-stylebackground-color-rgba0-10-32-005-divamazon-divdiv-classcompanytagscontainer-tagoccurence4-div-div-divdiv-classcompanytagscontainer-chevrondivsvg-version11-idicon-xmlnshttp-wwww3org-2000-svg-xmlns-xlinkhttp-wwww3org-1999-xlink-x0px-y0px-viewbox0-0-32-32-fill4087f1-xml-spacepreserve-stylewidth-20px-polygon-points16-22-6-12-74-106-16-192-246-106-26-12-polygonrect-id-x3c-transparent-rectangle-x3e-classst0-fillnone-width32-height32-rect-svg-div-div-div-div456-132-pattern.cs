public class Solution {
    public bool Find132pattern(int[] nums) {
        Stack<int> stack = new Stack<int>();
        int midVal = int.MinValue;
        for(var i = nums.Length - 1; i>= 0; i--){
            
            if(midVal > nums[i])
                return true;
            
            while(stack.Count> 0 && nums[i]>stack.Peek())
                midVal = Math.Max(midVal, stack.Pop());
            
            stack.Push(nums[i]);
        }
        return false;
    }
}