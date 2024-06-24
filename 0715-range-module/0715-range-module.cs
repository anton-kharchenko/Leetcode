public class RangeModule
{
    private SortedDictionary<int, int> intervals;

    public RangeModule()
    {
        intervals = new SortedDictionary<int, int>();
    }

    public void AddRange(int left, int right)
    {
        if (left >= right) return;
        var newIntervals = new List<KeyValuePair<int, int>>();

        foreach (var kvp in intervals)
        {
            int start = kvp.Key;
            int end = kvp.Value;

            if (end < left || start > right)
            {
                newIntervals.Add(kvp);
            }
            else
            {
                left = Math.Min(left, start);
                right = Math.Max(right, end);
            }
        }

        newIntervals.Add(new KeyValuePair<int, int>(left, right));

        intervals.Clear();
        foreach (var kvp in newIntervals)
        {
            intervals[kvp.Key] = kvp.Value;
        }
    }

    public bool QueryRange(int left, int right)
    {
        if (left >= right) return false;

        foreach (var kvp in intervals)
        {
            int start = kvp.Key;
            int end = kvp.Value;

            if (start <= left && end >= right)
            {
                return true;
            }
        }
        return false;
    }

    public void RemoveRange(int left, int right)
    {
        if (left >= right) return;
        var newIntervals = new List<KeyValuePair<int, int>>();

        foreach (var kvp in intervals)
        {
            int start = kvp.Key;
            int end = kvp.Value;

            if (end <= left || start >= right)
            {
                newIntervals.Add(kvp);
            }
            else
            {
                if (start < left)
                {
                    newIntervals.Add(new KeyValuePair<int, int>(start, left));
                }
                if (end > right)
                {
                    newIntervals.Add(new KeyValuePair<int, int>(right, end));
                }
            }
        }

        intervals.Clear();
        foreach (var kvp in newIntervals)
        {
            intervals[kvp.Key] = kvp.Value;
        }
    }
}
