public class Solution {
    public int MaxProduct(int[] nums) {
        Array.Sort(nums); // O(log n) 
        return (nums[^1] - 1) * (nums[^2] - 1);
    }
}

// [2,3,4,5]  (4-1) * (5-1) = 12