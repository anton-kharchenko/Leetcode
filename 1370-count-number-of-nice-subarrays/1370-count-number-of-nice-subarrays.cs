public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        var numberOfSubarrays = 0;
        var map = new Dictionary<int, int>();
        var numbers = new int[nums.Length];
        var index = 0;
        var sum = 0;
        
        foreach(var number in nums){
            if(number % 2 == 0)
                numbers[index] = 0;
            else
                numbers[index] = 1;
            
            index += 1;
        }

        foreach(var number in numbers){
            sum += number;
            if(sum == k) numberOfSubarrays += 1;
            if(map.ContainsKey(sum - k)) numberOfSubarrays += map[sum - k];
            
            map.TryAdd(sum, 0);
            map[sum] += 1;
        }

        return numberOfSubarrays;
    }
}