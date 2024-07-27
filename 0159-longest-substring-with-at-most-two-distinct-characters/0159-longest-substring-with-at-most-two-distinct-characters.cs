public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        var hs = new Dictionary<char, int>();
        var start = 0;
        var end = 0;
        var result = 0;
        while (end < s.Length)
        {
            hs.TryAdd(s[end], 0);
            hs[s[end]] += 1;
            
            while (hs.Count > 2)
            {
                var letterToDelete = s[start];
                start += 1;
                hs[letterToDelete] -= 1;
                if(hs[letterToDelete] == 0)
                    hs.Remove(letterToDelete);
            }
            
            result = Math.Max(result, end - start + 1);
            end += 1;
        }

        return result;
    }
}