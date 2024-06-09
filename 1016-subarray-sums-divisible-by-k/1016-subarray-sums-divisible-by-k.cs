public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        var count = 0;
        var sum = 0;
        var map = new Dictionary<int, int>();
        var length = nums.Length;
        map.Add(0, 1);
        for(var i = 0; i<length; i++){
            sum += nums[i];
            var rest = sum % k;
            if(rest < 0){
                rest += k; // TODO
            }

            if(map.ContainsKey(rest)){
                count += map[rest];
                map[rest] += 1;
            }else{
                map[rest] = 1;
            }
        }

        return count;
    }
}