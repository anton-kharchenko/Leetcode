public class Solution {
    public int DeleteAndEarn(int[] nums)
    {
        var arr = new int[10001];
        foreach (var num in nums)
        {
            arr[num] += num;
        }

        var cache = new int[arr.Length];
        cache[0] = arr[0];
        cache[1] = arr[1];
        for (int i = 2; i < arr.Length; i++)
        {
            cache[i] = Math.Max(arr[i] + cache[i - 2],  cache[i - 1]);
        }
        
        return cache[arr.Length - 1];
    }

}