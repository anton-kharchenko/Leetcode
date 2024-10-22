public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target) {
        var queue = new Queue<int>();
        var busses = new HashSet<int>();
        var stops = new HashSet<int>();
        var adjList = new Dictionary<int, List<int>>();
        var numberOfBuses = 0;
        
        for (int i = 0; i < routes.Length; i++)
        {
            var route = routes[i];
            foreach (var bus in route)
            {
                adjList.TryAdd(bus, new List<int>());
                adjList[bus].Add(i);
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
                if (bus==target)
                {
                    return numberOfBuses;
                }

                if (!adjList.ContainsKey(bus))
                {
                    return -1;
                }

                foreach (var stop in adjList[bus])
                {
                    if(stops.Contains(stop)) continue;
                    stops.Add(stop);
                    foreach (var currentBus in routes[stop])              
                    {
                        if (busses.Contains(currentBus))
                        {
                            continue;
                        }
                        busses.Add(currentBus);
                        queue.Enqueue(currentBus);
                    }
                }
            }
            numberOfBuses++;
        }

        return -1;
    }
}