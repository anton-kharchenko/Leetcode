public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, List<int>> preMap = new Dictionary<int, List<int>>();
        HashSet<int> visited = new HashSet<int>();
        
        for(var i = 0; i<numCourses; i++){
            preMap.Add(i, new List<int>());
        }
        
        foreach(var course in prerequisites){
            var courseToTake = course[0];
            var courseDepend = course[1];
            
            preMap[courseToTake].Add(courseDepend);
        }
        
        for(var i = 0; i<numCourses; i++){
            if(!Dfs(preMap, visited, i)){
                return false;
            }
        }
        
        return true;
    }
    
    
    public bool Dfs(Dictionary<int, List<int>> map, HashSet<int> visited, int numCourse ){
        if(visited.Contains(numCourse)){
            return false;
        }
        
        if(map[numCourse] == new List<int>()){
            return true;
        }
        
        visited.Add(numCourse);
        foreach(var c in map[numCourse]){
            if(!Dfs(map, visited, c)){
                return false;
            }
        }
        
        visited.Remove(numCourse);
        map[numCourse] = new List<int>();
        return true;
    }
    
}