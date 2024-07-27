public class Solution {
    public int CountGoodSubstrings(string s) {
        var hs = new HashSet<int>();
        var start = 0;
        var end = 0;
        var result = 0;
        while (end < s.Length)
        {
            var letter = s[end];
            while (hs.Contains(letter) && start < end)
            {
                var last = s[start];
                hs.Remove(last);
                start += 1;
            }
            
            hs.Add(letter);
            if (hs.Count >= 3)
            {
                result += 1;
            }

            end += 1;
        }

        return result;
    }
}