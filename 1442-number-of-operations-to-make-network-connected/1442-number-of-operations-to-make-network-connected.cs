public class Solution {
    public int MakeConnected(int n, int[][] connections) {
        if(n - 1 > connections.Length) return -1;
        var adj = new Dictionary<int, List<int>>();

        for(var i = 0; i<n; i++){
            adj.Add(i, new List<int>());
        }

        foreach(var connection in connections){
            var first = connection[0];
            var second = connection[1];
            adj[first].Add(second);
            adj[second].Add(first);
        }

        var result = 0;
        var visited = new HashSet<int>();

        for(var i = 0; i<n; i++){
            if(!visited.Contains(i)){
                Dfs(adj, visited, i);
                result += 1;
            }
        }
        return result - 1;
    }

    public void Dfs(Dictionary<int, List<int>> adj, HashSet<int> visited, int node){
        if(visited.Contains(node)){
            return;
        }
        visited.Add(node);
        foreach(var neighbour in adj[node]){
            if(visited.Contains(neighbour)) continue;
            Dfs(adj, visited, neighbour);
        }
    }
}