
public class Solution
{

Dictionary<char, List<char>> letters = new   Dictionary<char, List<char>>();
    
    public IList<string> LetterCombinations(string digits) {
        if(digits.Length == 0) return new List<string>();
        
        InitDict();
        
        return GetLetterCombinations(digits);
    }
    
    private void InitDict()
    {
        letters.Add('1', new List<char>() { });
        letters.Add('2', new List<char>() { 'a', 'b', 'c' });
        letters.Add('3', new List<char>() { 'd', 'e', 'f' });
        letters.Add('4', new List<char>() { 'g', 'h', 'i' });
        letters.Add('5', new List<char>() { 'j', 'k', 'l' });
        letters.Add('6', new List<char>() { 'm', 'n', 'o' });
        letters.Add('7', new List<char>() { 'p', 'q', 'r', 's' });
        letters.Add('8', new List<char>() { 't', 'u', 'v' });
        letters.Add('9', new List<char>() { 'w', 'x', 'y', 'z' });
    }
    
    public List<string> GetLetterCombinations(string digit){
        if(digit.Length == 1){
            return new List<string>(letters[digit[0]].Select(i=>i.ToString()));
        }
        
        var combinations = GetLetterCombinations(digit.Substring(1));
        var res = new List<string>();
        
        foreach(var l in letters[digit[0]]){
            foreach(var com in combinations){
                res.Add(l + com);
            }
        }
        
        return res;
    }
    
}