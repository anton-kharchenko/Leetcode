public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var dictionary = new Dictionary<int, int>();
        var final = new List<int>();

        foreach (var number in arr1)
        {
            dictionary.TryAdd(number, 0);
            dictionary[number] += 1;
        }

        foreach (var number in arr2)
        {
            var count = dictionary[number];
            while (count > 0)
            {
                final.Add(number);
                count -= 1;
            }

            dictionary.Remove(number);
        }

        var keyValuePairs = dictionary.OrderBy(i => i.Key);
        foreach (var (number, _) in keyValuePairs)
        {
            var count = dictionary[number];
            while (count > 0)
            {
                final.Add(number);
                count -= 1;
            }
        }

        return final.ToArray();
    }
}