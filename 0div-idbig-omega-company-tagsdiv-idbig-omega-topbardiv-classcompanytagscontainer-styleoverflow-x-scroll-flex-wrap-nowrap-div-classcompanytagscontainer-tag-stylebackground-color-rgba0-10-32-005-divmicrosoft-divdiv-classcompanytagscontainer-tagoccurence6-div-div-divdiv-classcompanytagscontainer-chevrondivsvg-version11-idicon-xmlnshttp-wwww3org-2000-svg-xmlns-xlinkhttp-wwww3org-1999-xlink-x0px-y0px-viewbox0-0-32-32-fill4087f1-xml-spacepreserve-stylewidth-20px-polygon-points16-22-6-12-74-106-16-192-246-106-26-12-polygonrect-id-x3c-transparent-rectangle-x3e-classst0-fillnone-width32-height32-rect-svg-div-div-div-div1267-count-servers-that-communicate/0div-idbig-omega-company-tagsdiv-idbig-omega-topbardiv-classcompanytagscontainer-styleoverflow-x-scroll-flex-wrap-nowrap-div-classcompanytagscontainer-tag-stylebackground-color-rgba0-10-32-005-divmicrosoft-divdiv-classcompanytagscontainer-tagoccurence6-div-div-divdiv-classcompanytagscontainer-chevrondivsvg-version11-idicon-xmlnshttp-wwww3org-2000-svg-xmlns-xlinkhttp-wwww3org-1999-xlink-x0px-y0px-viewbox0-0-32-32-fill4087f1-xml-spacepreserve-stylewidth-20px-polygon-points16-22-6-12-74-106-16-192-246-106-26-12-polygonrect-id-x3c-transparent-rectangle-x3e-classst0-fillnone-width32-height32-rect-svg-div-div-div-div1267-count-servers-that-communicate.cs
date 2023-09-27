public class Solution {
    public int CountServers(int[][] grid) {
        int res  = 0;
        
        for(var i = 0; i<grid.Length; i++){
            for(var j = 0; j<grid[0].Length; j++){
                if(grid[i][j] == 1 && !IsIsolated(i, j, grid)){
                  res++;  
                }
            }
        }
        
        return res;
    }
    
    
    public bool IsIsolated(int row, int col, int[][] grid){
        for(var i = 0; i< grid.Length; i++){
            if(i!=row && grid[i][col] == 1) return false;
        }
        for(var j = 0; j< grid[0].Length; j++){
            if(j!=col && grid[row][j] == 1) return false;
        }
        return true;
    }
}