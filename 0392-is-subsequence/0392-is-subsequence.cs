public class Solution {
    public bool IsSubsequence(string s, string t)
    {
        int[,] cache = new int[s.Length + 1, t.Length + 1];

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= t.Length; j++)
            {
                if (s[i - 1] == t[j - 1])
                {
                    cache[i, j] = cache[i - 1, j - 1] + 1;
                }
                else
                {
                    cache[i, j] = Math.Max(cache[i, j - 1],  cache[i - 1, j]);
                }
            }    
        }


        return cache[s.Length, t.Length] == s.Length ? true : false;
    }
}