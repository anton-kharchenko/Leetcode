public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        var count = 0;
        var sum = 0;
        dict.Add(0, 1);
        for(var i = 0; i<nums.Length; i++){
             sum += nums[i];
             var diff = sum - k;
             count += dict.ContainsKey(diff) ? dict[diff] : 0;
            
             if(dict.ContainsKey(sum)){
                dict[sum]++;
             }else{
                 dict.Add(sum, 1);
             }
            
        }
        return count;
    }
}