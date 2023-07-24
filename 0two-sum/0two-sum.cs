public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        
        for(var i = 0; i<nums.Length; i++){
            if(dict.ContainsKey(target - nums[i])){
                return new int[2]{i, dict[target - nums[i]]};
            }else if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i], i);
            }
        }
        
        return new int[2];
    } 
}
