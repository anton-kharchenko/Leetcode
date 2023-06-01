public class Solution {
    public int FirstUniqChar(string s) {
               var dic = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
            {
                dic[s[i]] += 1;
            }
            else
            {
                dic.Add(s[i], 1);
            }
        }

        var c = dic.FirstOrDefault(l => l.Value == 1);


        return s.IndexOf(c.Key); 
    }
}