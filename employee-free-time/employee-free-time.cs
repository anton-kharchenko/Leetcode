/*
// Definition for an Interval.
public class Interval {
    public int start;
    public int end;

    public Interval(){}
    public Interval(int _start, int _end) {
        start = _start;
        end = _end;
    }
}
*/

public class Solution {
    public IList<Interval> EmployeeFreeTime(IList<IList<Interval>> schedule) {
        PriorityQueue<Interval, int> q = new(schedule.SelectMany(x => x).Select(x => (x, x.start)));

        List<Interval> res = new();
        
        var end = q.Dequeue().end;
        
        while(q.Count > 0) {
            var next = q.Dequeue(); 
            
            if(end < next.start) {
                res.Add(new (end, next.start));
                end = next.end;
                continue;
            }
            if(next.end > end) {
                
                end = next.end; 
            }
        }
            
        return res;
    }
}