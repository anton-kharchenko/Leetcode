public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        var count = 0;
        var sum = 0;
        var map = new Dictionary<int, int> { { 0, 1 } };

        foreach (var number in nums)
        {
            sum += number;
            var rest = sum % k;
            if(rest < 0)   rest += k; // TODO
            
            if (map.TryAdd(rest, 1)) continue;
            count += map[rest];
            map[rest] += 1;
        }
        
        return count;
    }
}