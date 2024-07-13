public class MRUQueue {
    SortedList<int, int> sl = new SortedList<int, int>();
    int count = 0;
    public MRUQueue(int n) {
        count = n;
        for(var i = 1; i<=n; i++)
            sl.Add(i, i);
    }
    
    public int Fetch(int k) {
        count += 1;
        var result = sl.Values[k - 1];
        sl.RemoveAt(k - 1);
        sl.Add(count, result);
        return result;
    }
}

/**
 * Your MRUQueue object will be instantiated and called as such:
 * MRUQueue obj = new MRUQueue(n);
 * int param_1 = obj.Fetch(k);
 */