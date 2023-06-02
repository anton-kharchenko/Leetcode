public class Solution {
    public int FindKthLargest(int[] nums, int k)
    {
        Array.Sort(nums);
        if (nums.Length - k >= 0)
        {
            return nums[nums.Length - k];
        }
        return -1;
    }
}