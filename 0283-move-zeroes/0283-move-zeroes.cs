public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var n = nums.Length;
        
        var temp = new List<int>();

        for (var i = 0; i < n; i++)
        {
            if (nums[i] != 0)
            {
                temp.Add(nums[i]);
            }
        }

        Array.Fill(nums, 0);
        
        for (var i = 0; i < n; i++)
        {
            if (i < temp.Count)
            {
                nums[i] = temp[i];
            }
        }
    }
}