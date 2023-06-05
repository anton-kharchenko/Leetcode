public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        int sum = 0;
        map.Add(0, -1);
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            if (k != 0)
                sum %= k;
            if (!map.ContainsKey(sum))
                map.Add(sum, i);
            else if (i > map[sum] + 1)
                return true;
        }
        
        return false;
            
    }
    
}