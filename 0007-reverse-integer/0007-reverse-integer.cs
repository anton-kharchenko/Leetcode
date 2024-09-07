public class Solution {
    public int Reverse(int x) {
        var isNeg = x <= 0;
        var stack = new Stack<long>();
        long result = 0;
        if(isNeg) x *= -1;
        var number = x;
        while (number > 0)
        {
            var rest = number / 10;
            var digit = number % 10;
            stack.Push(digit);
            number = rest;
        }
        
        long kof = 1;
        while (stack.Count > 0)
        {
            result += stack.Pop() * kof;
            kof *= 10;
        }

        if (result >= int.MaxValue) return 0;
        if (isNeg) result *= -1;
        return (int)result;
    }
}