public class Solution {
    List<double> ans = new List<double>();
    HashSet<string> visited = new HashSet<string>();
    Dictionary<string, List<(string destiny, double cost)>> adj = new();
    
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
    
        
        for(var i = 0; i<equations.Count; i++){
            adj.TryAdd(equations[i][0], new List<(string destiny, double cost)>());
            adj.TryAdd(equations[i][1], new List<(string destiny, double cost)>());
            adj[equations[i][0]].Add((equations[i][1], values[i]));
            adj[equations[i][1]].Add((equations[i][0], 1/values[i]));
        }
        
        
        foreach(var  query in queries){
            if(!adj.ContainsKey(query[0]) || !adj.ContainsKey(query[1])){
                ans.Add(-1.0);
                continue;
            }
            
            var res = Dfs(query[0], query[1], 1.0);
            ans.Add(res);
            visited.Clear();
        }
        
        return ans.ToArray();
    }
    
    public double Dfs(string start, string end, double prod){
        
        visited.Add(start);
        if(start == end)
            return prod;
        
        foreach(var node in adj[start]){
            if(!visited.Contains(node.destiny)){
                var res = Dfs(node.destiny, end, prod * node.cost);
               
                if(res>= 0)
                    return res;
            }
        }
        
        return -1;
    }
}