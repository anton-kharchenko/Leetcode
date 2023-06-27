public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var n = nums.Length;
        var sum = 0;
        var count = 0;
        var dict = new Dictionary<int, int>();
        dict[0] = 1;
        
        for(var i = 0;i<n; i++){
            sum +=  nums[i];
            var toRemove = sum - k;
            
            count += dict.ContainsKey(toRemove) ? dict[toRemove] : 0;
            
            if(dict.ContainsKey(sum)){
                dict[sum] += 1;
            }else{
                 dict.Add(sum, 1);
            }
        }
        
        return count;

    }
}