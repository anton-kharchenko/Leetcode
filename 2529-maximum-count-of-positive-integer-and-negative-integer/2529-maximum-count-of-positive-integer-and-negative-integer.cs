public class Solution {
    public int MaximumCount(int[] nums) {
        return Math.Max(nums.Count(number=>number>0), nums.Count(number=>number<0));
    }
}