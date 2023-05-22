public class Solution {
    public int FindDuplicate(int[] nums) {
        var set = new HashSet<int>();
        foreach (var item in nums)
        {
            if (set.Contains(item))
            {
                return item;
            }
            else
            {
                set.Add(item);
            }
        }

        return 0;
    }
}