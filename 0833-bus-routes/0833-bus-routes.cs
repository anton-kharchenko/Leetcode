public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        var queue = new Queue<int>();
        var busses = new HashSet<int>();
        var stops = new HashSet<int>();
        var map = new Dictionary<int, List<int>>();
        var result = 0;
        for (int stop = 0; stop < routes.Length; stop++)
        {
            var route = routes[stop];
            foreach (var bus in route)
            {
                map.TryAdd(bus, []);
                map[bus].Add(stop);
            }
        }
        
        queue.Enqueue(source);
        busses.Add(source);
        while (queue.Count > 0)
        {
            var size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var bus = queue.Dequeue();
                if (bus == target) return result;
                if (map.ContainsKey(bus) is false) return -1;
                foreach (var stop in map[bus])
                {
                    if(stops.Contains(stop)) continue;
                    stops.Add(stop);
                    foreach (var currentBus in routes[stop])
                    {
                        if(busses.Contains(currentBus)) continue;
                        busses.Add(currentBus);
                        queue.Enqueue(currentBus);
                    }
                }
            }
            result += 1;
        }
        return -1;
    }
}