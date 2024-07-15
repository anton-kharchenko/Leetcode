public class MedianFinder {

    PriorityQueue<int, int> _minHeap = new (Comparer<int>.Create((x,y)=>y.CompareTo(x)));
    PriorityQueue<int, int> _maxHeap = new ();

    public void AddNum(int num) {
        _minHeap.Enqueue(num,  num);
        
        var maxNumberInMeanQueue = _minHeap.Dequeue(); 
        _maxHeap.Enqueue(maxNumberInMeanQueue, maxNumberInMeanQueue);

        if (_maxHeap.Count <= _minHeap.Count) return;
        
        var minNumberInMaxQueue = _maxHeap.Dequeue();
        _minHeap.Enqueue(minNumberInMaxQueue, minNumberInMaxQueue);
    }
    
    public double FindMedian() {
        if (_minHeap.Count == _maxHeap.Count)
        {
            return (_minHeap.Peek() + (double)_maxHeap.Peek())/2;
        }
        
        return _minHeap.Count > _maxHeap.Count ? _minHeap.Peek() : _maxHeap.Peek();
    }
}