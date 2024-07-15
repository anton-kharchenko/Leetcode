public class MedianFinder {

    PriorityQueue<int, int> meanHeap = new (Comparer<int>.Create((x,y)=>y.CompareTo(x)));
    PriorityQueue<int, int> maxHeap = new ();

    public void AddNum(int num) {
        meanHeap.Enqueue(num,  num);
        var x = meanHeap.Dequeue();
        maxHeap.Enqueue(x, x);
        if (maxHeap.Count > meanHeap.Count)
        {
            int y = maxHeap.Dequeue();
            meanHeap.Enqueue(y, y);
        }
    }
    
    public double FindMedian() {
        if (meanHeap.Count == maxHeap.Count)
        {
            return (meanHeap.Peek() + (double)maxHeap.Peek())/2;
        }
        if (meanHeap.Count > maxHeap.Count)
        {
            return meanHeap.Peek();
        }
        return maxHeap.Peek();
    }
}