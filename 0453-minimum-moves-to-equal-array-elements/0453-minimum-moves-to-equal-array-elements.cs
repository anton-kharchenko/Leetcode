public class Solution {
    public int MinMoves(int[] nums) {
    var min = nums.Min();
	return nums.Select(x => x - min).Sum();
    }
}