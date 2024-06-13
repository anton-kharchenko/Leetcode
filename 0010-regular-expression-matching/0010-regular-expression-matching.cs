public class Solution
{
    public bool IsMatch(string s, string p)
    {
        int sLen = s.Length, pLen = p.Length;
        Dictionary<string,bool> cache = new Dictionary<string,bool>();
        return DFS(0,0);
        bool DFS(int i, int j)
        {
            if(j==pLen) return i==sLen;
            
            var key = i+","+j;
            if(cache.ContainsKey(key)) return cache[key];
            
            bool currCharMatch = i<sLen && (s[i]==p[j] || p[j]=='.');
            if(j+1<pLen && p[j+1]=='*')
                return cache[key] = DFS(i,j+2) || (currCharMatch && DFS(i+1,j));

            else
                return cache[key] = currCharMatch && DFS(i+1,j+1);
        
            return cache[key] = false;
        }
    }
}