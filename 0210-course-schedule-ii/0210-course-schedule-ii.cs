public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var adj = new List<List<int>>();
        var res = new List<int>();
        for(var i = 0; i<numCourses; i++){
            adj.Add(new List<int>());
        }
        
        var indeegree = new int[numCourses];
        
        foreach(var prerequisite in prerequisites){
            adj[prerequisite[1]].Add(prerequisite[0]);
            indeegree[prerequisite[0]]++;
        }
        
        var q = new Queue<int>();
        
        for(var i = 0; i<indeegree.Length; i++){
            if(indeegree[i] == 0){
                q.Enqueue(i);
            }
        }
        
        
        // BFS
        while(q.Count> 0){
            var curr = q.Dequeue();
            res.Add(curr);
            
            foreach(var next in adj[curr]){
                indeegree[next]--;
                if(indeegree[next] == 0){
                    q.Enqueue(next);
                }
            }
        }
        
        
        if(res.Count< numCourses)
            return new int[0];
        
        return res.ToArray();
    }

}