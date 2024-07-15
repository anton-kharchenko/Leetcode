public class MedianFinder {
    PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y)=>y.CompareTo(x)));
    PriorityQueue<int, int> maxHeap = new();

    public void AddNum(int num) {
        minHeap.Enqueue(num, num);
        var last = minHeap.Dequeue();
        maxHeap.Enqueue(last, last);
        if(minHeap.Count >= maxHeap.Count) return;
        var minInMax = maxHeap.Dequeue();
        minHeap.Enqueue(minInMax, minInMax);
    }
    
    public double FindMedian() {
        if(minHeap.Count == maxHeap.Count){
            return ((double)minHeap.Peek() + maxHeap.Peek()) / 2;
        }
        return minHeap.Count > maxHeap.Count ? minHeap.Peek() : maxHeap.Peek();
    }
}