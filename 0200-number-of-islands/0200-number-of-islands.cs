public class Solution {
 public int NumIslands(char[][] grid) {
     var n = grid.Length;
     var m = grid[0].Length;
     var res = 0;
    for(var i = 0; i<n; i++){
        for(var j = 0; j<m; j++){
            if(grid[i][j] == '1'){
                res++;
                Dfs(i, j, n, m, grid);
            }
        }
    }
     
     return res;
  }
    
    public void Dfs(int i, int j, int n, int m, char[][] grid){
        if(i<0 || j<0|| i>=n||j>=m || grid[i][j] == '0'){
            return;
        }
        
        grid[i][j] = '0';
        Dfs(i+1, j, n, m, grid);
        Dfs(i-1, j, n, m, grid);
        Dfs(i, j+1, n, m, grid);
        Dfs(i, j-1, n, m, grid);
    }
}