public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        if(nums == null || nums.Length < k)
            return 0;
        
        Array.Sort(nums);
        var l = 0;
        var r = 0;
        var res = int.MaxValue;
        
        while(r<nums.Length){
            if(r-l+1==k){
                res = Math.Min(res, nums[r] - nums[l]);
                l++;
            }
            r++;
            
        }
        
        return res;
    }
}