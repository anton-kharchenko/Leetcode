public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        var adjLst = new Dictionary<string, List<(string destiny, double qt)>>();
        
        for(var i = 0; i<equations.Count; i++){
            adjLst.TryAdd(equations[i][0], new List<(string destiny, double qt)>());
            adjLst.TryAdd(equations[i][1], new List<(string destiny, double qt)>());
            adjLst[equations[i][0]].Add((equations[i][1], values[i]));
            adjLst[equations[i][1]].Add((equations[i][0], 1/values[i]));
        }
        
        var answer = new List<double>();
        var visited = new HashSet<string>();
        
        foreach(var  query in queries){
            if(!adjLst.ContainsKey(query[0]) || !adjLst.ContainsKey(query[1])){
               answer.Add(-1.0);
                continue;
            }
            
            var res = Dfs(adjLst, visited, query[0], query[1], 1);
            answer.Add(res);
            visited.Clear();
        }
        
        return answer.ToArray();
    }
    
    private double Dfs(Dictionary<string, List<(string destiny, double qt)>> adjLst, HashSet<string> visited, string start, string end, double product){
        visited.Add(start);
        
        if(start == end) 
            return product;
        
        
        foreach(var node in adjLst[start]){
            if(!visited.Contains(node.destiny)){
                var res = Dfs(adjLst, visited, node.destiny, end, product * node.qt);
                
                if(res>=0)return res;
            }
        }
        
        return -1;
    }
}