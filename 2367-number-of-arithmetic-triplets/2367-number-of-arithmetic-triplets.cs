public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        var count = 0;
        
        var set = new HashSet<int>(nums);
        
        foreach(var i in nums){
            if(set.Contains(i+diff) && set.Contains(i+2*diff))
               count++;
        }
        
        return count;
    }
}