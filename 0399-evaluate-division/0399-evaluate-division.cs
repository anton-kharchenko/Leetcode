public class Solution {
    Dictionary<string, List<(string dest, double cost)>> adj = new Dictionary<string, List<(string dest, double cost)>>();
    List<double> ans = new List<double>();
    HashSet<string> visited = new HashSet<string>();
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
    
        
        for(var i = 0; i<equations.Count; i++){
            adj.TryAdd(equations[i][0], new List<(string dest, double cost)>());
            adj.TryAdd(equations[i][1], new List<(string dest, double cost)>());
            adj[equations[i][0]].Add((equations[i][1], values[i]));
            adj[equations[i][1]].Add((equations[i][0], 1/values[i]));
        }
        
        
        foreach(var q in queries){
            if(!adj.ContainsKey(q[0]) || !adj.ContainsKey(q[1])){
                ans.Add(-1.0);
                continue;
            }
            
            var res = Dfs(q[0], q[1], 1);
            ans.Add(res);
            visited.Clear();
        }
        
        return ans.ToArray();
    }
    
    
    public double Dfs(string start, string end, double prod){
        if(start == end){
            return prod;
        }
        
        visited.Add(start);
        
        foreach(var neigh in adj[start]){
            if(!visited.Contains(neigh.dest)){
               var res = Dfs(neigh.dest, end, prod * neigh.cost);  
               if(res>= 0) return res;
            }
        }
        
        return -1;
    }
}