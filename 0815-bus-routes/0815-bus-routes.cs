public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target) {
        if (source == target) return 0;

        var g = new Dictionary<int, HashSet<int>>();

        for (int i = 0; i < routes.Length; i++)
        {
            foreach (int stop in routes[i])
            {
                if (!g.ContainsKey(stop))
                    g.Add(stop, new HashSet<int>());
                g[stop].Add(i);
            }
        }

        if (!g.ContainsKey(source) || !g.ContainsKey(target)) return -1;

        var busHs = new HashSet<int>();
        var stopHs = new HashSet<int>();
        var queue = new Queue<int>();
        queue.Enqueue(source);
        stopHs.Add(source);

        var res = 0;
        while (queue.Count > 0)
        {
            var size = queue.Count;
            for (var i = 0; i < size; i++)
            {
                var stop = queue.Dequeue();
                if (stop == target) return res;
                foreach (var nextBus in g[stop])
                {
                    if (busHs.Contains(nextBus)) continue;
                    busHs.Add(nextBus);
                    foreach (var nextStop in routes[nextBus])
                    {
                        if (stopHs.Contains(nextStop)) continue;
                        queue.Enqueue(nextStop);
                        stopHs.Add(nextStop);
                    }
                }
            }

            res++;
        }

        return -1;
    }
}