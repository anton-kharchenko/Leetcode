public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        var hs = new HashSet<char>();
        var start = 0;
        var end = 0;
        var result = 0;
        while (end < s.Length)
        {
            var letter = s[end];
            while (hs.Contains(letter))
            {
                var letterToDelete = s[start];
                start += 1;
                hs.Remove(letterToDelete);
            }

            hs.Add(letter);
            result = Math.Max(result, hs.Count);
            end += 1;
        }

        return result;
    }
}