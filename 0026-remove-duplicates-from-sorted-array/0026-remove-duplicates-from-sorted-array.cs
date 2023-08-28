public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var arr = new HashSet<int>(nums).ToArray(); // O(n)
        
        Array.Fill(nums, 0); // O(n)
        
        for(var i = 0; i<arr.Length; i++){
            nums[i] = arr[i]; 
        }
        
        return arr.Length;
    }
}

// Space - O(n)
// Time - O(n)