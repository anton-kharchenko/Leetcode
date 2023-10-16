public class Solution {
public bool BackspaceCompare(string s, string t) {
        return (Stack(s) == Stack(t)) ? true : false;        
}
public static string Stack(string Str)
{
    Stack<string> stk = new Stack<string>(); 
    foreach (var x in Str.ToCharArray())
    {
        if (x.ToString() != "#")
            stk.Push(x.ToString());
        else 
            if (stk.Count>0)
                stk.Pop();
    }
    return String.Join("", stk);
}
}