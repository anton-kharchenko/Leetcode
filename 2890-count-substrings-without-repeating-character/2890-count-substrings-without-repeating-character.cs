public class Solution {
    public int NumberOfSpecialSubstrings(string s) {
        var fq = new Dictionary<char, int>();
        var start = 0;
        var end = 0;
        var result = 0;
        while (end < s.Length)
        {
            var current = s[end];
            
            fq.TryAdd(current, 0);
            fq[current] += 1;
            
            while (fq[current] > 1)
            {
                var nodeToDelete = s[start]; 
                fq[nodeToDelete] -= 1;
                start += 1;
            }
            
            result += end - start + 1;
            end += 1;
        }

        return result;
    }   
}