public class Solution {
    public int MaxSubArray(int[] nums) {
	int sum = 0;
	int maxSum = nums[0];
        foreach(var n in nums){
            sum = Math.Max(0, sum);
            sum += n;
            maxSum = Math.Max(maxSum, sum);
        }
    return maxSum;
    }
}