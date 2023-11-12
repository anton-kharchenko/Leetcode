public class Solution
{
    Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        if(source == target) return 0;
        for(var bus = 0;bus<routes.Length; bus++){
            foreach(var stop in routes[bus]){
                map.TryAdd(stop, new List<int>());
                map[stop].Add(bus);
            }
        }
        
        var q = new Queue<int>();
        var busses = new HashSet<int>();
        var stops = new HashSet<int>();
        
        q.Enqueue(source);
        stops.Add(source);
        var level = 0;
        
        while(q.Count>0){
            var size = q.Count;
            for(var i = 0; i<size; i++){
                var curr = q.Dequeue();
                if(curr == target) 
                    return level;
                
                foreach(var bus in map[curr]){
                    if(busses.Contains(bus)) continue;
                    busses.Add(bus);
                    
                    foreach(var stop in routes[bus]){
                        if(stops.Contains(stop)) continue;
                        q.Enqueue(stop);
                        stops.Add(stop);
                    }
                }
            }
            level++;
        }
        
        return -1;
    }
}