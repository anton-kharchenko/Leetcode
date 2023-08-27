public class Solution {
    public int NumberOfSubarrays(int[] nums, int k)
    {
        var count = 0;
        var sum = 0;
        var dictionary = new Dictionary<int, int>();

        for (var index = 0; index < nums.Length; index++)
        {
            if ( nums[index] % 2 != 0)
                nums[index] = 1;
            else
                nums[index] = 0;
        }
        
        foreach (var number in nums)
        {
            sum += number;
            
            if (sum == k)
                count++;
            if (dictionary.Count != 0 && dictionary.ContainsKey(sum - k))
                count += dictionary[sum - k];

            if (dictionary.ContainsKey(sum))
                dictionary[sum]++;
            else
                dictionary.Add(sum, 1);
        }

        return count;
    }
}