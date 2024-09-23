public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for(var i = 0; i<nums.Length; i++){
            if(dict.ContainsKey(target - nums[i])){
                return new int[2]{dict[target - nums[i]], i};
            }else{
                dict.TryAdd(nums[i], i);
                dict[nums[i]] = i;
            }
        }
        return new int[2];
    }
}