using System.Text.RegularExpressions;

public class Solution {
    public int MyAtoi(string s) {
      if (s == null || s.Length == 0) {
        return 0;
      }
    
    var regex = new Regex(@"^[\+\-]?\d+");
    var match = regex.Match(s.Trim());
    
    if (match.Success) {
        
        if(!int.TryParse(match.Value, out Int32 result)){
                if(match.Value[0] == '-')
                    return int.MinValue;
                else
                   return int.MaxValue;
        }else{
            return result;
        }
        
    } else {
        return 0;
    }
    }
}