public class Solution
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        int res = 0;
        if (source == target) return 0;
        var map = new Dictionary<int, List<int>>();

        for (var i = 0; i < routes.Length; i++)
            foreach (var numberOfBus in routes[i])
            {
                map.TryAdd(numberOfBus, new List<int>());
                map[numberOfBus].Add(i);
            }

        if (!map.ContainsKey(source) || !map.ContainsKey(target))
        {
            return -1;
        }

        var queue = new Queue<int>();
        var busses = new HashSet<int>();
        var stops = new HashSet<int>();

        queue.Enqueue(source);
        busses.Add(source);

        while (queue.Count > 0)
        {
            var size = queue.Count;
            for (var i = 0; i < size; i++)
            {
                var numberOfBus = queue.Dequeue();
                if (numberOfBus == target) return res;
                foreach (var numberOfStop in map[numberOfBus])
                {
                    if (stops.Contains(numberOfStop)) continue;
                    stops.Add(numberOfStop);

                    foreach (var bus in routes[numberOfStop])
                    {
                        if (busses.Contains(bus)) continue;
                        busses.Add(bus);
                        queue.Enqueue(bus);
                    }
                }
            }

            res++;
        }

        return -1;
    }
}