public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var adj = new List<List<int>>();
        
        for(var i = 0; i<numCourses; i++){
            adj.Add(new List<int>());
        }
        
        var indegree = new int[numCourses];
        
        foreach(var prerequisite in prerequisites){
            
            adj[prerequisite[1]].Add(prerequisite[0]);
            indegree[prerequisite[0]]++;
        }
        
        // BFS
        var q = new Queue<int>();
        
         // Add nodes with indegree 0 to the queue
        for(var i = 0; i<numCourses; i++){
            if(indegree[i]==0){
               q.Enqueue(i); 
            }
        }
        
        // Result 
        var res = new List<int>();
        
        // Perform BFS and courses to ordered list
        
        while(q.Count>0){
            var currentCourse = q.Dequeue();
            res.Add(currentCourse);
            
            foreach(var nextCourse in adj[currentCourse]){
                indegree[nextCourse]--;
                if(indegree[nextCourse]==0){
                     q.Enqueue(nextCourse);  
                }
            }
        }
        
        
        // We cannont complete all courses 
        // return empty arrya 
        if(res.Count< numCourses) return new int[0];
            
            
        return res.ToArray();
            
    }

}