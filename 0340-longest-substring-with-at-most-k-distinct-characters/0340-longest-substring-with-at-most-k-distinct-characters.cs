public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        var dict = new Dictionary<char, int>();
        var result = 0;
        var start = 0;
        var end = 0;
        while(end < s.Length){
            dict.TryAdd(s[end], 0);
            dict[s[end]] += 1;
            while(dict.Count > k){
                var symbToRemove = s[start];
                if(dict.ContainsKey(symbToRemove)){
                    dict[symbToRemove] -= 1;
                    if(dict[symbToRemove] <= 0){
                        dict.Remove(symbToRemove);
                    }
                }
                start += 1;
            }
            result = Math.Max(result, end - start + 1);
            end += 1;
        }
        return  result;
    }
}