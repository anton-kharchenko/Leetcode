public class Solution {
    public int ThirdMax(int[] nums) {
        var hs = new SortedSet<int>();
        
        foreach(var n in nums){
            hs.Add(n);
        }
        
        if(hs.Count > 2) return hs.ElementAt(hs.Count - 3);
            
        return hs.Max();    
    }
}