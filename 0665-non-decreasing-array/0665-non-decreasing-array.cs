public class Solution {

    public bool CheckPossibility(int[] nums) {
	var count = 0;
	for (var i = 1; i < nums.Length; i++) {
		if (nums[i - 1] <= nums[i]) continue;
		if (++count > 1) return false;
		if (i < 2 || nums[i - 2] <= nums[i]) nums[i - 1] = nums[i];
		else nums[i] = nums[i - 1];
	}
	return true;
    }
}