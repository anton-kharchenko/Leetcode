public class Solution {
    public int NumEnclaves(int[][] grid) {
        var land  = 0;
        var rows = grid.Length;
        var cols = grid[0].Length;
        var visited = new bool[rows,cols];
        
        for(var i = 0; i<rows; i++){
            for(var j = 0; j<cols;j++){
                if(i==0|| j==0|| i==rows-1 ||j==cols-1){
                    Dfs(rows, cols, i, j, grid, visited);
                }
            }   
        }
        
        for(var i = 1; i<rows-1; i++){
            for(var j = 1; j<cols-1;j++)
            {
                if(!visited[i,j] && grid[i][j] == 1){
                   land++; 
                }
            }
        }
        
        return land;
    }
    
    
    public void Dfs(int rows, int cols, int i, int j, int[][] grid, bool[,]visited){
        if(i<0 || j<0 || i>= rows|| j >= cols|| visited[i,j] || grid[i][j] ==0){
            return;
        }
        
        visited[i,j] = true;
      
       Dfs(rows, cols, i+1, j, grid, visited);
       Dfs(rows, cols, i-1, j, grid, visited);
       Dfs(rows, cols, i, j+1, grid, visited);
       Dfs(rows, cols, i, j-1, grid, visited);
    }
}