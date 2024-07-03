public class Solution {
    public int MinDifference(int[] nums) {
        if(nums.Length <= 4) return 0;
        Array.Sort(nums);
        int minDiff = Int32.MaxValue;
        var left = 0;
        var right = nums.Length - 4;
        while (left < 4)
        {
            minDiff = Math.Min(minDiff, nums[right] - nums[left]);
            left += 1;
            right += 1;
        }
        return minDiff;
    }
}