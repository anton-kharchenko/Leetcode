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
        return Recursion(nums, 0, sum);
    }

    public bool Recursion(int[] nums, int index, int sum){
        if (sum == 0) return true;
        if (index == nums.Length || sum < 0 || lookup[index, sum]) return false;

        if(Recursion(nums, index + 1, sum - nums[index]) || Recursion(nums, index + 1, sum)) return true;
        
        lookup[index, sum] = true;
        
        return false;

    }
}