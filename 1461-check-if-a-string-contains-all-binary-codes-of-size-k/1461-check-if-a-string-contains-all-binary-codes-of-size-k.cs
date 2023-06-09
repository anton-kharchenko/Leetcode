public class Solution {
    public bool HasAllCodes(string s, int k) {
        var set = new HashSet<string>();
        var target = (int)Math.Pow(2, k);
        var count = 0;
        for(var i = 0;i<=s.Length - k; i++){
            var subStr = s.Substring(i, k);
            if(!set.Contains(subStr)){
                set.Add(subStr);
                count++;
            }
        }
        
        return count == target;
    }
}