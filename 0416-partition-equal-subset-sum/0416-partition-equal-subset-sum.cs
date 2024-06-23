public class Solution
{
    private bool[,] lookup;
    public bool CanPartition(int[] nums)
    {
        int sum = 0;
        foreach (var number in nums)
            sum += number;
        if (sum % 2 != 0) return false;
        sum /= 2;
        lookup = new bool[nums.Length + 1, sum + 1];

        for (int i = 0; i <= nums.Length; i++)
        {
            for (int j = 0; j <= sum; j++)
            {
                if (i == 0 || j == 0)
                {
                    lookup[i, j] = false;
                }else if (nums[i - 1] > j)
                {
                    lookup[i, j] = lookup[i - 1, j];
                }else if (nums[i - 1] == j)
                {
                    lookup[i, j] = true;
                }
                else
                {
                    lookup[i, j] = lookup[i - 1, j] || lookup[i - 1, j - nums[i - 1]];
                }
            }
        }
        
        return lookup[nums.Length, sum];
    }
}