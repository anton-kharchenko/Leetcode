public class Solution {
    public IList<IList<int>> GetAncestors(int n, int[][] edges)
    {
        var adj = new Dictionary<int, List<int>>();
        var ans = new List<IList<int>>();
        for (var i = 0; i<n;i++)
        {
            adj.Add(i, new List<int>());
            ans.Add(new List<int>());
        }

        foreach (var edge in edges)
        {
            adj[edge[1]].Add(edge[0]);
        }
        
        for (int i = 0; i < adj.Count; i++)
        {
            var children = new Stack<int>();
            Dfs(i, adj, new HashSet<int>(), children);
            var res = new List<int>();
            while (children.Count() > 1)
            {
                res.Add(children.Pop());
            }
            res.Sort();
            ans[children.Peek()] = res;
        }

        
        return ans;
    }

    private void Dfs(int vertex, Dictionary<int, List<int>> adj, HashSet<int> visited, Stack<int> children)
    {
        if(!visited.Add(vertex)) return;
        children.Push(vertex);
        foreach (var neigh in adj[vertex])
        {
            if(visited.Contains(neigh)) continue;
            Dfs(neigh, adj, visited, children);
        }
    }
}