public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var res = new List<int>();
        var adj = new List<List<int>>();
        
        for(var i = 0; i<numCourses; i++){
            adj.Add(new List<int>());
        }
        var indegree = new int[numCourses];
        
        for(var i = 0; i< prerequisites.Length; i++){
            adj[prerequisites[i][1]].Add(prerequisites[i][0]);
            indegree[prerequisites[i][0]]++;
        }
        
        var q = new Queue<int>();
        
        for(var i = 0; i<indegree.Length; i++){
            if(indegree[i] == 0)
                q.Enqueue(i);
        }
        
        while(q.Count>0){
            var curr = q.Dequeue();
            res.Add(curr);
            foreach(var next in adj[curr]){
                indegree[next]--;
                if(indegree[next] == 0)
                    q.Enqueue(next);
            }
            
        }
        
        if(numCourses> res.Count) return new int[0];
        
        
        return res.ToArray();
    }

}