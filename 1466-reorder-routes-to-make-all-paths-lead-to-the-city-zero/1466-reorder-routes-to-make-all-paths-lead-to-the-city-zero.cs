public class Solution {
    public int MinReorder(int n, int[][] connections) {
        var graph = new List<(int node, bool isCorrectDiraction)>[n];

        for (var i = 0; i < n; i++)
        {
            graph[i] = new List<(int node, bool isCorrectDiraction)>();
        }

        foreach (var con in connections)
        {
            graph[con[0]].Add((con[1], true));
            graph[con[1]].Add((con[0], false));
        }

        var visited = new bool[n];
        var result = 0;

        for (var i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                visited[i] = true;
                Dfs(ref result, i, graph, visited);
            }
        }

        return result;            
    }
    
    public void Dfs(ref int res, int inx, List<(int node, bool isCorrectDiraction)>[] graph,  bool[] visited){
        for (var i = 0; i < graph[inx].Count; i++)
        {
            if (!visited[graph[inx][i].node])
            {
                visited[graph[inx][i].node] = true;
                if (graph[inx][i].isCorrectDiraction)
                {
                    res++;
                }

                Dfs(ref res, graph[inx][i].node, graph, visited);
            }
        }
    }
}