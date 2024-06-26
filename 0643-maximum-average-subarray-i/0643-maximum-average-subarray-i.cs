public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double result = int.MinValue;
        var start = 0;
        var end = 0;
        var current = 0;
        var count = 0;
        while(end < nums.Length){
            current += nums[end];
            count += 1;
            if(count == k){
               result = Math.Max(result, (double)current / count);
               count -= 1;
               current -= nums[start];
               start += 1; 
            }
            end += 1;
        }

        return result;
    }
}