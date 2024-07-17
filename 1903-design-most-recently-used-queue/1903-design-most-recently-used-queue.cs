public class MRUQueue {
    private SortedList<int, int> _sortedList;
    private int count;
    public MRUQueue(int n)
    {
        _sortedList = new SortedList<int, int>();
        for (int i = 1; i <= n; i++)
            _sortedList.Add(i, i);
        
        count = n;
    }
    
    public int Fetch(int k)
    {
        count += 1;
        var result = _sortedList.Values[k - 1];
        _sortedList.RemoveAt(k - 1);
        _sortedList.Add(count, result);
        return result;
    }
}

/**
 * Your MRUQueue object will be instantiated and called as such:
 * MRUQueue obj = new MRUQueue(n);
 * int param_1 = obj.Fetch(k);
 */