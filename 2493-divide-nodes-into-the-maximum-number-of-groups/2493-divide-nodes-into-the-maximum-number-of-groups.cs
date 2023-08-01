public class Solution
{
    public int MagnificentSets(int n, int[][] edges)
    {
        var graph = new List<int>[n + 1];

        for (int i = 0; i <= n; i++)
            graph[i] = new List<int>();

        foreach (int[] edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var maxGroups = 0;
        var components = GetComponents(n, graph);

        foreach (var component in components)
        {
            var maxGroupsLocal = 0;
            foreach (var vert in component)
            {
                var group = Bfs(vert, graph);
                if (group == -1) return -1;
                maxGroupsLocal = Math.Max(maxGroupsLocal, group);
            }

            maxGroups += maxGroupsLocal;
        }

        return maxGroups;
    }

    List<IList<int>> GetComponents(int n, List<int>[] graph)
    {
        var components = new List<IList<int>>();
        var visited = new HashSet<int>();

        for (var i = 1; i <= n; i++)
        {
            if (visited.Add(i))
            {
                var component = new List<int>();
                Dfs(i, component, graph, visited);
                components.Add(component);
            }
        }


        return components;
    }


    void Dfs(int start, List<int> component, List<int>[] graph, HashSet<int> visited)
    {
        component.Add(start);

        foreach (var next in graph[start])
        {
            if (visited.Add(next))
            {
                Dfs(next, component, graph, visited);
            }
        }
    }

    int Bfs(int start, List<int>[] graph)
    {
        int groups = 0;
        var visited = new HashSet<int>();
        var prev = new HashSet<int>();
        var queue = new Queue<int>();
        queue.Enqueue(start);
        visited.Add(start);
        prev.Add(start);

        while (queue.Count > 0)
        {
            int size = queue.Count;
            var current = new HashSet<int>();

            for (var i = 0; i < size; i++)
            {
                int curr = queue.Dequeue();
                foreach (int next in graph[curr])
                {
                    if (prev.Contains(next))
                        return -1;
                    if (visited.Add(next))
                    {
                        current.Add(next);
                        queue.Enqueue(next);
                    }
                }
            }

            prev = current;
            groups++;
        }

        return groups;
    }
}