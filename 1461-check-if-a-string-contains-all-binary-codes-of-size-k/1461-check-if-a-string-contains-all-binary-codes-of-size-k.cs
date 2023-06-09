public class Solution {
    public bool HasAllCodes(string s, int k) {
        var set = new HashSet<string>();
        var count = 0;
        var target = Math.Pow(2, k);
        
        for(var i = 0; i<= s.Length - k; i++){
            var subString = s.Substring(i, k);
            if(!set.Contains(subString)){
                set.Add(subString);
                count++;
            }
        }
        
        
        return count == target;
    }
}