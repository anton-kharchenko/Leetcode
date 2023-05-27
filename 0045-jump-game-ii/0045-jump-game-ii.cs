public class Solution {
    public int Jump(int[] nums) {
        int ans = 0, currEnd = 0, currFar = 0;

        for(int i = 0; i < nums.Length - 1; i++) {  
            currFar = Math.Max(currFar, i + nums[i]);

            if (i == currEnd) {
                ans++;
                currEnd = currFar;
            }
        }   

        return ans;
        
    }
}