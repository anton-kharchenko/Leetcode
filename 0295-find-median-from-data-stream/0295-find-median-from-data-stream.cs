public class MedianFinder {
    PriorityQueue<double,double> _high = new ();
    PriorityQueue<double,double> _low = new ();
    double _median;
    public MedianFinder() {
        
    }
    
    public void AddNum(int num) {
        if(_high.Count==0)
        {    
            _high.Enqueue(num,num);
            _median = num;
        }
        else if(_high.Count==_low.Count)
        {
            var d = _low.Dequeue();
            var h = d>num? d: num;
            _high.Enqueue(h,h);            
            h = d>num? num: d;
            _low.Enqueue(h,-h);
            _median = _high.Peek();
        }
        else
        {
            var d = _high.Dequeue();
            var h = Math.Min(num,d);
            _low.Enqueue(h,-h);
            h = Math.Max(num,d);
            _high.Enqueue(h,h);
            _median = (_high.Peek() + _low.Peek())/2;
        }
    }
    
    public double FindMedian() {
        return _median;
    }
}