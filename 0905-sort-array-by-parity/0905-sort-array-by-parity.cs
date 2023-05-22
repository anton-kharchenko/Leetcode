public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        return nums.OrderBy(i=>i%2!=0).ToArray();
    }
}