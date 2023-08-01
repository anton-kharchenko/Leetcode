public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);

        var maxLength = 0;
       
        while (set.Count > 0)
        {
            var first = set.First();
            var last = first;

            while (set.Contains(first - 1))
            {
                first -= 1;
                set.Remove(first);
            }

            set.Remove(last);

            while (set.Contains(last + 1))
            {
                last += 1;
                set.Remove(last);
            }

            maxLength = Math.Max(maxLength, last - first + 1);
        }

        return maxLength;
    }
}