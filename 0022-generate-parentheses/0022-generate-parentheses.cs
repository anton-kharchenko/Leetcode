public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        AddParenthesis(result, 0, 0, "", n);
        return result;
    }
    
    void AddParenthesis(List<string> result, int open, int close, string parenthesis, int max){
        if(max * 2 == open + close){
            result.Add(parenthesis);
            return;
        }
        
        if(open < max){
            AddParenthesis(result, open + 1, close, parenthesis + "(", max);
        }
        if(close < open){
            AddParenthesis(result, open, close + 1, parenthesis + ")", max);
        }
    }
}