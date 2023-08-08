public class Solution {
    public int Jump(int[] nums) {
        int ans = 0, curr = 0, next = 0;

        for(int i = 0; i < nums.Length - 1; i++) {  
            next = Math.Max(next, i + nums[i]);

            if (i == curr) {
                ans++;
                curr = next;
            }
        }   

        return ans;
        
    }
}