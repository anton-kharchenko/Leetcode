public class Solution {
    public string RemoveDuplicateLetters(string s) {
        var freq = new int[26];
        var used = new int[26]; 
        var res = new List<char>(); 

        foreach(var ch in s)
            freq[ch-'a']++;
             
        foreach(char ch in s){
            freq[ch - 'a']--;
            if(used[ch -'a']++ > 0) continue;
            // res not empty && ch < front char && front char shows behand
            while (res.Count != 0 && res[res.Count - 1] > ch && freq[res[res.Count - 1] - 'a'] > 0){
                used[res[res.Count - 1] - 'a'] = 0;
                res.RemoveAt(res.Count - 1);
            }
            res.Add(ch);
        }        
        return new String(res.ToArray());
    }
}