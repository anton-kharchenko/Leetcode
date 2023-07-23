public class Solution {
 public int NumIslands(char[][] grid) {
 var count  = 0;
 var n = grid.Length;
 var m = grid[0].Length;    
 for(var i=0; i<n; i++){
     for(var j = 0; j<m; j++){
         if(grid[i][j] == '1'){
             Dfs(i, j, n, m, grid);
             count++;
         }
     }
 } 
     
     
     
 return count;
 }
    
    public void Dfs(int i, int j, int n, int m, char[][] grid){
        if(i>=n || j>=m || i<0 || j<0 || grid[i][j] == '0'){
            return;
        }
        
        grid[i][j] = '0';
        Dfs(i+1, j, n, m, grid);
        Dfs(i-1, j, n, m, grid);
        Dfs(i, j+1, n, m, grid);
        Dfs(i, j-1, n, m, grid);
    }
}