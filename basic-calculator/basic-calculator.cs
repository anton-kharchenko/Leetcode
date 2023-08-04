public class Solution {
    public int Calculate(string s) {
        if(s == null || s.Length == 0)
            return 0;
        
        int sum = 0, sign = 1, num;
        var stack = new Stack<int>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(char.IsDigit(s[i]))
            {
                num = int.Parse(s[i].ToString());
                
                while(i + 1 < s.Length && char.IsDigit(s[i + 1]))
                {
                    num = 10 * num + int.Parse(s[i + 1].ToString());
                    i++;
                }
                
                // add the num to the sum
                sum += sign * num;
            }
            else switch (s[i])
            {
                case '+':
                    sign = 1;
                    break;
                case '-':
                    sign = -1;
                    break;
                case '(':
                    // push the previous sum and sign the to stack before executing the priority opeations
                    stack.Push(sum);
                    stack.Push(sign);
                    // reset the sum and sign
                    sum = 0;
                    sign = 1;
                    break;
                case ')':
                    // use current sum and sign to do operations with preivous sum
                    sum *= stack.Pop();
                    sum += stack.Pop();
                    break;
            }
        }
        return sum;
    }
}