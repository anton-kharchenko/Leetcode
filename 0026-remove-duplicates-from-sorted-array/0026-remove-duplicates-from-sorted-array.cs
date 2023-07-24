public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var array = new HashSet<int>(nums).ToArray();
        
        Array.Fill(nums, 0);
        
        for (var i = 0; i < array.Length; i++)
        {
            nums[i] = array[i];
        }

        return array.Length;
    }
}