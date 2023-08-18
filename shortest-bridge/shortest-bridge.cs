public class Solution {
    int n = 0;
    int[][] dirs = new int[][]{new int[2]{0,1}, new int[2]{1,0}, new int[2]{-1, 0}, new int[2]{0, -1}};
    public int ShortestBridge(int[][] grid) {
        n = grid.Length;
        HashSet<(int, int)> visited = new HashSet<(int, int)>();
        var q = new Queue<int[]>();
        var found = false;
       
        
        for(var i = 0; i<n; i++){
            if(found) break;
            for(var j = 0; j<n; j++){
                if(grid[i][j] == 1){
                    Dfs(grid, visited, q, i, j);
                    found = true;
                    break;
                }
            }
            
        }
        
        int steps = 0;
        
        while(q.Count>0){
            var size = q.Count;
            
            for(var i = 0; i<size; i++){
                var curr = q.Dequeue();
                int row = curr[0];
                int col = curr[1];
                for(var j = 0; j<4; j++){
                    var newRow = row + dirs[j][0];
                    var newCol = col + dirs[j][1];
                    if(newRow>=0&& newRow<n && newCol>=0 && newCol <n && !visited.Contains((newRow, newCol))){
                        if(grid[newRow][newCol] == 1){
                            return steps;
                        }
                        visited.Add((newRow, newCol));
                        q.Enqueue(new int[] { newRow, newCol });
                    }
                    
                }
            }
            steps++;
        }
        
        
        return -1;
        
    }
    
    
    public void Dfs(int[][] grid, HashSet<(int, int)> visited, Queue<int[]> q, int i, int j){
        if(i<0 ||j<0 || i>=grid.Length || j>= grid[0].Length|| visited.Contains((i, j)) || grid[i][j] != 1){
            return;
        }
        
        visited.Add((i, j));
        q.Enqueue(new int[]{i, j});
        
        foreach(var d in dirs){
            int newRow = i + d[0];
            int newCol = j + d[1];
            Dfs(grid, visited, q, newRow, newCol);
        }
    }
}