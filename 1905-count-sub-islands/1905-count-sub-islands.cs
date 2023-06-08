public class Solution {
    int count  = 0;
    public int CountSubIslands(int[][] grid1, int[][] grid2) {
    
        for(var i = 0; i<grid1.Length; i++){
            for(var j = 0; j<grid1[0].Length; j++){
                if(grid1[i][j] == 0 && grid2[i][j] == 1){
                    Dfs(grid2, i, j);
                }
            }
        }
        
       for(var i = 0; i<grid1.Length; i++){
            for(var j = 0; j<grid1[0].Length; j++){
                if(grid2[i][j] == 1){
                    count++;
                    Dfs(grid2, i, j);
                }
            }
        }
        return count;
    }
    
    public void Dfs(int[][] grid, int i, int j){
        if(i<0 || j<0 || i>=grid.Length || j>= grid[0].Length || grid[i][j] != 1 ){
            return;
        }
        
        grid[i][j] = 0;
        
        
         Dfs(grid, i+1, j );
       Dfs(grid, i-1, j);
        Dfs(grid, i, j+1);
        Dfs(grid, i, j-1);
        
    
    }
    

}