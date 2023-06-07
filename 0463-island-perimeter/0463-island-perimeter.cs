public class Solution {
    int result = 0;
    public int IslandPerimeter(int[][] grid) {
        var visited = new bool[grid.Length][];
        
        for(var i =0; i<grid.Length; i++){
            visited[i] = new bool[grid[0].Length];    
            for(var j = 0; j<grid[0].Length; j++){
                visited[i][j] = false;
            }
        }
        
        for(var i =0; i<grid.Length; i++){
            for(var j = 0; j<grid[0].Length; j++){
                if(!visited[i][j] &&  grid[i][j] == 1){
                     Dfs(grid, visited, i, j);
                }
               
            }
        }
        return result;
    }
    
    public int Dfs(int[][] grid, bool[][]visited, int i, int j){
        if(i>=grid.Length || j>=grid[0].Length || i<0 || j<0 || grid[i][j] == 0)
            return 1;
        
        if(visited[i][j] == true)
            return 0;
        
        visited[i][j] = true;
        result = Dfs(grid, visited, i+1, j);
        result += Dfs(grid, visited, i-1, j);
        result += Dfs(grid, visited, i, j+1);
        result += Dfs(grid, visited, i, j-1);
        
        return result;
    }
}