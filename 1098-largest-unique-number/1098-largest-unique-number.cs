public class Solution {
    public int LargestUniqueNumber(int[] nums)
    {
        var arr = new List<int>();
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            dict.TryAdd(num, 0);
            dict[num]++;
        }

        foreach (var (key, value) in dict)
        {
            if(value > 1) continue;
            arr.Add(key);
        }

        if (arr.Count == 0) return -1;
        return arr.Max();
    }
}