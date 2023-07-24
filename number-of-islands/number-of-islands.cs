public class Solution {
 public int NumIslands(char[][] grid) {
     var count = 0;
    for(var i = 0; i< grid.Length; i++){
        for(var j = 0; j<grid[0].Length; j++){
            if(grid[i][j] =='1'){
                count++;
              Dfs(i, j, grid.Length, grid[0].Length, grid);  
            }
            
        }
    }
     
     return count;
 }
    
    public void Dfs(int i, int j, int n, int m, char[][] grid){
        if(i<0 || j< 0|| i>=n|| j>=m || grid[i][j] == '0'){
            return;
        }
        
        grid[i][j] = '0';
        Dfs(i+1, j, n, m, grid);
        Dfs(i-1, j, n, m, grid);
        Dfs(i, j+1, n, m, grid);
        Dfs(i, j-1, n, m, grid);
    }
}