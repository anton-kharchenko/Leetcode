public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        if(nums.Length == 1) return 1;
        
        var set = new HashSet<int>(nums);
        var longest = 0;
        foreach(var n in nums){
           
            if(!set.Contains(n - 1)){
                 var length = 0;
                 while(set.Contains(n + length)){
                     length++;
                 }
                 longest = Math.Max(longest, length);
            }
        }
        
        return longest;
    }
}