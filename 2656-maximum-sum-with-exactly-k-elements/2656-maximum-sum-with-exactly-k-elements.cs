public class Solution {
    public int MaximizeSum(int[] nums, int k) {
        var res = 0;
        
        var max = nums.Max();
        var allNumbers = new List<int>();
        
        
        for(var i = 0; i<k; i++){
            allNumbers.Add(max + i);
            res += allNumbers[i];  
        }
        
        return res;
    }
}