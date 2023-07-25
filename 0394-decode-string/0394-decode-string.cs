using System.Text;

public class Solution
{
    public string DecodeString(string s)
    {
        var stack = new Stack<char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == ']')
            {
                var currSb = new StringBuilder();
                while (stack.Peek() != '[')
                {
                    currSb.Insert(0, stack.Pop());
                }
                
                stack.Pop();
                
                var currDigit = new StringBuilder();
                while (stack.Count > 0 && char.IsNumber(stack.Peek()))
                {
                    currDigit.Insert(0, stack.Pop());
                }
                
                var digit = int.Parse(currDigit.ToString());
                var stringToInsert = currSb.ToString();
                var decodeSb = new StringBuilder();
                for (var j = 0; j < digit; j++)
                {
                    decodeSb.Append(stringToInsert);
                }
                
                var decodeString = decodeSb.ToString();
                foreach (var ch in decodeString)
                {
                    stack.Push(ch);
                }
            }
            else
            {
                stack.Push(s[i]);                
            }
        }
        
        var ans = new StringBuilder();
        while (stack.Count > 0)
        {
            ans.Insert(0, stack.Pop());
        }
        return ans.ToString();
        
    }

}