public class Solution {
    public int LongestOnes(int[] nums, int k) {
        var start = 0;
        var end = 0;
        var maxWindow = 0;
        var currentWindow = 0;
        var limit = 0;
        while(end < nums.Length){
            var number = nums[end];
            if(number == 0){
                limit += 1;
            }
            while(limit > k){
                var last = nums[start];
                if(last == 0){
                    limit -= 1;
                }
                start += 1;
            }

            currentWindow = end - start + 1;
            maxWindow = Math.Max(currentWindow, maxWindow);
            end += 1;
        }

        return maxWindow;
    }
}