public class Solution
{
    Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        
        for(int bus = 0; bus<routes.Length; bus++){
            foreach(var st in routes[bus]){
                map.TryAdd(st, new List<int>());
                map[st].Add(bus);
            }
        }
        var res = 0;
        
        if(source == target) return 0;
        
        var q = new Queue<int>();
        var stops = new HashSet<int>();
        var busses = new HashSet<int>();
        q.Enqueue(source);
        stops.Add(source);
        
        while(q.Count>0){
            var size = q.Count();
            for(var i = 0; i<size; i++){
                var stop = q.Dequeue();
                if(stop == target)
                    return res;
                
                foreach(var bus in map[stop]){
                    if(busses.Contains(bus)) continue;
                    busses.Add(bus);
                    foreach(var s in routes[bus]){
                        if(stops.Contains(s)) continue;
                        stops.Add(s);
                        q.Enqueue(s);
                    }
                    
                }
                
            }
            
            
            res++;
        }
        
        return  -1;
    }
}