public class Solution {
    int max = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        var visited = new HashSet<(int, int)>();
        
        for(var i = 0; i<grid.Length; i++){
            for(var j = 0; j<grid[0].Length; j++){
                if(!visited.Contains((i, j)) && grid[i][j] == 1){
                  max = Math.Max(Dfs(grid, visited, i, j), max) ;
                }
            }
        }
        
        return max;
    }
    
    
    public int Dfs(int[][] grid, HashSet<(int, int)> visited, int i, int j){
        if(i<0 || j<0 || i>= grid.Length || j>= grid[0].Length || grid[i][j] == 0 || visited.Contains((i, j))){
            return 0;
        }
        
        visited.Add((i,j));
        
        return 1 + Dfs(grid, visited, i+1, j)
         + Dfs(grid, visited, i-1, j)
         + Dfs(grid, visited, i, j+1)
         + Dfs(grid, visited, i, j-1);
    }
}