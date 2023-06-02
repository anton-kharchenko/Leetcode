public class Solution {
    public int FindKthLargest(int[] nums, int k)
    {
       return nums.OrderBy(x=>x).ToArray()[^k];
    }
}