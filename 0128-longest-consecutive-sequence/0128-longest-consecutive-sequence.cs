public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length is 0 or 1) return nums.Length;
        var longestConsecutive = 0;
        var uniqueNumbers = new HashSet<int>(nums);

        foreach (var currentNumber in nums)
        {
            if (uniqueNumbers.Contains(currentNumber - 1)) continue;
            var shiftCount = 0;
            while(uniqueNumbers.Contains(currentNumber + shiftCount)){
                shiftCount += 1;
                longestConsecutive = Math.Max(longestConsecutive, shiftCount);
            }
        }
        
        return longestConsecutive;
    }
}