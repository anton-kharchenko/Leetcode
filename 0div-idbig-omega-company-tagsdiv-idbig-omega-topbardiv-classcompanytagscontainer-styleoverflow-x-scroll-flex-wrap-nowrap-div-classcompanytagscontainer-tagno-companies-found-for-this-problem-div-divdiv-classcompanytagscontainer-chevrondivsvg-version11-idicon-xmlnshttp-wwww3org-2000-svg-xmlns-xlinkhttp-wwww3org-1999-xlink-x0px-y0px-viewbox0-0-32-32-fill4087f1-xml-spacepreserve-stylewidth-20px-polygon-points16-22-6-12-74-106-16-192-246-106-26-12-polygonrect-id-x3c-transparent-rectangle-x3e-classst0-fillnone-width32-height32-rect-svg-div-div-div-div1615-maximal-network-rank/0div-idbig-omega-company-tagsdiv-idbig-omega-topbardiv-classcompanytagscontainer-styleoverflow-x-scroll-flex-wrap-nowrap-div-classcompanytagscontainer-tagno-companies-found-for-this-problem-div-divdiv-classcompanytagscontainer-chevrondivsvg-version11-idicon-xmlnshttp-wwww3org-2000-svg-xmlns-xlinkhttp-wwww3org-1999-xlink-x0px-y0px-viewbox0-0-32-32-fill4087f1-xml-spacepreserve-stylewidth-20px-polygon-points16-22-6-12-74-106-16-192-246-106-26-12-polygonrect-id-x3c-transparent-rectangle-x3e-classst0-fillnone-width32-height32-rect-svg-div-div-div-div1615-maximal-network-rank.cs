public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
        var graph = BuildGraph(n, roads);
        var max = 0;
        for(var i = 0; i<n; i++){
            for(var j = i+1; j<n;j++){
                if(!graph[i].Contains(j)){
                   max = Math.Max(max, graph[i].Count + graph[j].Count); 
                }else{
                    max = Math.Max(max, (graph[i].Count + graph[j].Count) - 1 );
                }
            }
        }
        return max;
    }
    
    public Dictionary<int, HashSet<int>> BuildGraph(int n, int[][] roads){
        var graph = new Dictionary<int, HashSet<int>>();
        
        for(var i = 0; i<n; i++){
            graph.Add(i, new HashSet<int>());
        }
        
        for(var i = 0; i<roads.Length; i++){
            var road = roads[i];
            graph[road[0]].Add(road[1]);
            graph[road[1]].Add(road[0]);
        }
        
        return graph;
    }
}