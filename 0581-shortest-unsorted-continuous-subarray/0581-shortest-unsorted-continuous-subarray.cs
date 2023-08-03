public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int n = nums.Length;
        if (n <= 1)
            return 0;

        // Find the index where ascending order breaks from the left
        int left = 0;
        while (left < n - 1 && nums[left] <= nums[left + 1])
            left++;

        // If the array is already sorted in non-decreasing order
        if (left == n - 1)
            return 0;

        // Find the index where descending order breaks from the right
        int right = n - 1;
        while (right > 0 && nums[right] >= nums[right - 1])
            right--;

        // Find the minimum and maximum elements within the subarray
        int subarray_min = int.MaxValue;
        int subarray_max = int.MinValue;
        for (int i = left; i <= right; i++)
        {
            subarray_min = Math.Min(subarray_min, nums[i]);
            subarray_max = Math.Max(subarray_max, nums[i]);
        }

        // Find the correct positions for the minimum and maximum elements
        while (left > 0 && nums[left - 1] > subarray_min)
            left--;
        while (right < n - 1 && nums[right + 1] < subarray_max)
            right++;

        return right - left + 1;
    }
}