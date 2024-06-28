public class Solution
{
    public bool CanPartition(int[] nums)
    {
        var sum = nums.Sum();
        if (sum % 2 != 0) return false;
        sum /= 2;
        var lookup = new bool[nums.Length + 1, sum + 1];

        for (var i = 0; i <= nums.Length; i++)
        {
            for (var j = 0; j <= sum; j++) 
            {
                if (i == 0 || j == 0)
                    lookup[i, j] = false;
                else if (nums[i - 1] > j)
                    lookup[i, j] = lookup[i - 1, j]; // if curr sum value is greater than the current element value then just skip(take previous value)
                else if (nums[i - 1] == j)
                    lookup[i, j] = true; //  
                else
                    lookup[i, j] = lookup[i - 1, j] || lookup[i - 1, j - nums[i - 1]];
            }
        }

        return lookup[nums.Length, sum];
    }
}