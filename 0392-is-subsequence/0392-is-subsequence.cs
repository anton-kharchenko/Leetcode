public class Solution {
 public bool IsSubsequence(string s, string t)
    {
        return Recursion(s, t, 0, 0, new Dictionary<string, bool>());
    }

    public bool Recursion(string s, string t, int indexS, int indexT, Dictionary<string, bool> cache)
    {
        if (t.Length == indexT && s.Length != indexS)
        {
            return false;
        }

        if (s.Length == indexS)
        {
            return true;
        }

        var key = indexT + "," + indexS;

        if (cache.ContainsKey(key))
        {
            return cache[key];
        }

        if (t[indexT] == s[indexS])
        {
            cache.TryAdd(key, Recursion(s, t, indexS + 1, indexT + 1, cache));
        }

        cache.TryAdd(key, Recursion(s, t, indexS, indexT + 1, cache));
        return cache[key];
    }
}