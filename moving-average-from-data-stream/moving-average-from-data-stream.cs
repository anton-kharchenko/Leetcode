public class MovingAverage {
    Queue<int> q = new Queue<int>();
    int count = 0;
    public MovingAverage(int size) {
        count = size;
    }
    
    public double Next(int val) {
        
        if(count == q.Count && q.Count>0){
            q.Dequeue();
        }
        
        q.Enqueue(val);
        
        var s = q.Count;
            
        var res = 0.0;
        
        foreach(var el in q){
            res += el;    
        }
        
        return (double) res / s;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */