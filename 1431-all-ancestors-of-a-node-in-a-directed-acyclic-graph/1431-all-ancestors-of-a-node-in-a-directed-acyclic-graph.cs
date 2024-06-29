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
            var children = new List<int>();
            Dfs(i, adj, new HashSet<int>(), children);
            var res = new List<int>();
            for (int j = 1; j < children.Count; j++)
            {
                res.Add(children[j]);
            }
            res.Sort();
            ans[children[0]] = res;
        }

        
        return ans;
    }

    private void Dfs(int vertex, Dictionary<int, List<int>> adj, HashSet<int> visited, List<int> children)
    {
        if(!visited.Add(vertex)) return;
        children.Add(vertex);
        foreach (var neigh in adj[vertex])
        {
            if(visited.Contains(neigh)) continue;
            Dfs(neigh, adj, visited, children);
        }
    }
}