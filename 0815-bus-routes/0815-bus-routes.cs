public class Solution
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        if (source == target) return 0;

        var map = new Dictionary<int, HashSet<int>>();

        for (var numberOfStop = 0; numberOfStop < routes.Length; numberOfStop++)
        {
            foreach (int numberOfBus in routes[numberOfStop])
            {
                if (!map.ContainsKey(numberOfBus))
                    map.Add(numberOfBus, new HashSet<int>());
                map[numberOfBus].Add(numberOfStop);
            }
        }

        if (!map.ContainsKey(source) || !map.ContainsKey(target)) return -1;

        var buses = new HashSet<int>();
        var stops = new HashSet<int>();
        var queue = new Queue<int>();
        
        queue.Enqueue(source);
        stops.Add(source);

        var res = 0;
        
        while (queue.Count > 0)
        {
            var size = queue.Count;
            
            for (var i = 0; i < size; i++)
            {
                var numberOfBus = queue.Dequeue();
                if (numberOfBus == target) return res;
                
                foreach (var numberOfStop in map[numberOfBus])
                {
                    if (buses.Contains(numberOfStop)) continue;
                    buses.Add(numberOfStop);
                    
                    foreach (var nextStop in routes[numberOfStop])
                    {
                        if (stops.Contains(nextStop)) continue;
                        queue.Enqueue(nextStop);
                        stops.Add(nextStop);
                    }
                }
            }

            res++;
        }

        return -1;
    }
}