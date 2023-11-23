public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 0;
        Stack<int> stack = new Stack<int>();
        List<int> result = new List<int>();
         
        for(int i = digits.Length - 1; i>= 0; i--){
            int digit = digits[i];
            if(i == digits.Length - 1){
                digit += 1;
            }
            digit += carry;
            stack.Push(digit%10);
            carry = digit / 10;
        }
        
        if(carry == 1){
            stack.Push(1);
        }
        
        foreach(int num in stack){
            result.Add(num);
        }
        
        return result.ToArray();
    }
}