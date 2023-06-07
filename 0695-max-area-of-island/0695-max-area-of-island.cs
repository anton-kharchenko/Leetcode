public class Solution {
    int max = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        var visited = new bool[grid.Length][];
        
        for(var i = 0; i<grid.Length; i++){
            visited[i] = new bool[grid[0].Length];
            for(var j = 0; j<grid[0].Length; j++){
                visited[i][j] = false; 
            }
        }
        
        for(var i = 0; i<grid.Length; i++){
            for(var j = 0; j<grid[0].Length; j++){
                if(!visited[i][j] && grid[i][j] == 1){
                  max = Math.Max(Dfs(grid, visited, i, j), max)  ;
                }
            }
        }
        
        return max;
    }
    
    
    public int Dfs(int[][] grid, bool[][]visited, int i, int j){
        if(i<0 || j<0 || i>= grid.Length || j>= grid[0].Length || grid[i][j] == 0 || visited[i][j]){
            return 0;
        }
        
        visited[i][j] = true;
        
        return 1 + Dfs(grid, visited, i+1, j)
         + Dfs(grid, visited, i-1, j)
         + Dfs(grid, visited, i, j+1)
         + Dfs(grid, visited, i, j-1);
    }
}