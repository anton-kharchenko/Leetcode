public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var map = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                if (map[s[i]] != t[i])
                    return false;
            }
            else if (map.ContainsValue(t[i])) 
            {
                 return false;
            }

            map.TryAdd(s[i], t[i]);
        }

        return true;
    }
}