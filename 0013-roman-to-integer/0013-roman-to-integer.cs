public class Solution {
    public int RomanToInt(string s) {
        if (s == null || s == string.Empty)
            return 0;
        
        var dic = new Dictionary<char, int>();
        var res = 0;
        
         dic.Add('I', 1);
         dic.Add('V', 5);
         dic.Add('X', 10);
         dic.Add('L', 50);
         dic.Add('C', 100);
         dic.Add('D', 500);
         dic.Add('M', 1000);
        
        
        for(var i = 0; i<s.Length; i++){
            if(i+1<s.Length && dic[s[i]] < dic[s[i+1]]){
                res -= dic[s[i]];
            }else{
                res += dic[s[i]];
            }
             
        }
        
        return res;
    }
}