public class KthLargest {
    PriorityQueue<int, int> pq = new();
    int k;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        foreach(var num in nums)
            Add(num);
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        if(pq.Count>k)
            pq.Dequeue();
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */