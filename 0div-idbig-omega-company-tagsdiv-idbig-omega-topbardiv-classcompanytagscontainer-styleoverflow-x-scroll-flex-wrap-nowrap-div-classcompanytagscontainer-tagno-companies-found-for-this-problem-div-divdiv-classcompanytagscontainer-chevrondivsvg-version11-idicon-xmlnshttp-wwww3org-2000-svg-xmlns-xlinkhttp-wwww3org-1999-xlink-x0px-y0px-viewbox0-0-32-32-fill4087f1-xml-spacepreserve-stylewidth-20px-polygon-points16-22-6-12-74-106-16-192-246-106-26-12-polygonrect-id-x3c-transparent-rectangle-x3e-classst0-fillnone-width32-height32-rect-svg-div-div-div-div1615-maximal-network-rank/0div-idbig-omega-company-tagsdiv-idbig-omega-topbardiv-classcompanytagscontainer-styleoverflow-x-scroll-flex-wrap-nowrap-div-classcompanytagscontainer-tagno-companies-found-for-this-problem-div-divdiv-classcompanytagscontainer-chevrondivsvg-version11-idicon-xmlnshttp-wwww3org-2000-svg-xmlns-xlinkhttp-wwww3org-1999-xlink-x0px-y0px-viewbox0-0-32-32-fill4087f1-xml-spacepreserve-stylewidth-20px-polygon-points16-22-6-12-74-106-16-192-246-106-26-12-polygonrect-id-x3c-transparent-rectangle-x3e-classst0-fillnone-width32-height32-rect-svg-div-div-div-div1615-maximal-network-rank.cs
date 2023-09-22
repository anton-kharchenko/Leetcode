public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
        var graph = BuildGraph(n, roads);
        var maxRang = 0;
        
        for(var i = 0; i<n; i++){
            for(var j = i+1; j<n;j++){
                if(!graph[i].Contains(j)){
                    maxRang = Math.Max(maxRang, graph[i].Count + graph[j].Count);
                }else{
                    maxRang = Math.Max(maxRang, (graph[i].Count + graph[j].Count)-1);
                }
            }
        }
        
        return maxRang;
    }
    
    public Dictionary<int, HashSet<int>> BuildGraph(int n, int[][] roads){
        var dict = new Dictionary<int, HashSet<int>>();
        
        for(var i = 0; i<n; i++){
           dict.Add(i, new HashSet<int>()); 
        }
        
        foreach(var road in roads){
            dict[road[0]].Add(road[1]);
            dict[road[1]].Add(road[0]);
        }
        
        return dict;
    }
}