public class MedianFinder {
    PriorityQueue<double,double> H = new ();
    PriorityQueue<double,double> L = new ();
    double median;
    public MedianFinder() {
        
    }
    
    public void AddNum(int num) {
        if(H.Count==0)
        {    
            H.Enqueue(num,num);
            median = num;
        }
        else if(H.Count==L.Count)
        {
            double d = L.Dequeue();
            double h = d>num? d: num;
            H.Enqueue(h,h);            
            h = d>num? num: d;
            L.Enqueue(h,-h);
            median = H.Peek();
        }
        else
        {
            double d = H.Dequeue();
            double h = Math.Min(num,d);
            L.Enqueue(h,-h);
            h = Math.Max(num,d);
            H.Enqueue(h,h);
            median = (H.Peek() + L.Peek())/2;
        }
    }
    
    public double FindMedian() {
        return median;
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */