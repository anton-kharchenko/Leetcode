public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length is 0 or 1) return nums.Length;
        var result = 0;
        var uniqueNumber = new HashSet<int>(nums);
        foreach(var num in nums){
            if(uniqueNumber.Contains(num - 1)) continue;
            var shiftCount = 0;
            while(uniqueNumber.Contains(num + shiftCount)){
                shiftCount += 1;
                result = Math.Max(result, shiftCount);
            }
        }
        return result;
    }
}