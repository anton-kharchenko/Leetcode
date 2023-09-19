public class Solution {
    List<string> result = new List<string>();
    char[] ans;
    
    public IList<string> LetterCasePermutation(string s)
    {
        ans = new char[s.Length];
        Dfs(0, s);
        return result;
    }
    
    public void Dfs(int index, string s){
        if(index == s.Length){
            var x = string.Concat(ans);
            ans.ToList();
            result.Add(x);
            return;
        }
        
        if(char.IsDigit(s[index])){
            ans[index] = s[index];
            Dfs(index + 1, s);
        }else{
            ans[index] = s[index].ToString().ToUpper()[0];
            Dfs(index + 1, s);
            ans[index] = s[index].ToString().ToLower()[0];
            Dfs(index + 1, s);
        }
    }
}