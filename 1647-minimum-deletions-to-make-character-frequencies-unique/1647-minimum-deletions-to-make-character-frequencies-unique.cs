public class Solution {
    public int MinDeletions(string s) {
        var deleted = 0; // 2
        var hs = new HashSet<int>(); // [3, 2,  1]
        // aaabbbcc
        foreach(var group in s.GroupBy(i=>i)){
            var count = group.Count(); // cc - 2
            while(count > 0 && hs.Add(count) == false){
                deleted++;
                count--;
            }
            
        }
        
        return deleted; // 2
    }
}